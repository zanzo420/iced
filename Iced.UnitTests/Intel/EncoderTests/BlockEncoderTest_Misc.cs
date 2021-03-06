﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_ENCODER
using System;
using Iced.Intel;
using Xunit;

namespace Iced.UnitTests.Intel.EncoderTests {
	public sealed class BlockEncoderTest_Misc {
		[Fact]
		void Encode_zero_blocks() {
			string errorMessage;

			errorMessage = BlockEncoder.Encode(16, new InstructionBlock[0], BlockEncoderOptions.None);
			Assert.Null(errorMessage);

			errorMessage = BlockEncoder.Encode(32, new InstructionBlock[0], BlockEncoderOptions.None);
			Assert.Null(errorMessage);

			errorMessage = BlockEncoder.Encode(64, new InstructionBlock[0], BlockEncoderOptions.None);
			Assert.Null(errorMessage);
		}

		[Fact]
		void Encode_zero_instructions() {
			string errorMessage;
			var codeWriter = new CodeWriterImpl();

			errorMessage = BlockEncoder.Encode(16, new InstructionBlock(codeWriter, Array.Empty<Instruction>(), 0, Array.Empty<RelocInfo>(), Array.Empty<uint>(), Array.Empty<ConstantOffsets>()), BlockEncoderOptions.None);
			Assert.Null(errorMessage);
			Assert.Empty(codeWriter.ToArray());

			errorMessage = BlockEncoder.Encode(32, new InstructionBlock(codeWriter, Array.Empty<Instruction>(), 0, Array.Empty<RelocInfo>(), Array.Empty<uint>(), Array.Empty<ConstantOffsets>()), BlockEncoderOptions.None);
			Assert.Null(errorMessage);
			Assert.Empty(codeWriter.ToArray());

			errorMessage = BlockEncoder.Encode(64, new InstructionBlock(codeWriter, Array.Empty<Instruction>(), 0, Array.Empty<RelocInfo>(), Array.Empty<uint>(), Array.Empty<ConstantOffsets>()), BlockEncoderOptions.None);
			Assert.Null(errorMessage);
			Assert.Empty(codeWriter.ToArray());
		}

		[Fact]
		void Invalid_NewInstructionOffsets_Throws() {
			Assert.Throws<ArgumentException>(() => BlockEncoder.Encode(64, new InstructionBlock(new CodeWriterImpl(), new Instruction[0], 0, Array.Empty<RelocInfo>(), new uint[1], null), BlockEncoderOptions.None));
			Assert.Throws<ArgumentException>(() => BlockEncoder.Encode(64, new InstructionBlock(new CodeWriterImpl(), new Instruction[1], 0, Array.Empty<RelocInfo>(), new uint[0], null), BlockEncoderOptions.None));
		}

		[Fact]
		void Invalid_ConstantOffsets_Throws() {
			Assert.Throws<ArgumentException>(() => BlockEncoder.Encode(64, new InstructionBlock(new CodeWriterImpl(), new Instruction[0], 0, Array.Empty<RelocInfo>(), null, new ConstantOffsets[1]), BlockEncoderOptions.None));
			Assert.Throws<ArgumentException>(() => BlockEncoder.Encode(64, new InstructionBlock(new CodeWriterImpl(), new Instruction[1], 0, Array.Empty<RelocInfo>(), null, new ConstantOffsets[0]), BlockEncoderOptions.None));
		}

		[Fact]
		void DefaultArgs() {
			const int bitness = 64;
			const ulong origRip = 0x123456789ABCDE00;
			const ulong newRip = 0x8000000000000000;

			var originalData = new byte[] {
				/*0000*/ 0xB0, 0x00,// mov al,0
				/*0002*/ 0xEB, 0x09,// jmp short 123456789ABCDE0Dh
				/*0004*/ 0xB0, 0x01,// mov al,1
				/*0006*/ 0xE9, 0x03, 0x00, 0x00, 0x00,// jmp near ptr 123456789ABCDE0Eh
				/*000B*/ 0xB0, 0x02,// mov al,2
			};
			var instructions = BlockEncoderTest.Decode(bitness, origRip, originalData, DecoderOptions.None);
			var codeWriter = new CodeWriterImpl();
			var errorMessage = BlockEncoder.Encode(bitness, new InstructionBlock(codeWriter, instructions, newRip));
			Assert.Null(errorMessage);
			Assert.Equal(0x28, codeWriter.ToArray().Length);
		}
	}
}
#endif
