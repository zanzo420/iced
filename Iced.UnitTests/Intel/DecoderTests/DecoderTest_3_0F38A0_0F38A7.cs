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

using System.Collections.Generic;
using Iced.Intel;
using Xunit;

namespace Iced.UnitTests.Intel.DecoderTests {
	public sealed class DecoderTest_3_0F38A0_0F38A7 : DecoderTest {
		[Theory]
		[MemberData(nameof(Test16_VpscatterddV_RegMem_Reg_EVEX_1_Data))]
		void Test16_VpscatterddV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test16_VpscatterddV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "67 62 F27D0B A0 54 A1 01", 9, Code.EVEX_Vpscatterdd_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.XMM4, 4, false };

				yield return new object[] { "67 62 F27D2B A0 54 A1 01", 9, Code.EVEX_Vpscatterdd_vm32y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.YMM4, 4, false };

				yield return new object[] { "67 62 F27D4B A0 54 A1 01", 9, Code.EVEX_Vpscatterdd_vm32z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.ZMM4, 4, false };

				yield return new object[] { "67 62 F2FD0B A0 54 A1 01", 9, Code.EVEX_Vpscatterdq_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "67 62 F2FD2B A0 54 A1 01", 9, Code.EVEX_Vpscatterdq_vm32x_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "67 62 F2FD4B A0 54 A1 01", 9, Code.EVEX_Vpscatterdq_vm32y_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.YMM4, 8, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_VpscatterddV_RegMem_Reg_EVEX_1_Data))]
		void Test32_VpscatterddV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test32_VpscatterddV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A0 54 A1 01", 8, Code.EVEX_Vpscatterdd_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.XMM4, 4, false };

				yield return new object[] { "62 F27D2B A0 54 A1 01", 8, Code.EVEX_Vpscatterdd_vm32y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.YMM4, 4, false };

				yield return new object[] { "62 F27D4B A0 54 A1 01", 8, Code.EVEX_Vpscatterdd_vm32z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.ZMM4, 4, false };

				yield return new object[] { "62 F2FD0B A0 54 A1 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "62 F2FD2B A0 54 A1 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "62 F2FD4B A0 54 A1 01", 8, Code.EVEX_Vpscatterdq_vm32y_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.YMM4, 8, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_VpscatterddV_RegMem_Reg_EVEX_1_Data))]
		void Test64_VpscatterddV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test64_VpscatterddV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A0 54 A1 01", 8, Code.EVEX_Vpscatterdd_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.RCX, Register.XMM4, 4, false };
				yield return new object[] { "62 A27D03 A0 5C A9 01", 8, Code.EVEX_Vpscatterdd_vm32x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Int32, Register.RCX, Register.XMM29, 4, false };
				yield return new object[] { "62 427D03 A0 5C 8F 01", 8, Code.EVEX_Vpscatterdd_vm32x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Int32, Register.R15, Register.XMM17, 4, false };

				yield return new object[] { "62 F27D2B A0 54 A1 01", 8, Code.EVEX_Vpscatterdd_vm32y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int32, Register.RCX, Register.YMM4, 4, false };
				yield return new object[] { "62 A27D23 A0 5C A9 01", 8, Code.EVEX_Vpscatterdd_vm32y_k1_ymm, Register.YMM19, Register.K3, MemorySize.Int32, Register.RCX, Register.YMM29, 4, false };
				yield return new object[] { "62 427D23 A0 5C 8F 01", 8, Code.EVEX_Vpscatterdd_vm32y_k1_ymm, Register.YMM27, Register.K3, MemorySize.Int32, Register.R15, Register.YMM17, 4, false };

				yield return new object[] { "62 F27D4B A0 54 A1 01", 8, Code.EVEX_Vpscatterdd_vm32z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int32, Register.RCX, Register.ZMM4, 4, false };
				yield return new object[] { "62 A27D43 A0 5C A9 01", 8, Code.EVEX_Vpscatterdd_vm32z_k1_zmm, Register.ZMM19, Register.K3, MemorySize.Int32, Register.RCX, Register.ZMM29, 4, false };
				yield return new object[] { "62 427D43 A0 5C 8F 01", 8, Code.EVEX_Vpscatterdd_vm32z_k1_zmm, Register.ZMM27, Register.K3, MemorySize.Int32, Register.R15, Register.ZMM17, 4, false };

				yield return new object[] { "62 F2FD0B A0 54 A1 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int64, Register.RCX, Register.XMM4, 8, false };
				yield return new object[] { "62 A2FD03 A0 5C A9 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Int64, Register.RCX, Register.XMM29, 8, false };
				yield return new object[] { "62 42FD03 A0 5C 8F 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Int64, Register.R15, Register.XMM17, 8, false };

				yield return new object[] { "62 F2FD2B A0 54 A1 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int64, Register.RCX, Register.XMM4, 8, false };
				yield return new object[] { "62 A2FD23 A0 5C A9 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_ymm, Register.YMM19, Register.K3, MemorySize.Int64, Register.RCX, Register.XMM29, 8, false };
				yield return new object[] { "62 42FD23 A0 5C 8F 01", 8, Code.EVEX_Vpscatterdq_vm32x_k1_ymm, Register.YMM27, Register.K3, MemorySize.Int64, Register.R15, Register.XMM17, 8, false };

				yield return new object[] { "62 F2FD4B A0 54 A1 01", 8, Code.EVEX_Vpscatterdq_vm32y_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int64, Register.RCX, Register.YMM4, 8, false };
				yield return new object[] { "62 A2FD43 A0 5C A9 01", 8, Code.EVEX_Vpscatterdq_vm32y_k1_zmm, Register.ZMM19, Register.K3, MemorySize.Int64, Register.RCX, Register.YMM29, 8, false };
				yield return new object[] { "62 42FD43 A0 5C 8F 01", 8, Code.EVEX_Vpscatterdq_vm32y_k1_zmm, Register.ZMM27, Register.K3, MemorySize.Int64, Register.R15, Register.YMM17, 8, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_VpscatterqdV_RegMem_Reg_EVEX_1_Data))]
		void Test16_VpscatterqdV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test16_VpscatterqdV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "67 62 F27D0B A1 54 A1 01", 9, Code.EVEX_Vpscatterqd_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.XMM4, 4, true };

				yield return new object[] { "67 62 F27D2B A1 54 A1 01", 9, Code.EVEX_Vpscatterqd_vm64y_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.YMM4, 4, true };

				yield return new object[] { "67 62 F27D4B A1 54 A1 01", 9, Code.EVEX_Vpscatterqd_vm64z_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.ZMM4, 4, true };

				yield return new object[] { "67 62 F2FD0B A1 54 A1 01", 9, Code.EVEX_Vpscatterqq_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.XMM4, 8, true };

				yield return new object[] { "67 62 F2FD2B A1 54 A1 01", 9, Code.EVEX_Vpscatterqq_vm64y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.YMM4, 8, true };

				yield return new object[] { "67 62 F2FD4B A1 54 A1 01", 9, Code.EVEX_Vpscatterqq_vm64z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.ZMM4, 8, true };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_VpscatterqdV_RegMem_Reg_EVEX_1_Data))]
		void Test32_VpscatterqdV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test32_VpscatterqdV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A1 54 A1 01", 8, Code.EVEX_Vpscatterqd_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.XMM4, 4, true };

				yield return new object[] { "62 F27D2B A1 54 A1 01", 8, Code.EVEX_Vpscatterqd_vm64y_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.YMM4, 4, true };

				yield return new object[] { "62 F27D4B A1 54 A1 01", 8, Code.EVEX_Vpscatterqd_vm64z_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int32, Register.ECX, Register.ZMM4, 4, true };

				yield return new object[] { "62 F2FD0B A1 54 A1 01", 8, Code.EVEX_Vpscatterqq_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.XMM4, 8, true };

				yield return new object[] { "62 F2FD2B A1 54 A1 01", 8, Code.EVEX_Vpscatterqq_vm64y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.YMM4, 8, true };

				yield return new object[] { "62 F2FD4B A1 54 A1 01", 8, Code.EVEX_Vpscatterqq_vm64z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int64, Register.ECX, Register.ZMM4, 8, true };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_VpscatterqdV_RegMem_Reg_EVEX_1_Data))]
		void Test64_VpscatterqdV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test64_VpscatterqdV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A1 54 A1 01", 8, Code.EVEX_Vpscatterqd_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.RCX, Register.XMM4, 4, true };
				yield return new object[] { "62 A27D03 A1 5C A9 01", 8, Code.EVEX_Vpscatterqd_vm64x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Int32, Register.RCX, Register.XMM29, 4, true };
				yield return new object[] { "62 427D03 A1 5C 8F 01", 8, Code.EVEX_Vpscatterqd_vm64x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Int32, Register.R15, Register.XMM17, 4, true };

				yield return new object[] { "62 F27D2B A1 54 A1 01", 8, Code.EVEX_Vpscatterqd_vm64y_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int32, Register.RCX, Register.YMM4, 4, true };
				yield return new object[] { "62 A27D23 A1 5C A9 01", 8, Code.EVEX_Vpscatterqd_vm64y_k1_xmm, Register.XMM19, Register.K3, MemorySize.Int32, Register.RCX, Register.YMM29, 4, true };
				yield return new object[] { "62 427D23 A1 5C 8F 01", 8, Code.EVEX_Vpscatterqd_vm64y_k1_xmm, Register.XMM27, Register.K3, MemorySize.Int32, Register.R15, Register.YMM17, 4, true };

				yield return new object[] { "62 F27D4B A1 54 A1 01", 8, Code.EVEX_Vpscatterqd_vm64z_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int32, Register.RCX, Register.ZMM4, 4, true };
				yield return new object[] { "62 A27D43 A1 5C A9 01", 8, Code.EVEX_Vpscatterqd_vm64z_k1_ymm, Register.YMM19, Register.K3, MemorySize.Int32, Register.RCX, Register.ZMM29, 4, true };
				yield return new object[] { "62 427D43 A1 5C 8F 01", 8, Code.EVEX_Vpscatterqd_vm64z_k1_ymm, Register.YMM27, Register.K3, MemorySize.Int32, Register.R15, Register.ZMM17, 4, true };

				yield return new object[] { "62 F2FD0B A1 54 A1 01", 8, Code.EVEX_Vpscatterqq_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Int64, Register.RCX, Register.XMM4, 8, true };
				yield return new object[] { "62 A2FD03 A1 5C A9 01", 8, Code.EVEX_Vpscatterqq_vm64x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Int64, Register.RCX, Register.XMM29, 8, true };
				yield return new object[] { "62 42FD03 A1 5C 8F 01", 8, Code.EVEX_Vpscatterqq_vm64x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Int64, Register.R15, Register.XMM17, 8, true };

				yield return new object[] { "62 F2FD2B A1 54 A1 01", 8, Code.EVEX_Vpscatterqq_vm64y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Int64, Register.RCX, Register.YMM4, 8, true };
				yield return new object[] { "62 A2FD23 A1 5C A9 01", 8, Code.EVEX_Vpscatterqq_vm64y_k1_ymm, Register.YMM19, Register.K3, MemorySize.Int64, Register.RCX, Register.YMM29, 8, true };
				yield return new object[] { "62 42FD23 A1 5C 8F 01", 8, Code.EVEX_Vpscatterqq_vm64y_k1_ymm, Register.YMM27, Register.K3, MemorySize.Int64, Register.R15, Register.YMM17, 8, true };

				yield return new object[] { "62 F2FD4B A1 54 A1 01", 8, Code.EVEX_Vpscatterqq_vm64z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Int64, Register.RCX, Register.ZMM4, 8, true };
				yield return new object[] { "62 A2FD43 A1 5C A9 01", 8, Code.EVEX_Vpscatterqq_vm64z_k1_zmm, Register.ZMM19, Register.K3, MemorySize.Int64, Register.RCX, Register.ZMM29, 8, true };
				yield return new object[] { "62 42FD43 A1 5C 8F 01", 8, Code.EVEX_Vpscatterqq_vm64z_k1_zmm, Register.ZMM27, Register.K3, MemorySize.Int64, Register.R15, Register.ZMM17, 8, true };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_VscatterdpsV_RegMem_Reg_EVEX_1_Data))]
		void Test16_VscatterdpsV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test16_VscatterdpsV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "67 62 F27D0B A2 54 A1 01", 9, Code.EVEX_Vscatterdps_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.XMM4, 4, false };

				yield return new object[] { "67 62 F27D2B A2 54 A1 01", 9, Code.EVEX_Vscatterdps_vm32y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.YMM4, 4, false };

				yield return new object[] { "67 62 F27D4B A2 54 A1 01", 9, Code.EVEX_Vscatterdps_vm32z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.ZMM4, 4, false };

				yield return new object[] { "67 62 F2FD0B A2 54 A1 01", 9, Code.EVEX_Vscatterdpd_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "67 62 F2FD2B A2 54 A1 01", 9, Code.EVEX_Vscatterdpd_vm32x_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "67 62 F2FD4B A2 54 A1 01", 9, Code.EVEX_Vscatterdpd_vm32y_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.YMM4, 8, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_VscatterdpsV_RegMem_Reg_EVEX_1_Data))]
		void Test32_VscatterdpsV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test32_VscatterdpsV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A2 54 A1 01", 8, Code.EVEX_Vscatterdps_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.XMM4, 4, false };

				yield return new object[] { "62 F27D2B A2 54 A1 01", 8, Code.EVEX_Vscatterdps_vm32y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.YMM4, 4, false };

				yield return new object[] { "62 F27D4B A2 54 A1 01", 8, Code.EVEX_Vscatterdps_vm32z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.ZMM4, 4, false };

				yield return new object[] { "62 F2FD0B A2 54 A1 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "62 F2FD2B A2 54 A1 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.XMM4, 8, false };

				yield return new object[] { "62 F2FD4B A2 54 A1 01", 8, Code.EVEX_Vscatterdpd_vm32y_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.YMM4, 8, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_VscatterdpsV_RegMem_Reg_EVEX_1_Data))]
		void Test64_VscatterdpsV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test64_VscatterdpsV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A2 54 A1 01", 8, Code.EVEX_Vscatterdps_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.RCX, Register.XMM4, 4, false };
				yield return new object[] { "62 A27D03 A2 5C A9 01", 8, Code.EVEX_Vscatterdps_vm32x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Float32, Register.RCX, Register.XMM29, 4, false };
				yield return new object[] { "62 427D03 A2 5C 8F 01", 8, Code.EVEX_Vscatterdps_vm32x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Float32, Register.R15, Register.XMM17, 4, false };

				yield return new object[] { "62 F27D2B A2 54 A1 01", 8, Code.EVEX_Vscatterdps_vm32y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float32, Register.RCX, Register.YMM4, 4, false };
				yield return new object[] { "62 A27D23 A2 5C A9 01", 8, Code.EVEX_Vscatterdps_vm32y_k1_ymm, Register.YMM19, Register.K3, MemorySize.Float32, Register.RCX, Register.YMM29, 4, false };
				yield return new object[] { "62 427D23 A2 5C 8F 01", 8, Code.EVEX_Vscatterdps_vm32y_k1_ymm, Register.YMM27, Register.K3, MemorySize.Float32, Register.R15, Register.YMM17, 4, false };

				yield return new object[] { "62 F27D4B A2 54 A1 01", 8, Code.EVEX_Vscatterdps_vm32z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float32, Register.RCX, Register.ZMM4, 4, false };
				yield return new object[] { "62 A27D43 A2 5C A9 01", 8, Code.EVEX_Vscatterdps_vm32z_k1_zmm, Register.ZMM19, Register.K3, MemorySize.Float32, Register.RCX, Register.ZMM29, 4, false };
				yield return new object[] { "62 427D43 A2 5C 8F 01", 8, Code.EVEX_Vscatterdps_vm32z_k1_zmm, Register.ZMM27, Register.K3, MemorySize.Float32, Register.R15, Register.ZMM17, 4, false };

				yield return new object[] { "62 F2FD0B A2 54 A1 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float64, Register.RCX, Register.XMM4, 8, false };
				yield return new object[] { "62 A2FD03 A2 5C A9 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Float64, Register.RCX, Register.XMM29, 8, false };
				yield return new object[] { "62 42FD03 A2 5C 8F 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Float64, Register.R15, Register.XMM17, 8, false };

				yield return new object[] { "62 F2FD2B A2 54 A1 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float64, Register.RCX, Register.XMM4, 8, false };
				yield return new object[] { "62 A2FD23 A2 5C A9 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_ymm, Register.YMM19, Register.K3, MemorySize.Float64, Register.RCX, Register.XMM29, 8, false };
				yield return new object[] { "62 42FD23 A2 5C 8F 01", 8, Code.EVEX_Vscatterdpd_vm32x_k1_ymm, Register.YMM27, Register.K3, MemorySize.Float64, Register.R15, Register.XMM17, 8, false };

				yield return new object[] { "62 F2FD4B A2 54 A1 01", 8, Code.EVEX_Vscatterdpd_vm32y_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float64, Register.RCX, Register.YMM4, 8, false };
				yield return new object[] { "62 A2FD43 A2 5C A9 01", 8, Code.EVEX_Vscatterdpd_vm32y_k1_zmm, Register.ZMM19, Register.K3, MemorySize.Float64, Register.RCX, Register.YMM29, 8, false };
				yield return new object[] { "62 42FD43 A2 5C 8F 01", 8, Code.EVEX_Vscatterdpd_vm32y_k1_zmm, Register.ZMM27, Register.K3, MemorySize.Float64, Register.R15, Register.YMM17, 8, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_VscatterqpsV_RegMem_Reg_EVEX_1_Data))]
		void Test16_VscatterqpsV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test16_VscatterqpsV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "67 62 F27D0B A3 54 A1 01", 9, Code.EVEX_Vscatterqps_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.XMM4, 4, true };

				yield return new object[] { "67 62 F27D2B A3 54 A1 01", 9, Code.EVEX_Vscatterqps_vm64y_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.YMM4, 4, true };

				yield return new object[] { "67 62 F27D4B A3 54 A1 01", 9, Code.EVEX_Vscatterqps_vm64z_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.ZMM4, 4, true };

				yield return new object[] { "67 62 F2FD0B A3 54 A1 01", 9, Code.EVEX_Vscatterqpd_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.XMM4, 8, true };

				yield return new object[] { "67 62 F2FD2B A3 54 A1 01", 9, Code.EVEX_Vscatterqpd_vm64y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.YMM4, 8, true };

				yield return new object[] { "67 62 F2FD4B A3 54 A1 01", 9, Code.EVEX_Vscatterqpd_vm64z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.ZMM4, 8, true };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_VscatterqpsV_RegMem_Reg_EVEX_1_Data))]
		void Test32_VscatterqpsV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test32_VscatterqpsV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A3 54 A1 01", 8, Code.EVEX_Vscatterqps_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.XMM4, 4, true };

				yield return new object[] { "62 F27D2B A3 54 A1 01", 8, Code.EVEX_Vscatterqps_vm64y_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.YMM4, 4, true };

				yield return new object[] { "62 F27D4B A3 54 A1 01", 8, Code.EVEX_Vscatterqps_vm64z_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float32, Register.ECX, Register.ZMM4, 4, true };

				yield return new object[] { "62 F2FD0B A3 54 A1 01", 8, Code.EVEX_Vscatterqpd_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.XMM4, 8, true };

				yield return new object[] { "62 F2FD2B A3 54 A1 01", 8, Code.EVEX_Vscatterqpd_vm64y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.YMM4, 8, true };

				yield return new object[] { "62 F2FD4B A3 54 A1 01", 8, Code.EVEX_Vscatterqpd_vm64z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float64, Register.ECX, Register.ZMM4, 8, true };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_VscatterqpsV_RegMem_Reg_EVEX_1_Data))]
		void Test64_VscatterqpsV_RegMem_Reg_EVEX_1(string hexBytes, int byteLength, Code code, Register reg1, Register kreg, MemorySize memSize, Register memBase, Register memIndex, uint displ, bool isVsib64) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(2, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Memory, instr.Op0Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(memBase, instr.MemoryBase);
			Assert.Equal(memIndex, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(4, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg1, instr.Op1Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.False(instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);

			Assert.True(instr.IsVsib);
			Assert.Equal(!isVsib64, instr.IsVsib32);
			Assert.Equal(isVsib64, instr.IsVsib64);
			Assert.True(instr.TryGetVsib64(out var vsib64) && vsib64 == isVsib64);
		}
		public static IEnumerable<object[]> Test64_VscatterqpsV_RegMem_Reg_EVEX_1_Data {
			get {
				yield return new object[] { "62 F27D0B A3 54 A1 01", 8, Code.EVEX_Vscatterqps_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.RCX, Register.XMM4, 4, true };
				yield return new object[] { "62 A27D03 A3 5C A9 01", 8, Code.EVEX_Vscatterqps_vm64x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Float32, Register.RCX, Register.XMM29, 4, true };
				yield return new object[] { "62 427D03 A3 5C 8F 01", 8, Code.EVEX_Vscatterqps_vm64x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Float32, Register.R15, Register.XMM17, 4, true };

				yield return new object[] { "62 F27D2B A3 54 A1 01", 8, Code.EVEX_Vscatterqps_vm64y_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float32, Register.RCX, Register.YMM4, 4, true };
				yield return new object[] { "62 A27D23 A3 5C A9 01", 8, Code.EVEX_Vscatterqps_vm64y_k1_xmm, Register.XMM19, Register.K3, MemorySize.Float32, Register.RCX, Register.YMM29, 4, true };
				yield return new object[] { "62 427D23 A3 5C 8F 01", 8, Code.EVEX_Vscatterqps_vm64y_k1_xmm, Register.XMM27, Register.K3, MemorySize.Float32, Register.R15, Register.YMM17, 4, true };

				yield return new object[] { "62 F27D4B A3 54 A1 01", 8, Code.EVEX_Vscatterqps_vm64z_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float32, Register.RCX, Register.ZMM4, 4, true };
				yield return new object[] { "62 A27D43 A3 5C A9 01", 8, Code.EVEX_Vscatterqps_vm64z_k1_ymm, Register.YMM19, Register.K3, MemorySize.Float32, Register.RCX, Register.ZMM29, 4, true };
				yield return new object[] { "62 427D43 A3 5C 8F 01", 8, Code.EVEX_Vscatterqps_vm64z_k1_ymm, Register.YMM27, Register.K3, MemorySize.Float32, Register.R15, Register.ZMM17, 4, true };

				yield return new object[] { "62 F2FD0B A3 54 A1 01", 8, Code.EVEX_Vscatterqpd_vm64x_k1_xmm, Register.XMM2, Register.K3, MemorySize.Float64, Register.RCX, Register.XMM4, 8, true };
				yield return new object[] { "62 A2FD03 A3 5C A9 01", 8, Code.EVEX_Vscatterqpd_vm64x_k1_xmm, Register.XMM19, Register.K3, MemorySize.Float64, Register.RCX, Register.XMM29, 8, true };
				yield return new object[] { "62 42FD03 A3 5C 8F 01", 8, Code.EVEX_Vscatterqpd_vm64x_k1_xmm, Register.XMM27, Register.K3, MemorySize.Float64, Register.R15, Register.XMM17, 8, true };

				yield return new object[] { "62 F2FD2B A3 54 A1 01", 8, Code.EVEX_Vscatterqpd_vm64y_k1_ymm, Register.YMM2, Register.K3, MemorySize.Float64, Register.RCX, Register.YMM4, 8, true };
				yield return new object[] { "62 A2FD23 A3 5C A9 01", 8, Code.EVEX_Vscatterqpd_vm64y_k1_ymm, Register.YMM19, Register.K3, MemorySize.Float64, Register.RCX, Register.YMM29, 8, true };
				yield return new object[] { "62 42FD23 A3 5C 8F 01", 8, Code.EVEX_Vscatterqpd_vm64y_k1_ymm, Register.YMM27, Register.K3, MemorySize.Float64, Register.R15, Register.YMM17, 8, true };

				yield return new object[] { "62 F2FD4B A3 54 A1 01", 8, Code.EVEX_Vscatterqpd_vm64z_k1_zmm, Register.ZMM2, Register.K3, MemorySize.Float64, Register.RCX, Register.ZMM4, 8, true };
				yield return new object[] { "62 A2FD43 A3 5C A9 01", 8, Code.EVEX_Vscatterqpd_vm64z_k1_zmm, Register.ZMM19, Register.K3, MemorySize.Float64, Register.RCX, Register.ZMM29, 8, true };
				yield return new object[] { "62 42FD43 A3 5C 8F 01", 8, Code.EVEX_Vscatterqpd_vm64z_k1_zmm, Register.ZMM27, Register.K3, MemorySize.Float64, Register.R15, Register.ZMM17, 8, true };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmaddsub213psV_VX_HX_WX_1_Data))]
		void Test16_Vfmaddsub213psV_VX_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, MemorySize memSize) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.BX, instr.MemoryBase);
			Assert.Equal(Register.SI, instr.MemoryIndex);
			Assert.Equal(0U, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(0, instr.MemoryDisplSize);
		}
		public static IEnumerable<object[]> Test16_Vfmaddsub213psV_VX_HX_WX_1_Data {
			get {
				yield return new object[] { "C4E249 A6 10", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float32 };

				yield return new object[] { "C4E24D A6 10", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float32 };

				yield return new object[] { "C4E2C9 A6 10", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float64 };

				yield return new object[] { "C4E2CD A6 10", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float64 };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmaddsub213psV_VX_HX_WX_2_Data))]
		void Test16_Vfmaddsub213psV_VX_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);
		}
		public static IEnumerable<object[]> Test16_Vfmaddsub213psV_VX_HX_WX_2_Data {
			get {
				yield return new object[] { "C4E249 A6 D3", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E24D A6 D3", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };

				yield return new object[] { "C4E2C9 A6 D3", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E2CD A6 D3", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmaddsub213psV_VX_HX_WX_1_Data))]
		void Test32_Vfmaddsub213psV_VX_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, MemorySize memSize) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.EAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(0U, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(0, instr.MemoryDisplSize);
		}
		public static IEnumerable<object[]> Test32_Vfmaddsub213psV_VX_HX_WX_1_Data {
			get {
				yield return new object[] { "C4E249 A6 10", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float32 };

				yield return new object[] { "C4E24D A6 10", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float32 };

				yield return new object[] { "C4E2C9 A6 10", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float64 };

				yield return new object[] { "C4E2CD A6 10", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float64 };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmaddsub213psV_VX_HX_WX_2_Data))]
		void Test32_Vfmaddsub213psV_VX_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);
		}
		public static IEnumerable<object[]> Test32_Vfmaddsub213psV_VX_HX_WX_2_Data {
			get {
				yield return new object[] { "C4E249 A6 D3", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E24D A6 D3", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };

				yield return new object[] { "C4E2C9 A6 D3", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E2CD A6 D3", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmaddsub213psV_VX_HX_WX_1_Data))]
		void Test64_Vfmaddsub213psV_VX_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, MemorySize memSize) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.RAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(0U, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(0, instr.MemoryDisplSize);
		}
		public static IEnumerable<object[]> Test64_Vfmaddsub213psV_VX_HX_WX_1_Data {
			get {
				yield return new object[] { "C4E249 A6 10", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float32 };

				yield return new object[] { "C4E24D A6 10", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float32 };

				yield return new object[] { "C4E2C9 A6 10", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float64 };

				yield return new object[] { "C4E2CD A6 10", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float64 };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmaddsub213psV_VX_HX_WX_2_Data))]
		void Test64_Vfmaddsub213psV_VX_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);
		}
		public static IEnumerable<object[]> Test64_Vfmaddsub213psV_VX_HX_WX_2_Data {
			get {
				yield return new object[] { "C4E249 A6 D3", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C46249 A6 D3", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM10, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C4E209 A6 D3", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM14, Register.XMM3 };
				yield return new object[] { "C4C249 A6 D3", 5, Code.VEX_Vfmaddsub213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM11 };

				yield return new object[] { "C4E24D A6 D3", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C4624D A6 D3", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM10, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C4E20D A6 D3", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM14, Register.YMM3 };
				yield return new object[] { "C4C24D A6 D3", 5, Code.VEX_Vfmaddsub213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM11 };

				yield return new object[] { "C4E2C9 A6 D3", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C462C9 A6 D3", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM10, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C4E289 A6 D3", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM14, Register.XMM3 };
				yield return new object[] { "C4C2C9 A6 D3", 5, Code.VEX_Vfmaddsub213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM11 };

				yield return new object[] { "C4E2CD A6 D3", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C462CD A6 D3", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM10, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C4E28D A6 D3", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM14, Register.YMM3 };
				yield return new object[] { "C4C2CD A6 D3", 5, Code.VEX_Vfmaddsub213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM11 };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmaddsub213psV_VX_k1_HX_WX_1_Data))]
		void Test16_Vfmaddsub213psV_VX_k1_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register kreg, MemorySize memSize, uint displ, bool z) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.BX, instr.MemoryBase);
			Assert.Equal(Register.SI, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test16_Vfmaddsub213psV_VX_k1_HX_WX_1_Data {
			get {
				yield return new object[] { "62 F24D0B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float32, 16, false };
				yield return new object[] { "62 F24D9D A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float32, 4, true };
				yield return new object[] { "62 F24D08 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float32, 16, false };

				yield return new object[] { "62 F24D2B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float32, 32, false };
				yield return new object[] { "62 F24DBD A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float32, 4, true };
				yield return new object[] { "62 F24D28 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float32, 32, false };

				yield return new object[] { "62 F24D4B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float32, 64, false };
				yield return new object[] { "62 F24DDD A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float32, 4, true };
				yield return new object[] { "62 F24D48 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float32, 64, false };

				yield return new object[] { "62 F2CD0B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float64, 16, false };
				yield return new object[] { "62 F2CD9D A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float64, 8, true };
				yield return new object[] { "62 F2CD08 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float64, 16, false };

				yield return new object[] { "62 F2CD2B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float64, 32, false };
				yield return new object[] { "62 F2CDBD A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float64, 8, true };
				yield return new object[] { "62 F2CD28 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float64, 32, false };

				yield return new object[] { "62 F2CD4B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float64, 64, false };
				yield return new object[] { "62 F2CDDD A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float64, 8, true };
				yield return new object[] { "62 F2CD48 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float64, 64, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmaddsub213psV_VX_k1_HX_WX_2_Data))]
		void Test16_Vfmaddsub213psV_VX_k1_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3, Register kreg, RoundingControl rc, bool z) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(rc, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test16_Vfmaddsub213psV_VX_k1_HX_WX_2_Data {
			get {
				yield return new object[] { "62 F24D8B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24DDB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F24DAB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D1B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F24DCB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D7B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };

				yield return new object[] { "62 F2CD8B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CDDB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F2CDAB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD1B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F2CDCB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD7B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmaddsub213psV_VX_k1_HX_WX_1_Data))]
		void Test32_Vfmaddsub213psV_VX_k1_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register kreg, MemorySize memSize, uint displ, bool z) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.EAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test32_Vfmaddsub213psV_VX_k1_HX_WX_1_Data {
			get {
				yield return new object[] { "62 F24D0B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float32, 16, false };
				yield return new object[] { "62 F24D9D A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float32, 4, true };
				yield return new object[] { "62 F24D08 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float32, 16, false };

				yield return new object[] { "62 F24D2B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float32, 32, false };
				yield return new object[] { "62 F24DBD A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float32, 4, true };
				yield return new object[] { "62 F24D28 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float32, 32, false };

				yield return new object[] { "62 F24D4B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float32, 64, false };
				yield return new object[] { "62 F24DDD A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float32, 4, true };
				yield return new object[] { "62 F24D48 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float32, 64, false };

				yield return new object[] { "62 F2CD0B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float64, 16, false };
				yield return new object[] { "62 F2CD9D A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float64, 8, true };
				yield return new object[] { "62 F2CD08 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float64, 16, false };

				yield return new object[] { "62 F2CD2B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float64, 32, false };
				yield return new object[] { "62 F2CDBD A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float64, 8, true };
				yield return new object[] { "62 F2CD28 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float64, 32, false };

				yield return new object[] { "62 F2CD4B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float64, 64, false };
				yield return new object[] { "62 F2CDDD A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float64, 8, true };
				yield return new object[] { "62 F2CD48 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float64, 64, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmaddsub213psV_VX_k1_HX_WX_2_Data))]
		void Test32_Vfmaddsub213psV_VX_k1_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3, Register kreg, RoundingControl rc, bool z) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(rc, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test32_Vfmaddsub213psV_VX_k1_HX_WX_2_Data {
			get {
				yield return new object[] { "62 F24D8B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24DDB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F24DAB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D1B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F24DCB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D7B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };

				yield return new object[] { "62 F2CD8B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CDDB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F2CDAB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD1B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F2CDCB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD7B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmaddsub213psV_VX_k1_HX_WX_1_Data))]
		void Test64_Vfmaddsub213psV_VX_k1_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register kreg, MemorySize memSize, uint displ, bool z) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.RAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test64_Vfmaddsub213psV_VX_k1_HX_WX_1_Data {
			get {
				yield return new object[] { "62 F24D0B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float32, 16, false };
				yield return new object[] { "62 F24D9D A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float32, 4, true };
				yield return new object[] { "62 F24D08 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float32, 16, false };

				yield return new object[] { "62 F24D2B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float32, 32, false };
				yield return new object[] { "62 F24DBD A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float32, 4, true };
				yield return new object[] { "62 F24D28 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float32, 32, false };

				yield return new object[] { "62 F24D4B A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float32, 64, false };
				yield return new object[] { "62 F24DDD A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float32, 4, true };
				yield return new object[] { "62 F24D48 A6 50 01", 7, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float32, 64, false };

				yield return new object[] { "62 F2CD0B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float64, 16, false };
				yield return new object[] { "62 F2CD9D A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float64, 8, true };
				yield return new object[] { "62 F2CD08 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float64, 16, false };

				yield return new object[] { "62 F2CD2B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float64, 32, false };
				yield return new object[] { "62 F2CDBD A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float64, 8, true };
				yield return new object[] { "62 F2CD28 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float64, 32, false };

				yield return new object[] { "62 F2CD4B A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float64, 64, false };
				yield return new object[] { "62 F2CDDD A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float64, 8, true };
				yield return new object[] { "62 F2CD48 A6 50 01", 7, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float64, 64, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmaddsub213psV_VX_k1_HX_WX_2_Data))]
		void Test64_Vfmaddsub213psV_VX_k1_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3, Register kreg, RoundingControl rc, bool z) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(rc, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test64_Vfmaddsub213psV_VX_k1_HX_WX_2_Data {
			get {
				yield return new object[] { "62 F24D8B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E20D0B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM18, Register.XMM14, Register.XMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 124D03 A6 D3", 6, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM10, Register.XMM22, Register.XMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B24D0B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F24DDB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F24DAB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E20D2B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM18, Register.YMM14, Register.YMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 124D23 A6 D3", 6, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM10, Register.YMM22, Register.YMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B24D2B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F24D1B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F24DCB A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E20D4B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM18, Register.ZMM14, Register.ZMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 124D43 A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM10, Register.ZMM22, Register.ZMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B24D4B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F24D7B A6 D3", 6, Code.EVEX_Vfmaddsub213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };

				yield return new object[] { "62 F2CD8B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E28D0B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM18, Register.XMM14, Register.XMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 12CD03 A6 D3", 6, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM10, Register.XMM22, Register.XMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B2CD0B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F2CDDB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F2CDAB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E28D2B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM18, Register.YMM14, Register.YMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 12CD23 A6 D3", 6, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM10, Register.YMM22, Register.YMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B2CD2B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F2CD1B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F2CDCB A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E28D4B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM18, Register.ZMM14, Register.ZMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 12CD43 A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM10, Register.ZMM22, Register.ZMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B2CD4B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F2CD7B A6 D3", 6, Code.EVEX_Vfmaddsub213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmsubadd213psV_VX_HX_WX_1_Data))]
		void Test16_Vfmsubadd213psV_VX_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, MemorySize memSize) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.BX, instr.MemoryBase);
			Assert.Equal(Register.SI, instr.MemoryIndex);
			Assert.Equal(0U, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(0, instr.MemoryDisplSize);
		}
		public static IEnumerable<object[]> Test16_Vfmsubadd213psV_VX_HX_WX_1_Data {
			get {
				yield return new object[] { "C4E249 A7 10", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float32 };

				yield return new object[] { "C4E24D A7 10", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float32 };

				yield return new object[] { "C4E2C9 A7 10", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float64 };

				yield return new object[] { "C4E2CD A7 10", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float64 };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmsubadd213psV_VX_HX_WX_2_Data))]
		void Test16_Vfmsubadd213psV_VX_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);
		}
		public static IEnumerable<object[]> Test16_Vfmsubadd213psV_VX_HX_WX_2_Data {
			get {
				yield return new object[] { "C4E249 A7 D3", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E24D A7 D3", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };

				yield return new object[] { "C4E2C9 A7 D3", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E2CD A7 D3", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmsubadd213psV_VX_HX_WX_1_Data))]
		void Test32_Vfmsubadd213psV_VX_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, MemorySize memSize) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.EAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(0U, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(0, instr.MemoryDisplSize);
		}
		public static IEnumerable<object[]> Test32_Vfmsubadd213psV_VX_HX_WX_1_Data {
			get {
				yield return new object[] { "C4E249 A7 10", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float32 };

				yield return new object[] { "C4E24D A7 10", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float32 };

				yield return new object[] { "C4E2C9 A7 10", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float64 };

				yield return new object[] { "C4E2CD A7 10", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float64 };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmsubadd213psV_VX_HX_WX_2_Data))]
		void Test32_Vfmsubadd213psV_VX_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);
		}
		public static IEnumerable<object[]> Test32_Vfmsubadd213psV_VX_HX_WX_2_Data {
			get {
				yield return new object[] { "C4E249 A7 D3", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E24D A7 D3", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };

				yield return new object[] { "C4E2C9 A7 D3", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };

				yield return new object[] { "C4E2CD A7 D3", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmsubadd213psV_VX_HX_WX_1_Data))]
		void Test64_Vfmsubadd213psV_VX_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, MemorySize memSize) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.RAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(0U, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(0, instr.MemoryDisplSize);
		}
		public static IEnumerable<object[]> Test64_Vfmsubadd213psV_VX_HX_WX_1_Data {
			get {
				yield return new object[] { "C4E249 A7 10", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float32 };

				yield return new object[] { "C4E24D A7 10", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float32 };

				yield return new object[] { "C4E2C9 A7 10", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, MemorySize.Packed128_Float64 };

				yield return new object[] { "C4E2CD A7 10", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, MemorySize.Packed256_Float64 };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmsubadd213psV_VX_HX_WX_2_Data))]
		void Test64_Vfmsubadd213psV_VX_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);
		}
		public static IEnumerable<object[]> Test64_Vfmsubadd213psV_VX_HX_WX_2_Data {
			get {
				yield return new object[] { "C4E249 A7 D3", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C46249 A7 D3", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM10, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C4E209 A7 D3", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM14, Register.XMM3 };
				yield return new object[] { "C4C249 A7 D3", 5, Code.VEX_Vfmsubadd213ps_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM11 };

				yield return new object[] { "C4E24D A7 D3", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C4624D A7 D3", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM10, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C4E20D A7 D3", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM14, Register.YMM3 };
				yield return new object[] { "C4C24D A7 D3", 5, Code.VEX_Vfmsubadd213ps_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM11 };

				yield return new object[] { "C4E2C9 A7 D3", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C462C9 A7 D3", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM10, Register.XMM6, Register.XMM3 };
				yield return new object[] { "C4E289 A7 D3", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM14, Register.XMM3 };
				yield return new object[] { "C4C2C9 A7 D3", 5, Code.VEX_Vfmsubadd213pd_xmm_xmm_xmmm128, Register.XMM2, Register.XMM6, Register.XMM11 };

				yield return new object[] { "C4E2CD A7 D3", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C462CD A7 D3", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM10, Register.YMM6, Register.YMM3 };
				yield return new object[] { "C4E28D A7 D3", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM14, Register.YMM3 };
				yield return new object[] { "C4C2CD A7 D3", 5, Code.VEX_Vfmsubadd213pd_ymm_ymm_ymmm256, Register.YMM2, Register.YMM6, Register.YMM11 };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmsubadd213psV_VX_k1_HX_WX_1_Data))]
		void Test16_Vfmsubadd213psV_VX_k1_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register kreg, MemorySize memSize, uint displ, bool z) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.BX, instr.MemoryBase);
			Assert.Equal(Register.SI, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test16_Vfmsubadd213psV_VX_k1_HX_WX_1_Data {
			get {
				yield return new object[] { "62 F24D0B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float32, 16, false };
				yield return new object[] { "62 F24D9D A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float32, 4, true };
				yield return new object[] { "62 F24D08 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float32, 16, false };

				yield return new object[] { "62 F24D2B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float32, 32, false };
				yield return new object[] { "62 F24DBD A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float32, 4, true };
				yield return new object[] { "62 F24D28 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float32, 32, false };

				yield return new object[] { "62 F24D4B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float32, 64, false };
				yield return new object[] { "62 F24DDD A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float32, 4, true };
				yield return new object[] { "62 F24D48 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float32, 64, false };

				yield return new object[] { "62 F2CD0B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float64, 16, false };
				yield return new object[] { "62 F2CD9D A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float64, 8, true };
				yield return new object[] { "62 F2CD08 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float64, 16, false };

				yield return new object[] { "62 F2CD2B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float64, 32, false };
				yield return new object[] { "62 F2CDBD A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float64, 8, true };
				yield return new object[] { "62 F2CD28 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float64, 32, false };

				yield return new object[] { "62 F2CD4B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float64, 64, false };
				yield return new object[] { "62 F2CDDD A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float64, 8, true };
				yield return new object[] { "62 F2CD48 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float64, 64, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test16_Vfmsubadd213psV_VX_k1_HX_WX_2_Data))]
		void Test16_Vfmsubadd213psV_VX_k1_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3, Register kreg, RoundingControl rc, bool z) {
			var decoder = CreateDecoder16(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(rc, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test16_Vfmsubadd213psV_VX_k1_HX_WX_2_Data {
			get {
				yield return new object[] { "62 F24D8B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24DDB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F24DAB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D1B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F24DCB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D7B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };

				yield return new object[] { "62 F2CD8B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CDDB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F2CDAB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD1B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F2CDCB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD7B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmsubadd213psV_VX_k1_HX_WX_1_Data))]
		void Test32_Vfmsubadd213psV_VX_k1_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register kreg, MemorySize memSize, uint displ, bool z) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.EAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test32_Vfmsubadd213psV_VX_k1_HX_WX_1_Data {
			get {
				yield return new object[] { "62 F24D0B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float32, 16, false };
				yield return new object[] { "62 F24D9D A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float32, 4, true };
				yield return new object[] { "62 F24D08 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float32, 16, false };

				yield return new object[] { "62 F24D2B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float32, 32, false };
				yield return new object[] { "62 F24DBD A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float32, 4, true };
				yield return new object[] { "62 F24D28 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float32, 32, false };

				yield return new object[] { "62 F24D4B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float32, 64, false };
				yield return new object[] { "62 F24DDD A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float32, 4, true };
				yield return new object[] { "62 F24D48 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float32, 64, false };

				yield return new object[] { "62 F2CD0B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float64, 16, false };
				yield return new object[] { "62 F2CD9D A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float64, 8, true };
				yield return new object[] { "62 F2CD08 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float64, 16, false };

				yield return new object[] { "62 F2CD2B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float64, 32, false };
				yield return new object[] { "62 F2CDBD A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float64, 8, true };
				yield return new object[] { "62 F2CD28 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float64, 32, false };

				yield return new object[] { "62 F2CD4B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float64, 64, false };
				yield return new object[] { "62 F2CDDD A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float64, 8, true };
				yield return new object[] { "62 F2CD48 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float64, 64, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test32_Vfmsubadd213psV_VX_k1_HX_WX_2_Data))]
		void Test32_Vfmsubadd213psV_VX_k1_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3, Register kreg, RoundingControl rc, bool z) {
			var decoder = CreateDecoder32(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(rc, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test32_Vfmsubadd213psV_VX_k1_HX_WX_2_Data {
			get {
				yield return new object[] { "62 F24D8B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24DDB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F24DAB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D1B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F24DCB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F24D7B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };

				yield return new object[] { "62 F2CD8B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CDDB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F2CDAB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD1B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F2CDCB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 F2CD7B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmsubadd213psV_VX_k1_HX_WX_1_Data))]
		void Test64_Vfmsubadd213psV_VX_k1_HX_WX_1(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register kreg, MemorySize memSize, uint displ, bool z) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Memory, instr.Op2Kind);
			Assert.Equal(Register.DS, instr.MemorySegment);
			Assert.Equal(Register.RAX, instr.MemoryBase);
			Assert.Equal(Register.None, instr.MemoryIndex);
			Assert.Equal(displ, instr.MemoryDisplacement);
			Assert.Equal(1, instr.MemoryIndexScale);
			Assert.Equal(memSize, instr.MemorySize);
			Assert.Equal(1, instr.MemoryDisplSize);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(RoundingControl.None, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test64_Vfmsubadd213psV_VX_k1_HX_WX_1_Data {
			get {
				yield return new object[] { "62 F24D0B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float32, 16, false };
				yield return new object[] { "62 F24D9D A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float32, 4, true };
				yield return new object[] { "62 F24D08 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float32, 16, false };

				yield return new object[] { "62 F24D2B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float32, 32, false };
				yield return new object[] { "62 F24DBD A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float32, 4, true };
				yield return new object[] { "62 F24D28 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float32, 32, false };

				yield return new object[] { "62 F24D4B A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float32, 64, false };
				yield return new object[] { "62 F24DDD A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float32, 4, true };
				yield return new object[] { "62 F24D48 A7 50 01", 7, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float32, 64, false };

				yield return new object[] { "62 F2CD0B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K3, MemorySize.Packed128_Float64, 16, false };
				yield return new object[] { "62 F2CD9D A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.K5, MemorySize.Broadcast128_Float64, 8, true };
				yield return new object[] { "62 F2CD08 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.None, MemorySize.Packed128_Float64, 16, false };

				yield return new object[] { "62 F2CD2B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K3, MemorySize.Packed256_Float64, 32, false };
				yield return new object[] { "62 F2CDBD A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.K5, MemorySize.Broadcast256_Float64, 8, true };
				yield return new object[] { "62 F2CD28 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.None, MemorySize.Packed256_Float64, 32, false };

				yield return new object[] { "62 F2CD4B A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K3, MemorySize.Packed512_Float64, 64, false };
				yield return new object[] { "62 F2CDDD A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.K5, MemorySize.Broadcast512_Float64, 8, true };
				yield return new object[] { "62 F2CD48 A7 50 01", 7, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.None, MemorySize.Packed512_Float64, 64, false };
			}
		}

		[Theory]
		[MemberData(nameof(Test64_Vfmsubadd213psV_VX_k1_HX_WX_2_Data))]
		void Test64_Vfmsubadd213psV_VX_k1_HX_WX_2(string hexBytes, int byteLength, Code code, Register reg1, Register reg2, Register reg3, Register kreg, RoundingControl rc, bool z) {
			var decoder = CreateDecoder64(hexBytes);
			var instr = decoder.Decode();

			Assert.Equal(code, instr.Code);
			Assert.Equal(3, instr.OpCount);
			Assert.Equal(byteLength, instr.ByteLength);
			Assert.False(instr.HasRepePrefix);
			Assert.False(instr.HasRepnePrefix);
			Assert.False(instr.HasLockPrefix);
			Assert.Equal(Register.None, instr.SegmentPrefix);

			Assert.Equal(OpKind.Register, instr.Op0Kind);
			Assert.Equal(reg1, instr.Op0Register);

			Assert.Equal(OpKind.Register, instr.Op1Kind);
			Assert.Equal(reg2, instr.Op1Register);

			Assert.Equal(OpKind.Register, instr.Op2Kind);
			Assert.Equal(reg3, instr.Op2Register);

			Assert.Equal(kreg, instr.OpMask);
			Assert.Equal(z, instr.ZeroingMasking);
			Assert.Equal(rc, instr.RoundingControl);
			Assert.False(instr.SuppressAllExceptions);
		}
		public static IEnumerable<object[]> Test64_Vfmsubadd213psV_VX_k1_HX_WX_2_Data {
			get {
				yield return new object[] { "62 F24D8B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E20D0B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM18, Register.XMM14, Register.XMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 124D03 A7 D3", 6, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM10, Register.XMM22, Register.XMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B24D0B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_xmm_k1z_xmm_xmmm128b32, Register.XMM2, Register.XMM6, Register.XMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F24DDB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F24DAB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E20D2B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM18, Register.YMM14, Register.YMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 124D23 A7 D3", 6, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM10, Register.YMM22, Register.YMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B24D2B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_ymm_k1z_ymm_ymmm256b32, Register.YMM2, Register.YMM6, Register.YMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F24D1B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F24DCB A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E20D4B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM18, Register.ZMM14, Register.ZMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 124D43 A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM10, Register.ZMM22, Register.ZMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B24D4B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F24D7B A7 D3", 6, Code.EVEX_Vfmsubadd213ps_zmm_k1z_zmm_zmmm512b32_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };

				yield return new object[] { "62 F2CD8B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E28D0B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM18, Register.XMM14, Register.XMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 12CD03 A7 D3", 6, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM10, Register.XMM22, Register.XMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B2CD0B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_xmm_k1z_xmm_xmmm128b64, Register.XMM2, Register.XMM6, Register.XMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F2CDDB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundUp, true };

				yield return new object[] { "62 F2CDAB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E28D2B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM18, Register.YMM14, Register.YMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 12CD23 A7 D3", 6, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM10, Register.YMM22, Register.YMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B2CD2B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_ymm_k1z_ymm_ymmm256b64, Register.YMM2, Register.YMM6, Register.YMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F2CD1B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundToNearest, false };

				yield return new object[] { "62 F2CDCB A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.None, true };
				yield return new object[] { "62 E28D4B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM18, Register.ZMM14, Register.ZMM3, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 12CD43 A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM10, Register.ZMM22, Register.ZMM27, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 B2CD4B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM19, Register.K3, RoundingControl.None, false };
				yield return new object[] { "62 F2CD7B A7 D3", 6, Code.EVEX_Vfmsubadd213pd_zmm_k1z_zmm_zmmm512b64_er, Register.ZMM2, Register.ZMM6, Register.ZMM3, Register.K3, RoundingControl.RoundTowardZero, false };
			}
		}
	}
}
