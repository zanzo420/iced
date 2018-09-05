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

#if !NO_GAS_FORMATTER && !NO_FORMATTER
namespace Iced.Intel.GasFormatterInternal {
	static class MemorySizes {
		public static readonly (MemorySize memorySize, string bcstTo)[] AllMemorySizes = new(MemorySize memorySize, string bcstTo)[DecoderConstants.NumberOfMemorySizes] {
			(MemorySize.Unknown, null),
			(MemorySize.UInt8, null),
			(MemorySize.UInt16, null),
			(MemorySize.UInt32, null),
			(MemorySize.UInt52, null),
			(MemorySize.UInt64, null),
			(MemorySize.UInt128, null),
			(MemorySize.UInt256, null),
			(MemorySize.UInt512, null),
			(MemorySize.Int8, null),
			(MemorySize.Int16, null),
			(MemorySize.Int32, null),
			(MemorySize.Int64, null),
			(MemorySize.Int128, null),
			(MemorySize.Int256, null),
			(MemorySize.Int512, null),
			(MemorySize.SegPtr16, null),
			(MemorySize.SegPtr32, null),
			(MemorySize.SegPtr64, null),
			(MemorySize.WordOffset, null),
			(MemorySize.DwordOffset, null),
			(MemorySize.QwordOffset, null),
			(MemorySize.Bound16_WordWord, null),
			(MemorySize.Bound32_DwordDword, null),
			(MemorySize.Bnd32, null),
			(MemorySize.Bnd64, null),
			(MemorySize.Fword5, null),
			(MemorySize.Fword6, null),
			(MemorySize.Fword10, null),
			(MemorySize.Float16, null),
			(MemorySize.Float32, null),
			(MemorySize.Float64, null),
			(MemorySize.Float80, null),
			(MemorySize.Float128, null),
			(MemorySize.FpuEnv14, null),
			(MemorySize.FpuEnv28, null),
			(MemorySize.FpuState98, null),
			(MemorySize.FpuState108, null),
			(MemorySize.Fxsave_512Byte, null),
			(MemorySize.Fxsave64_512Byte, null),
			(MemorySize.Xsave, null),
			(MemorySize.Xsave64, null),
			(MemorySize.Bcd, null),
			(MemorySize.Packed16_UInt8, null),
			(MemorySize.Packed16_Int8, null),
			(MemorySize.Packed32_UInt8, null),
			(MemorySize.Packed32_Int8, null),
			(MemorySize.Packed32_UInt16, null),
			(MemorySize.Packed32_Int16, null),
			(MemorySize.Packed64_UInt8, null),
			(MemorySize.Packed64_Int8, null),
			(MemorySize.Packed64_UInt16, null),
			(MemorySize.Packed64_Int16, null),
			(MemorySize.Packed64_UInt32, null),
			(MemorySize.Packed64_Int32, null),
			(MemorySize.Packed64_Float16, null),
			(MemorySize.Packed64_Float32, null),
			(MemorySize.Packed128_UInt8, null),
			(MemorySize.Packed128_Int8, null),
			(MemorySize.Packed128_UInt16, null),
			(MemorySize.Packed128_Int16, null),
			(MemorySize.Packed128_UInt32, null),
			(MemorySize.Packed128_Int32, null),
			(MemorySize.Packed128_UInt52, null),
			(MemorySize.Packed128_UInt64, null),
			(MemorySize.Packed128_Int64, null),
			(MemorySize.Packed128_Float16, null),
			(MemorySize.Packed128_Float32, null),
			(MemorySize.Packed128_Float64, null),
			(MemorySize.Packed256_UInt8, null),
			(MemorySize.Packed256_Int8, null),
			(MemorySize.Packed256_UInt16, null),
			(MemorySize.Packed256_Int16, null),
			(MemorySize.Packed256_UInt32, null),
			(MemorySize.Packed256_Int32, null),
			(MemorySize.Packed256_UInt52, null),
			(MemorySize.Packed256_UInt64, null),
			(MemorySize.Packed256_Int64, null),
			(MemorySize.Packed256_UInt128, null),
			(MemorySize.Packed256_Int128, null),
			(MemorySize.Packed256_Float16, null),
			(MemorySize.Packed256_Float32, null),
			(MemorySize.Packed256_Float64, null),
			(MemorySize.Packed256_Float128, null),
			(MemorySize.Packed512_UInt8, null),
			(MemorySize.Packed512_Int8, null),
			(MemorySize.Packed512_UInt16, null),
			(MemorySize.Packed512_Int16, null),
			(MemorySize.Packed512_UInt32, null),
			(MemorySize.Packed512_Int32, null),
			(MemorySize.Packed512_UInt52, null),
			(MemorySize.Packed512_UInt64, null),
			(MemorySize.Packed512_Int64, null),
			(MemorySize.Packed512_UInt128, null),
			(MemorySize.Packed512_Float32, null),
			(MemorySize.Packed512_Float64, null),
			(MemorySize.Broadcast64_UInt32, "1to2"),
			(MemorySize.Broadcast64_Int32, "1to2"),
			(MemorySize.Broadcast64_Float32, "1to2"),
			(MemorySize.Broadcast128_UInt32, "1to4"),
			(MemorySize.Broadcast128_Int32, "1to4"),
			(MemorySize.Broadcast128_UInt52, "1to2"),
			(MemorySize.Broadcast128_UInt64, "1to2"),
			(MemorySize.Broadcast128_Int64, "1to2"),
			(MemorySize.Broadcast128_Float32, "1to4"),
			(MemorySize.Broadcast128_Float64, "1to2"),
			(MemorySize.Broadcast256_UInt32, "1to8"),
			(MemorySize.Broadcast256_Int32, "1to8"),
			(MemorySize.Broadcast256_UInt52, "1to4"),
			(MemorySize.Broadcast256_UInt64, "1to4"),
			(MemorySize.Broadcast256_Int64, "1to4"),
			(MemorySize.Broadcast256_Float32, "1to8"),
			(MemorySize.Broadcast256_Float64, "1to4"),
			(MemorySize.Broadcast512_UInt32, "1to16"),
			(MemorySize.Broadcast512_Int32, "1to16"),
			(MemorySize.Broadcast512_UInt52, "1to8"),
			(MemorySize.Broadcast512_UInt64, "1to8"),
			(MemorySize.Broadcast512_Int64, "1to8"),
			(MemorySize.Broadcast512_Float32, "1to16"),
			(MemorySize.Broadcast512_Float64, "1to8"),
		};
	}
}
#endif