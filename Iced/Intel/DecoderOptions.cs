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

#if (!NO_DECODER32 || !NO_DECODER64) && !NO_DECODER
using System;

namespace Iced.Intel {
	/// <summary>
	/// Decoder options
	/// </summary>
	[Flags]
	public enum DecoderOptions : uint {
		/// <summary>
		/// No option is enabled
		/// </summary>
		None						= 0,

		/// <summary>
		/// AMD decoder: allow 16-bit branch/ret instructions in 64-bit mode
		/// </summary>
		AMD							= 0x00000001,

		/// <summary>
		/// Decode opcodes 0F0D and 0F18-0F1F as reserved-nop instructions (eg. <see cref="Code.ReservedNop_rm32_r32_0F1D"/>)
		/// </summary>
		ForceReservedNop			= 0x00000002,

		/// <summary>
		/// Decode <see cref="Code.Cflsh"/>
		/// </summary>
		Cflsh						= 0x00000004,

		/// <summary>
		/// Decode umov instructions (eg. <see cref="Code.Umov_r32_rm32"/>)
		/// </summary>
		Umov						= 0x00000008,

		/// <summary>
		/// Decode <see cref="Code.Rdecr"/> and <see cref="Code.Wrecr"/>
		/// </summary>
		Ecr							= 0x00000010,

		/// <summary>
		/// Decode xbts/ibts
		/// </summary>
		Xbts						= 0x00000020,

		/// <summary>
		/// Decode 0FA6/0FA7 as cmpxchg
		/// </summary>
		Cmpxchg486A					= 0x00000040,

		/// <summary>
		/// Decode <see cref="Code.Zalloc_m256"/>
		/// </summary>
		Zalloc						= 0x00000080,

		/// <summary>
		/// Decode some old removed FPU instructions (eg. frstpm)
		/// </summary>
		OldFpu						= 0x00000100,

		/// <summary>
		/// Decode <see cref="Code.Pcommit"/>
		/// </summary>
		Pcommit						= 0x00000200,

		/// <summary>
		/// Decode 286 loadall (0F04 and 0F05)
		/// </summary>
		Loadall286					= 0x00000400,

		/// <summary>
		/// Decode <see cref="Code.Loadall386"/>
		/// </summary>
		Loadall386					= 0x00000800,

		/// <summary>
		/// Decode <see cref="Code.Cl1invmb"/>
		/// </summary>
		Cl1invmb					= 0x00001000,

		/// <summary>
		/// Decode <see cref="Code.Mov_r32_tr"/> and <see cref="Code.Mov_tr_r32"/>
		/// </summary>
		MovTr						= 0x00002000,
	}
}
#endif
