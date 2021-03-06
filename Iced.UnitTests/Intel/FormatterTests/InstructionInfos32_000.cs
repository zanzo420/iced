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

#if (!NO_GAS_FORMATTER || !NO_INTEL_FORMATTER || !NO_MASM_FORMATTER || !NO_NASM_FORMATTER) && !NO_FORMATTER
using Iced.Intel;

namespace Iced.UnitTests.Intel.FormatterTests {
	static class InstructionInfos32_000 {
		public const int AllInfos_Length = 633;
		public static readonly InstructionInfo[] AllInfos = new InstructionInfo[AllInfos_Length] {
			new InstructionInfo(32, "66 06", Code.Pushw_ES),
			new InstructionInfo(32, "06", Code.Pushd_ES),
			new InstructionInfo(32, "66 07", Code.Popw_ES),
			new InstructionInfo(32, "07", Code.Popd_ES),
			new InstructionInfo(32, "66 0E", Code.Pushw_CS),
			new InstructionInfo(32, "0E", Code.Pushd_CS),
			new InstructionInfo(32, "66 16", Code.Pushw_SS),
			new InstructionInfo(32, "16", Code.Pushd_SS),
			new InstructionInfo(32, "66 17", Code.Popw_SS),
			new InstructionInfo(32, "17", Code.Popd_SS),
			new InstructionInfo(32, "66 1E", Code.Pushw_DS),
			new InstructionInfo(32, "1E", Code.Pushd_DS),
			new InstructionInfo(32, "66 1F", Code.Popw_DS),
			new InstructionInfo(32, "1F", Code.Popd_DS),
			new InstructionInfo(32, "27", Code.Daa),
			new InstructionInfo(32, "2F", Code.Das),
			new InstructionInfo(32, "37", Code.Aaa),
			new InstructionInfo(32, "3F", Code.Aas),
			new InstructionInfo(32, "66 40", Code.Inc_r16),
			new InstructionInfo(32, "40", Code.Inc_r32),
			new InstructionInfo(32, "66 41", Code.Inc_r16),
			new InstructionInfo(32, "41", Code.Inc_r32),
			new InstructionInfo(32, "66 42", Code.Inc_r16),
			new InstructionInfo(32, "42", Code.Inc_r32),
			new InstructionInfo(32, "66 43", Code.Inc_r16),
			new InstructionInfo(32, "43", Code.Inc_r32),
			new InstructionInfo(32, "66 44", Code.Inc_r16),
			new InstructionInfo(32, "44", Code.Inc_r32),
			new InstructionInfo(32, "66 45", Code.Inc_r16),
			new InstructionInfo(32, "45", Code.Inc_r32),
			new InstructionInfo(32, "66 46", Code.Inc_r16),
			new InstructionInfo(32, "46", Code.Inc_r32),
			new InstructionInfo(32, "66 47", Code.Inc_r16),
			new InstructionInfo(32, "47", Code.Inc_r32),
			new InstructionInfo(32, "66 48", Code.Dec_r16),
			new InstructionInfo(32, "48", Code.Dec_r32),
			new InstructionInfo(32, "66 49", Code.Dec_r16),
			new InstructionInfo(32, "49", Code.Dec_r32),
			new InstructionInfo(32, "66 4A", Code.Dec_r16),
			new InstructionInfo(32, "4A", Code.Dec_r32),
			new InstructionInfo(32, "66 4B", Code.Dec_r16),
			new InstructionInfo(32, "4B", Code.Dec_r32),
			new InstructionInfo(32, "66 4C", Code.Dec_r16),
			new InstructionInfo(32, "4C", Code.Dec_r32),
			new InstructionInfo(32, "66 4D", Code.Dec_r16),
			new InstructionInfo(32, "4D", Code.Dec_r32),
			new InstructionInfo(32, "66 4E", Code.Dec_r16),
			new InstructionInfo(32, "4E", Code.Dec_r32),
			new InstructionInfo(32, "66 4F", Code.Dec_r16),
			new InstructionInfo(32, "4F", Code.Dec_r32),
			new InstructionInfo(32, "50", Code.Push_r32),
			new InstructionInfo(32, "51", Code.Push_r32),
			new InstructionInfo(32, "52", Code.Push_r32),
			new InstructionInfo(32, "53", Code.Push_r32),
			new InstructionInfo(32, "54", Code.Push_r32),
			new InstructionInfo(32, "55", Code.Push_r32),
			new InstructionInfo(32, "56", Code.Push_r32),
			new InstructionInfo(32, "57", Code.Push_r32),
			new InstructionInfo(32, "58", Code.Pop_r32),
			new InstructionInfo(32, "59", Code.Pop_r32),
			new InstructionInfo(32, "5A", Code.Pop_r32),
			new InstructionInfo(32, "5B", Code.Pop_r32),
			new InstructionInfo(32, "5C", Code.Pop_r32),
			new InstructionInfo(32, "5D", Code.Pop_r32),
			new InstructionInfo(32, "5E", Code.Pop_r32),
			new InstructionInfo(32, "5F", Code.Pop_r32),
			new InstructionInfo(32, "66 60", Code.Pushaw),
			new InstructionInfo(32, "60", Code.Pushad),
			new InstructionInfo(32, "66 61", Code.Popaw),
			new InstructionInfo(32, "61", Code.Popad),
			new InstructionInfo(32, "66 62 18", Code.Bound_r16_m1616),
			new InstructionInfo(32, "62 18", Code.Bound_r32_m3232),
			new InstructionInfo(32, "63 F2", Code.Arpl_r32m16_r32),
			new InstructionInfo(32, "63 18", Code.Arpl_r32m16_r32),
			new InstructionInfo(32, "68 5AA51234", Code.Pushd_imm32),
			new InstructionInfo(32, "6A A5", Code.Pushd_imm8),
			new InstructionInfo(32, "66 70 5A", Code.Jo_rel8_16),
			new InstructionInfo(32, "70 5A", Code.Jo_rel8_32),
			new InstructionInfo(32, "66 71 5A", Code.Jno_rel8_16),
			new InstructionInfo(32, "71 5A", Code.Jno_rel8_32),
			new InstructionInfo(32, "66 72 5A", Code.Jb_rel8_16),
			new InstructionInfo(32, "72 5A", Code.Jb_rel8_32),
			new InstructionInfo(32, "66 73 5A", Code.Jae_rel8_16),
			new InstructionInfo(32, "73 5A", Code.Jae_rel8_32),
			new InstructionInfo(32, "66 74 5A", Code.Je_rel8_16),
			new InstructionInfo(32, "74 5A", Code.Je_rel8_32),
			new InstructionInfo(32, "66 75 5A", Code.Jne_rel8_16),
			new InstructionInfo(32, "75 5A", Code.Jne_rel8_32),
			new InstructionInfo(32, "66 76 5A", Code.Jbe_rel8_16),
			new InstructionInfo(32, "76 5A", Code.Jbe_rel8_32),
			new InstructionInfo(32, "66 77 5A", Code.Ja_rel8_16),
			new InstructionInfo(32, "77 5A", Code.Ja_rel8_32),
			new InstructionInfo(32, "66 78 5A", Code.Js_rel8_16),
			new InstructionInfo(32, "78 5A", Code.Js_rel8_32),
			new InstructionInfo(32, "66 79 5A", Code.Jns_rel8_16),
			new InstructionInfo(32, "79 5A", Code.Jns_rel8_32),
			new InstructionInfo(32, "66 7A 5A", Code.Jp_rel8_16),
			new InstructionInfo(32, "7A 5A", Code.Jp_rel8_32),
			new InstructionInfo(32, "66 7B 5A", Code.Jnp_rel8_16),
			new InstructionInfo(32, "7B 5A", Code.Jnp_rel8_32),
			new InstructionInfo(32, "66 7C 5A", Code.Jl_rel8_16),
			new InstructionInfo(32, "7C 5A", Code.Jl_rel8_32),
			new InstructionInfo(32, "66 7D 5A", Code.Jge_rel8_16),
			new InstructionInfo(32, "7D 5A", Code.Jge_rel8_32),
			new InstructionInfo(32, "66 7E 5A", Code.Jle_rel8_16),
			new InstructionInfo(32, "7E 5A", Code.Jle_rel8_32),
			new InstructionInfo(32, "66 7F 5A", Code.Jg_rel8_16),
			new InstructionInfo(32, "7F 5A", Code.Jg_rel8_32),
			new InstructionInfo(32, "8F C6", Code.Pop_rm32),
			new InstructionInfo(32, "8F 00", Code.Pop_rm32),
			new InstructionInfo(32, "66 9A 1234 5678", Code.Call_ptr1616),
			new InstructionInfo(32, "9A 12345678 9ABC", Code.Call_ptr3216),
			new InstructionInfo(32, "9C", Code.Pushfd),
			new InstructionInfo(32, "9D", Code.Popfd),
			new InstructionInfo(32, "66 C2 5AA5", Code.Retnw_imm16),
			new InstructionInfo(32, "C2 5AA5", Code.Retnd_imm16),
			new InstructionInfo(32, "66 C3", Code.Retnw),
			new InstructionInfo(32, "C3", Code.Retnd),
			new InstructionInfo(32, "66 C4 18", Code.Les_r16_m32),
			new InstructionInfo(32, "C4 18", Code.Les_r32_m48),
			new InstructionInfo(32, "66 C5 18", Code.Lds_r16_m32),
			new InstructionInfo(32, "C5 18", Code.Lds_r32_m48),
			new InstructionInfo(32, "C8 5AA5 A6", Code.Enterd_imm16_imm8),
			new InstructionInfo(32, "C9", Code.Leaved),
			new InstructionInfo(32, "CE", Code.Into),
			new InstructionInfo(32, "D4 0A", Code.Aam_imm8),
			new InstructionInfo(32, "D5 0A", Code.Aad_imm8),
			new InstructionInfo(32, "66 67 E0 5A", Code.Loopne_rel8_16_CX),
			new InstructionInfo(32, "67 E0 5A", Code.Loopne_rel8_32_CX),
			new InstructionInfo(32, "66 E0 5A", Code.Loopne_rel8_16_ECX),
			new InstructionInfo(32, "E0 5A", Code.Loopne_rel8_32_ECX),
			new InstructionInfo(32, "66 67 E1 5A", Code.Loope_rel8_16_CX),
			new InstructionInfo(32, "67 E1 5A", Code.Loope_rel8_32_CX),
			new InstructionInfo(32, "66 E1 5A", Code.Loope_rel8_16_ECX),
			new InstructionInfo(32, "E1 5A", Code.Loope_rel8_32_ECX),
			new InstructionInfo(32, "66 67 E2 5A", Code.Loop_rel8_16_CX),
			new InstructionInfo(32, "67 E2 5A", Code.Loop_rel8_32_CX),
			new InstructionInfo(32, "66 E2 5A", Code.Loop_rel8_16_ECX),
			new InstructionInfo(32, "E2 5A", Code.Loop_rel8_32_ECX),
			new InstructionInfo(32, "66 67 E3 5A", Code.Jcxz_rel8_16),
			new InstructionInfo(32, "67 E3 5A", Code.Jcxz_rel8_32),
			new InstructionInfo(32, "66 E3 5A", Code.Jecxz_rel8_16),
			new InstructionInfo(32, "E3 5A", Code.Jecxz_rel8_32),
			new InstructionInfo(32, "66 E8 5AA5", Code.Call_rel16),
			new InstructionInfo(32, "E8 12345AA5", Code.Call_rel32_32),
			new InstructionInfo(32, "66 E9 5AA5", Code.Jmp_rel16),
			new InstructionInfo(32, "E9 12345AA5", Code.Jmp_rel32_32),
			new InstructionInfo(32, "66 EA 1234 5678", Code.Jmp_ptr1616),
			new InstructionInfo(32, "EA 12345678 EABC", Code.Jmp_ptr3216),
			new InstructionInfo(32, "66 EB 5A", Code.Jmp_rel8_16),
			new InstructionInfo(32, "EB 5A", Code.Jmp_rel8_32),
			new InstructionInfo(32, "66 FF D1", Code.Call_rm16),
			new InstructionInfo(32, "66 FF 10", Code.Call_rm16),
			new InstructionInfo(32, "FF D1", Code.Call_rm32),
			new InstructionInfo(32, "FF 10", Code.Call_rm32),
			new InstructionInfo(32, "66 FF E2", Code.Jmp_rm16),
			new InstructionInfo(32, "66 FF 20", Code.Jmp_rm16),
			new InstructionInfo(32, "FF E2", Code.Jmp_rm32),
			new InstructionInfo(32, "FF 20", Code.Jmp_rm32),
			new InstructionInfo(32, "FF F6", Code.Push_rm32),
			new InstructionInfo(32, "FF 30", Code.Push_rm32),
			new InstructionInfo(32, "66 0F1A CA", Code.Bndmov_bnd_bndm64),
			new InstructionInfo(32, "66 0F1A 08", Code.Bndmov_bnd_bndm64),
			new InstructionInfo(32, "F3 0F1A CA", Code.Bndcl_bnd_rm32),
			new InstructionInfo(32, "F3 0F1A 08", Code.Bndcl_bnd_rm32),
			new InstructionInfo(32, "F2 0F1A CA", Code.Bndcu_bnd_rm32),
			new InstructionInfo(32, "F2 0F1A 08", Code.Bndcu_bnd_rm32),
			new InstructionInfo(32, "66 0F1B CA", Code.Bndmov_bndm64_bnd),
			new InstructionInfo(32, "66 0F1B 08", Code.Bndmov_bndm64_bnd),
			new InstructionInfo(32, "F3 0F1B 08", Code.Bndmk_bnd_m32),
			new InstructionInfo(32, "F2 0F1B CA", Code.Bndcn_bnd_rm32),
			new InstructionInfo(32, "F2 0F1B 08", Code.Bndcn_bnd_rm32),
			new InstructionInfo(32, "0F20 DE", Code.Mov_r32_cr),
			new InstructionInfo(32, "0F21 DE", Code.Mov_r32_dr),
			new InstructionInfo(32, "0F22 DE", Code.Mov_cr_r32),
			new InstructionInfo(32, "0F23 DE", Code.Mov_dr_r32),
			new InstructionInfo(32, "0F78 CE", Code.Vmread_rm32_r32),
			new InstructionInfo(32, "0F78 18", Code.Vmread_rm32_r32),
			new InstructionInfo(32, "0F79 CE", Code.Vmwrite_r32_rm32),
			new InstructionInfo(32, "0F79 18", Code.Vmwrite_r32_rm32),
			new InstructionInfo(32, "66 0F80 5AA5", Code.Jo_rel16),
			new InstructionInfo(32, "0F80 5AA51234", Code.Jo_rel32_32),
			new InstructionInfo(32, "66 0F81 5AA5", Code.Jno_rel16),
			new InstructionInfo(32, "0F81 5AA51234", Code.Jno_rel32_32),
			new InstructionInfo(32, "66 0F82 5AA5", Code.Jb_rel16),
			new InstructionInfo(32, "0F82 5AA51234", Code.Jb_rel32_32),
			new InstructionInfo(32, "66 0F83 5AA5", Code.Jae_rel16),
			new InstructionInfo(32, "0F83 5AA51234", Code.Jae_rel32_32),
			new InstructionInfo(32, "66 0F84 5AA5", Code.Je_rel16),
			new InstructionInfo(32, "0F84 5AA51234", Code.Je_rel32_32),
			new InstructionInfo(32, "66 0F85 5AA5", Code.Jne_rel16),
			new InstructionInfo(32, "0F85 5AA51234", Code.Jne_rel32_32),
			new InstructionInfo(32, "66 0F86 5AA5", Code.Jbe_rel16),
			new InstructionInfo(32, "0F86 5AA51234", Code.Jbe_rel32_32),
			new InstructionInfo(32, "66 0F87 5AA5", Code.Ja_rel16),
			new InstructionInfo(32, "0F87 5AA51234", Code.Ja_rel32_32),
			new InstructionInfo(32, "66 0F88 5AA5", Code.Js_rel16),
			new InstructionInfo(32, "0F88 5AA51234", Code.Js_rel32_32),
			new InstructionInfo(32, "66 0F89 5AA5", Code.Jns_rel16),
			new InstructionInfo(32, "0F89 5AA51234", Code.Jns_rel32_32),
			new InstructionInfo(32, "66 0F8A 5AA5", Code.Jp_rel16),
			new InstructionInfo(32, "0F8A 5AA51234", Code.Jp_rel32_32),
			new InstructionInfo(32, "66 0F8B 5AA5", Code.Jnp_rel16),
			new InstructionInfo(32, "0F8B 5AA51234", Code.Jnp_rel32_32),
			new InstructionInfo(32, "66 0F8C 5AA5", Code.Jl_rel16),
			new InstructionInfo(32, "0F8C 5AA51234", Code.Jl_rel32_32),
			new InstructionInfo(32, "66 0F8D 5AA5", Code.Jge_rel16),
			new InstructionInfo(32, "0F8D 5AA51234", Code.Jge_rel32_32),
			new InstructionInfo(32, "66 0F8E 5AA5", Code.Jle_rel16),
			new InstructionInfo(32, "0F8E 5AA51234", Code.Jle_rel32_32),
			new InstructionInfo(32, "66 0F8F 5AA5", Code.Jg_rel16),
			new InstructionInfo(32, "0F8F 5AA51234", Code.Jg_rel32_32),
			new InstructionInfo(32, "0FA0", Code.Pushd_FS),
			new InstructionInfo(32, "0FA1", Code.Popd_FS),
			new InstructionInfo(32, "0FA8", Code.Pushd_GS),
			new InstructionInfo(32, "0FA9", Code.Popd_GS),
			new InstructionInfo(32, "F3 0FC7 FA", Code.Rdpid_r32),
			new InstructionInfo(32, "66 0F3880 10", Code.Invept_r32_m128),
			new InstructionInfo(32, "66 0F3881 10", Code.Invvpid_r32_m128),
			new InstructionInfo(32, "66 0F3882 10", Code.Invpcid_r32_m128),
			new InstructionInfo(32, "D6", Code.Salc),
			new InstructionInfo(32, "66 68 5AA5", Code.Push_imm16),
			new InstructionInfo(32, "66 6A A5", Code.Pushw_imm8),
			new InstructionInfo(32, "67 6C", Code.Insb_m8_DX),
			new InstructionInfo(32, "6C", Code.Insb_m8_DX),
			new InstructionInfo(32, "66 67 6D", Code.Insw_m16_DX),
			new InstructionInfo(32, "66 6D", Code.Insw_m16_DX),
			new InstructionInfo(32, "67 6D", Code.Insd_m32_DX),
			new InstructionInfo(32, "6D", Code.Insd_m32_DX),
			new InstructionInfo(32, "67 6E", Code.Outsb_DX_m8),
			new InstructionInfo(32, "6E", Code.Outsb_DX_m8),
			new InstructionInfo(32, "66 67 6F", Code.Outsw_DX_m16),
			new InstructionInfo(32, "66 6F", Code.Outsw_DX_m16),
			new InstructionInfo(32, "67 6F", Code.Outsd_DX_m32),
			new InstructionInfo(32, "6F", Code.Outsd_DX_m32),
			new InstructionInfo(32, "66 8E E6", Code.Mov_Sreg_rm16),
			new InstructionInfo(32, "66 8E 18", Code.Mov_Sreg_rm16),
			new InstructionInfo(32, "8E E6", Code.Mov_Sreg_rm32),
			new InstructionInfo(32, "8E 18", Code.Mov_Sreg_rm32),
			new InstructionInfo(32, "66 8F C6", Code.Pop_rm16),
			new InstructionInfo(32, "66 8F 00", Code.Pop_rm16),
			new InstructionInfo(32, "66 90", Code.Nopw),
			new InstructionInfo(32, "90", Code.Nopd),
			new InstructionInfo(32, "66 9C", Code.Pushfw),
			new InstructionInfo(32, "66 9D", Code.Popfw),
			new InstructionInfo(32, "A0 9ABCDEF0", Code.Mov_AL_moffs8),
			new InstructionInfo(32, "67 A0 DEF0", Code.Mov_AL_moffs8),
			new InstructionInfo(32, "66 A1 9ABCDEF0", Code.Mov_AX_moffs16),
			new InstructionInfo(32, "66 67 A1 DEF0", Code.Mov_AX_moffs16),
			new InstructionInfo(32, "A1 9ABCDEF0", Code.Mov_EAX_moffs32),
			new InstructionInfo(32, "67 A1 DEF0", Code.Mov_EAX_moffs32),
			new InstructionInfo(32, "A2 9ABCDEF0", Code.Mov_moffs8_AL),
			new InstructionInfo(32, "67 A2 DEF0", Code.Mov_moffs8_AL),
			new InstructionInfo(32, "66 A3 9ABCDEF0", Code.Mov_moffs16_AX),
			new InstructionInfo(32, "66 67 A3 DEF0", Code.Mov_moffs16_AX),
			new InstructionInfo(32, "A3 9ABCDEF0", Code.Mov_moffs32_EAX),
			new InstructionInfo(32, "67 A3 DEF0", Code.Mov_moffs32_EAX),
			new InstructionInfo(32, "67 A4", Code.Movsb_m8_m8),
			new InstructionInfo(32, "A4", Code.Movsb_m8_m8),
			new InstructionInfo(32, "66 67 A5", Code.Movsw_m16_m16),
			new InstructionInfo(32, "66 A5", Code.Movsw_m16_m16),
			new InstructionInfo(32, "67 A5", Code.Movsd_m32_m32),
			new InstructionInfo(32, "A5", Code.Movsd_m32_m32),
			new InstructionInfo(32, "67 A6", Code.Cmpsb_m8_m8),
			new InstructionInfo(32, "A6", Code.Cmpsb_m8_m8),
			new InstructionInfo(32, "66 67 A7", Code.Cmpsw_m16_m16),
			new InstructionInfo(32, "66 A7", Code.Cmpsw_m16_m16),
			new InstructionInfo(32, "67 A7", Code.Cmpsd_m32_m32),
			new InstructionInfo(32, "A7", Code.Cmpsd_m32_m32),
			new InstructionInfo(32, "67 AA", Code.Stosb_m8_AL),
			new InstructionInfo(32, "AA", Code.Stosb_m8_AL),
			new InstructionInfo(32, "66 67 AB", Code.Stosw_m16_AX),
			new InstructionInfo(32, "66 AB", Code.Stosw_m16_AX),
			new InstructionInfo(32, "67 AB", Code.Stosd_m32_EAX),
			new InstructionInfo(32, "AB", Code.Stosd_m32_EAX),
			new InstructionInfo(32, "67 AC", Code.Lodsb_AL_m8),
			new InstructionInfo(32, "AC", Code.Lodsb_AL_m8),
			new InstructionInfo(32, "66 67 AD", Code.Lodsw_AX_m16),
			new InstructionInfo(32, "66 AD", Code.Lodsw_AX_m16),
			new InstructionInfo(32, "67 AD", Code.Lodsd_EAX_m32),
			new InstructionInfo(32, "AD", Code.Lodsd_EAX_m32),
			new InstructionInfo(32, "67 AE", Code.Scasb_AL_m8),
			new InstructionInfo(32, "AE", Code.Scasb_AL_m8),
			new InstructionInfo(32, "66 67 AF", Code.Scasw_AX_m16),
			new InstructionInfo(32, "66 AF", Code.Scasw_AX_m16),
			new InstructionInfo(32, "67 AF", Code.Scasd_EAX_m32),
			new InstructionInfo(32, "AF", Code.Scasd_EAX_m32),
			new InstructionInfo(32, "66 C7 F8 5AA5", Code.Xbegin_rel16),
			new InstructionInfo(32, "C7 F8 5AA51234", Code.Xbegin_rel32),
			new InstructionInfo(32, "66 C8 5AA5 A6", Code.Enterw_imm16_imm8),
			new InstructionInfo(32, "66 C9", Code.Leavew),
			new InstructionInfo(32, "66 CA 5AA5", Code.Retfw_imm16),
			new InstructionInfo(32, "CA 5AA5", Code.Retfd_imm16),
			new InstructionInfo(32, "66 CB", Code.Retfw),
			new InstructionInfo(32, "CB", Code.Retfd),
			new InstructionInfo(32, "66 CF", Code.Iretw),
			new InstructionInfo(32, "CF", Code.Iretd),
			new InstructionInfo(32, "D2 C1", Code.Rol_rm8_CL),
			new InstructionInfo(32, "D2 00", Code.Rol_rm8_CL),
			new InstructionInfo(32, "D2 CA", Code.Ror_rm8_CL),
			new InstructionInfo(32, "D2 08", Code.Ror_rm8_CL),
			new InstructionInfo(32, "D2 D3", Code.Rcl_rm8_CL),
			new InstructionInfo(32, "D2 10", Code.Rcl_rm8_CL),
			new InstructionInfo(32, "D2 DC", Code.Rcr_rm8_CL),
			new InstructionInfo(32, "D2 18", Code.Rcr_rm8_CL),
			new InstructionInfo(32, "D2 E5", Code.Shl_rm8_CL),
			new InstructionInfo(32, "D2 20", Code.Shl_rm8_CL),
			new InstructionInfo(32, "D2 EE", Code.Shr_rm8_CL),
			new InstructionInfo(32, "D2 28", Code.Shr_rm8_CL),
			new InstructionInfo(32, "D2 F8", Code.Sar_rm8_CL),
			new InstructionInfo(32, "D2 38", Code.Sar_rm8_CL),
			new InstructionInfo(32, "66 D3 C1", Code.Rol_rm16_CL),
			new InstructionInfo(32, "66 D3 00", Code.Rol_rm16_CL),
			new InstructionInfo(32, "D3 C1", Code.Rol_rm32_CL),
			new InstructionInfo(32, "D3 00", Code.Rol_rm32_CL),
			new InstructionInfo(32, "66 D3 CA", Code.Ror_rm16_CL),
			new InstructionInfo(32, "66 D3 08", Code.Ror_rm16_CL),
			new InstructionInfo(32, "D3 CA", Code.Ror_rm32_CL),
			new InstructionInfo(32, "D3 08", Code.Ror_rm32_CL),
			new InstructionInfo(32, "66 D3 D3", Code.Rcl_rm16_CL),
			new InstructionInfo(32, "66 D3 10", Code.Rcl_rm16_CL),
			new InstructionInfo(32, "D3 D3", Code.Rcl_rm32_CL),
			new InstructionInfo(32, "D3 10", Code.Rcl_rm32_CL),
			new InstructionInfo(32, "66 D3 DC", Code.Rcr_rm16_CL),
			new InstructionInfo(32, "66 D3 18", Code.Rcr_rm16_CL),
			new InstructionInfo(32, "D3 DC", Code.Rcr_rm32_CL),
			new InstructionInfo(32, "D3 18", Code.Rcr_rm32_CL),
			new InstructionInfo(32, "66 D3 E5", Code.Shl_rm16_CL),
			new InstructionInfo(32, "66 D3 20", Code.Shl_rm16_CL),
			new InstructionInfo(32, "D3 E5", Code.Shl_rm32_CL),
			new InstructionInfo(32, "D3 20", Code.Shl_rm32_CL),
			new InstructionInfo(32, "66 D3 EE", Code.Shr_rm16_CL),
			new InstructionInfo(32, "66 D3 28", Code.Shr_rm16_CL),
			new InstructionInfo(32, "D3 EE", Code.Shr_rm32_CL),
			new InstructionInfo(32, "D3 28", Code.Shr_rm32_CL),
			new InstructionInfo(32, "66 D3 F8", Code.Sar_rm16_CL),
			new InstructionInfo(32, "66 D3 38", Code.Sar_rm16_CL),
			new InstructionInfo(32, "D3 F8", Code.Sar_rm32_CL),
			new InstructionInfo(32, "D3 38", Code.Sar_rm32_CL),
			new InstructionInfo(32, "D9 28", Code.Fldcw_m16),
			new InstructionInfo(32, "D9 38", Code.Fnstcw_m16),
			new InstructionInfo(32, "DD 38", Code.Fnstsw_m16),
			new InstructionInfo(32, "66 FF 18", Code.Call_m1616),
			new InstructionInfo(32, "FF 18", Code.Call_m3216),
			new InstructionInfo(32, "66 FF 28", Code.Jmp_m1616),
			new InstructionInfo(32, "FF 28", Code.Jmp_m3216),
			new InstructionInfo(32, "66 FF F6", Code.Push_rm16),
			new InstructionInfo(32, "66 FF 30", Code.Push_rm16),
			new InstructionInfo(32, "66 0F01 00", Code.Sgdt_m40),
			new InstructionInfo(32, "0F01 00", Code.Sgdt_m48),
			new InstructionInfo(32, "66 0F01 08", Code.Sidt_m40),
			new InstructionInfo(32, "0F01 08", Code.Sidt_m48),
			new InstructionInfo(32, "66 0F01 10", Code.Lgdt_m40),
			new InstructionInfo(32, "0F01 10", Code.Lgdt_m48),
			new InstructionInfo(32, "66 0F01 18", Code.Lidt_m40),
			new InstructionInfo(32, "0F01 18", Code.Lidt_m48),
			new InstructionInfo(32, "66 0F02 CE", Code.Lar_r16_rm16),
			new InstructionInfo(32, "66 0F02 18", Code.Lar_r16_rm16),
			new InstructionInfo(32, "0F02 CE", Code.Lar_r32_rm32),
			new InstructionInfo(32, "0F02 18", Code.Lar_r32_rm32),
			new InstructionInfo(32, "66 0F03 CE", Code.Lsl_r16_rm16),
			new InstructionInfo(32, "66 0F03 18", Code.Lsl_r16_rm16),
			new InstructionInfo(32, "0F03 CE", Code.Lsl_r32_rm32),
			new InstructionInfo(32, "0F03 18", Code.Lsl_r32_rm32),
			new InstructionInfo(32, "0F1A 08", Code.Bndldx_bnd_mib),
			new InstructionInfo(32, "0F1B 08", Code.Bndstx_mib_bnd),
			new InstructionInfo(32, "C5F8 90 D3", Code.VEX_Kmovw_k_km16),
			new InstructionInfo(32, "C5F8 90 08", Code.VEX_Kmovw_k_km16),
			new InstructionInfo(32, "C5F9 90 D3", Code.VEX_Kmovb_k_km8),
			new InstructionInfo(32, "C5F9 90 08", Code.VEX_Kmovb_k_km8),
			new InstructionInfo(32, "C4E1F9 90 D3", Code.VEX_Kmovd_k_km32),
			new InstructionInfo(32, "C4E1F9 90 08", Code.VEX_Kmovd_k_km32),
			new InstructionInfo(32, "C5F8 91 08", Code.VEX_Kmovw_m16_k),
			new InstructionInfo(32, "C5F9 91 08", Code.VEX_Kmovb_m8_k),
			new InstructionInfo(32, "C4E1F9 91 08", Code.VEX_Kmovd_m32_k),
			new InstructionInfo(32, "C5F8 92 D3", Code.VEX_Kmovw_k_r32),
			new InstructionInfo(32, "C5F9 92 D3", Code.VEX_Kmovb_k_r32),
			new InstructionInfo(32, "C5FB 92 D3", Code.VEX_Kmovd_k_r32),
			new InstructionInfo(32, "C5F8 93 D3", Code.VEX_Kmovw_r32_k),
			new InstructionInfo(32, "C5F9 93 D3", Code.VEX_Kmovb_r32_k),
			new InstructionInfo(32, "C5FB 93 D3", Code.VEX_Kmovd_r32_k),
			new InstructionInfo(32, "C5F8 98 D3", Code.VEX_Kortestw_k_k),
			new InstructionInfo(32, "C4E1F8 98 D3", Code.VEX_Kortestq_k_k),
			new InstructionInfo(32, "C5F9 98 D3", Code.VEX_Kortestb_k_k),
			new InstructionInfo(32, "C4E1F9 98 D3", Code.VEX_Kortestd_k_k),
			new InstructionInfo(32, "C5F8 99 D3", Code.VEX_Ktestw_k_k),
			new InstructionInfo(32, "C4E1F8 99 D3", Code.VEX_Ktestq_k_k),
			new InstructionInfo(32, "C5F9 99 D3", Code.VEX_Ktestb_k_k),
			new InstructionInfo(32, "C4E1F9 99 D3", Code.VEX_Ktestd_k_k),
			new InstructionInfo(32, "66 0FA0", Code.Pushw_FS),
			new InstructionInfo(32, "66 0FA1", Code.Popw_FS),
			new InstructionInfo(32, "66 0FA5 CE", Code.Shld_rm16_r16_CL),
			new InstructionInfo(32, "66 0FA5 18", Code.Shld_rm16_r16_CL),
			new InstructionInfo(32, "0FA5 CE", Code.Shld_rm32_r32_CL),
			new InstructionInfo(32, "0FA5 18", Code.Shld_rm32_r32_CL),
			new InstructionInfo(32, "66 0FA8", Code.Pushw_GS),
			new InstructionInfo(32, "66 0FA9", Code.Popw_GS),
			new InstructionInfo(32, "66 0FAD CE", Code.Shrd_rm16_r16_CL),
			new InstructionInfo(32, "66 0FAD 18", Code.Shrd_rm16_r16_CL),
			new InstructionInfo(32, "0FAD CE", Code.Shrd_rm32_r32_CL),
			new InstructionInfo(32, "0FAD 18", Code.Shrd_rm32_r32_CL),
			new InstructionInfo(32, "66 0FB2 18", Code.Lss_r16_m32),
			new InstructionInfo(32, "0FB2 18", Code.Lss_r32_m48),
			new InstructionInfo(32, "66 0FB4 18", Code.Lfs_r16_m32),
			new InstructionInfo(32, "0FB4 18", Code.Lfs_r32_m48),
			new InstructionInfo(32, "66 0FB5 18", Code.Lgs_r16_m32),
			new InstructionInfo(32, "0FB5 18", Code.Lgs_r32_m48),
			new InstructionInfo(32, "66 0FB6 CE", Code.Movzx_r16_rm8),
			new InstructionInfo(32, "66 0FB6 18", Code.Movzx_r16_rm8),
			new InstructionInfo(32, "0FB6 CE", Code.Movzx_r32_rm8),
			new InstructionInfo(32, "0FB6 18", Code.Movzx_r32_rm8),
			new InstructionInfo(32, "66 0FB7 CE", Code.Movzx_r16_rm16),
			new InstructionInfo(32, "66 0FB7 18", Code.Movzx_r16_rm16),
			new InstructionInfo(32, "0FB7 CE", Code.Movzx_r32_rm16),
			new InstructionInfo(32, "0FB7 18", Code.Movzx_r32_rm16),
			new InstructionInfo(32, "66 0FBE CE", Code.Movsx_r16_rm8),
			new InstructionInfo(32, "66 0FBE 18", Code.Movsx_r16_rm8),
			new InstructionInfo(32, "0FBE CE", Code.Movsx_r32_rm8),
			new InstructionInfo(32, "0FBE 18", Code.Movsx_r32_rm8),
			new InstructionInfo(32, "66 0FBF CE", Code.Movsx_r16_rm16),
			new InstructionInfo(32, "66 0FBF 18", Code.Movsx_r16_rm16),
			new InstructionInfo(32, "0FBF CE", Code.Movsx_r32_rm16),
			new InstructionInfo(32, "0FBF 18", Code.Movsx_r32_rm16),
			new InstructionInfo(32, "0FC7 08", Code.Cmpxchg8b_m64),
			new InstructionInfo(32, "F2 0F38F0 CE", Code.Crc32_r32_rm8),
			new InstructionInfo(32, "F2 0F38F0 18", Code.Crc32_r32_rm8),
			new InstructionInfo(32, "66 F2 0F38F1 CE", Code.Crc32_r32_rm16),
			new InstructionInfo(32, "66 F2 0F38F1 18", Code.Crc32_r32_rm16),
			new InstructionInfo(32, "F2 0F38F1 CE", Code.Crc32_r32_rm32),
			new InstructionInfo(32, "F2 0F38F1 18", Code.Crc32_r32_rm32),
			new InstructionInfo(32, "67 0FF7 D3", Code.Maskmovq_rDI_mm_mm),
			new InstructionInfo(32, "0FF7 D3", Code.Maskmovq_rDI_mm_mm),
			new InstructionInfo(32, "67 66 0FF7 D3", Code.Maskmovdqu_rDI_xmm_xmm),
			new InstructionInfo(32, "66 0FF7 D3", Code.Maskmovdqu_rDI_xmm_xmm),
			new InstructionInfo(32, "67 C5F9 F7 D3", Code.VEX_Vmaskmovdqu_rDI_xmm_xmm),
			new InstructionInfo(32, "C5F9 F7 D3", Code.VEX_Vmaskmovdqu_rDI_xmm_xmm),
			new InstructionInfo(32, "64 6E", Code.Outsb_DX_m8),
			new InstructionInfo(32, "64 66 6F", Code.Outsw_DX_m16),
			new InstructionInfo(32, "64 6F", Code.Outsd_DX_m32),
			new InstructionInfo(32, "64 A4", Code.Movsb_m8_m8),
			new InstructionInfo(32, "64 66 A5", Code.Movsw_m16_m16),
			new InstructionInfo(32, "64 A5", Code.Movsd_m32_m32),
			new InstructionInfo(32, "64 A6", Code.Cmpsb_m8_m8),
			new InstructionInfo(32, "64 66 A7", Code.Cmpsw_m16_m16),
			new InstructionInfo(32, "64 A7", Code.Cmpsd_m32_m32),
			new InstructionInfo(32, "64 AC", Code.Lodsb_AL_m8),
			new InstructionInfo(32, "64 66 AD", Code.Lodsw_AX_m16),
			new InstructionInfo(32, "64 AD", Code.Lodsd_EAX_m32),
			new InstructionInfo(32, "67 D7", Code.Xlatb),
			new InstructionInfo(32, "64 D7", Code.Xlatb),
			new InstructionInfo(32, "64 0FF7 D3", Code.Maskmovq_rDI_mm_mm),
			new InstructionInfo(32, "64 66 0FF7 D3", Code.Maskmovdqu_rDI_xmm_xmm),
			new InstructionInfo(32, "64 C5F9 F7 D3", Code.VEX_Vmaskmovdqu_rDI_xmm_xmm),
			new InstructionInfo(32, "D7", Code.Xlatb),
			new InstructionInfo(32, "D4 FA", Code.Aam_imm8),
			new InstructionInfo(32, "D5 FA", Code.Aad_imm8),
			new InstructionInfo(32, "66 D9 20", Code.Fldenv_m14byte),
			new InstructionInfo(32, "D9 20", Code.Fldenv_m28byte),
			new InstructionInfo(32, "66 D9 30", Code.Fnstenv_m14byte),
			new InstructionInfo(32, "D9 30", Code.Fnstenv_m28byte),
			new InstructionInfo(32, "66 DD 20", Code.Frstor_m94byte),
			new InstructionInfo(32, "DD 20", Code.Frstor_m108byte),
			new InstructionInfo(32, "66 DD 30", Code.Fnsave_m94byte),
			new InstructionInfo(32, "DD 30", Code.Fnsave_m108byte),
			new InstructionInfo(32, "67 0F01 C8", Code.Monitorw),
			new InstructionInfo(32, "0F01 C8", Code.Monitord),
			new InstructionInfo(32, "0F01 C9", Code.Mwait),
			new InstructionInfo(32, "64 A0 9ABCDEF0", Code.Mov_AL_moffs8),
			new InstructionInfo(32, "64 67 A0 DEF0", Code.Mov_AL_moffs8),
			new InstructionInfo(32, "64 66 A1 9ABCDEF0", Code.Mov_AX_moffs16),
			new InstructionInfo(32, "64 66 67 A1 DEF0", Code.Mov_AX_moffs16),
			new InstructionInfo(32, "64 A1 9ABCDEF0", Code.Mov_EAX_moffs32),
			new InstructionInfo(32, "64 67 A1 DEF0", Code.Mov_EAX_moffs32),
			new InstructionInfo(32, "64 A2 9ABCDEF0", Code.Mov_moffs8_AL),
			new InstructionInfo(32, "64 67 A2 DEF0", Code.Mov_moffs8_AL),
			new InstructionInfo(32, "64 66 A3 9ABCDEF0", Code.Mov_moffs16_AX),
			new InstructionInfo(32, "64 66 67 A3 DEF0", Code.Mov_moffs16_AX),
			new InstructionInfo(32, "64 A3 9ABCDEF0", Code.Mov_moffs32_EAX),
			new InstructionInfo(32, "64 67 A3 DEF0", Code.Mov_moffs32_EAX),
			new InstructionInfo(32, "8A 08", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 48 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 88 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0D 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 48 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 88 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0D 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C 08", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C 48", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C 88", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C C8", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 08 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 48 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 88 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C C8 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 08 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 48 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 88 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C C8 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 08 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 48 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 88 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C C8 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 08 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 48 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 88 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C C8 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C 0D 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 4D EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 8D 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C CD 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C 0D 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 4C 4D 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 8C 8D 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "8A 0C CD 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 08", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 48 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 88 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0D 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 48 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 88 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0D 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C 08", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C 48", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C 88", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C C8", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 08 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 48 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 88 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C C8 EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 08 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 48 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 88 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C C8 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 08 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 48 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 88 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C C8 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 08 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 48 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 88 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C C8 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C 0D 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 4D EE", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 8D 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C CD 88A9CBED", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C 0D 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 4C 4D 12", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 8C 8D 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "64 8A 0C CD 78563412", Code.Mov_r8_rm8),
			new InstructionInfo(32, "67 0F01 D8", Code.Vmrunw),
			new InstructionInfo(32, "0F01 D8", Code.Vmrund),
			new InstructionInfo(32, "67 0F01 DA", Code.Vmloadw),
			new InstructionInfo(32, "0F01 DA", Code.Vmloadd),
			new InstructionInfo(32, "67 0F01 DB", Code.Vmsavew),
			new InstructionInfo(32, "0F01 DB", Code.Vmsaved),
			new InstructionInfo(32, "67 0F01 DF", Code.Invlpgaw),
			new InstructionInfo(32, "0F01 DF", Code.Invlpgad),
			new InstructionInfo(32, "67 0F01 FA", Code.Monitorxw),
			new InstructionInfo(32, "0F01 FA", Code.Monitorxd),
			new InstructionInfo(32, "66 0F01 FC", Code.Clzerow),
			new InstructionInfo(32, "0F01 FC", Code.Clzerod),
			new InstructionInfo(32, "82 C1 5A", Code.Add_rm8_imm8_82),
			new InstructionInfo(32, "82 00 5A", Code.Add_rm8_imm8_82),
			new InstructionInfo(32, "82 CA A5", Code.Or_rm8_imm8_82),
			new InstructionInfo(32, "82 08 A5", Code.Or_rm8_imm8_82),
			new InstructionInfo(32, "82 D3 5A", Code.Adc_rm8_imm8_82),
			new InstructionInfo(32, "82 10 5A", Code.Adc_rm8_imm8_82),
			new InstructionInfo(32, "82 DC A5", Code.Sbb_rm8_imm8_82),
			new InstructionInfo(32, "82 18 A5", Code.Sbb_rm8_imm8_82),
			new InstructionInfo(32, "82 E5 5A", Code.And_rm8_imm8_82),
			new InstructionInfo(32, "82 20 5A", Code.And_rm8_imm8_82),
			new InstructionInfo(32, "82 EE A5", Code.Sub_rm8_imm8_82),
			new InstructionInfo(32, "82 28 A5", Code.Sub_rm8_imm8_82),
			new InstructionInfo(32, "82 F7 5A", Code.Xor_rm8_imm8_82),
			new InstructionInfo(32, "82 30 5A", Code.Xor_rm8_imm8_82),
			new InstructionInfo(32, "82 F8 A5", Code.Cmp_rm8_imm8_82),
			new InstructionInfo(32, "82 38 A5", Code.Cmp_rm8_imm8_82),
			new InstructionInfo(32, "DB E5", Code.Frstpm, DecoderOptions.OldFpu),
			new InstructionInfo(32, "DF E1", Code.Fstdw_AX, DecoderOptions.OldFpu),
			new InstructionInfo(32, "DF E2", Code.Fstsg_AX, DecoderOptions.OldFpu),
			new InstructionInfo(32, "66 0F00 F1", Code.Jmpe_rm16),
			new InstructionInfo(32, "66 0F00 30", Code.Jmpe_rm16),
			new InstructionInfo(32, "0F00 F2", Code.Jmpe_rm32),
			new InstructionInfo(32, "0F00 30", Code.Jmpe_rm32),
			new InstructionInfo(32, "0F04", Code.Loadallreset286, DecoderOptions.Loadall286),
			new InstructionInfo(32, "0F05", Code.Loadall286, DecoderOptions.Loadall286),
			new InstructionInfo(32, "0F07", Code.Loadall386, DecoderOptions.Loadall386),
			new InstructionInfo(32, "0F0A", Code.Cflsh, DecoderOptions.Cflsh),
			new InstructionInfo(32, "0F10 CE", Code.Umov_rm8_r8, DecoderOptions.Umov),
			new InstructionInfo(32, "0F10 18", Code.Umov_rm8_r8, DecoderOptions.Umov),
			new InstructionInfo(32, "66 0F11 CE", Code.Umov_rm16_r16, DecoderOptions.Umov),
			new InstructionInfo(32, "66 0F11 18", Code.Umov_rm16_r16, DecoderOptions.Umov),
			new InstructionInfo(32, "0F11 CE", Code.Umov_rm32_r32, DecoderOptions.Umov),
			new InstructionInfo(32, "0F11 18", Code.Umov_rm32_r32, DecoderOptions.Umov),
			new InstructionInfo(32, "0F12 CE", Code.Umov_r8_rm8, DecoderOptions.Umov),
			new InstructionInfo(32, "0F12 18", Code.Umov_r8_rm8, DecoderOptions.Umov),
			new InstructionInfo(32, "66 0F13 CE", Code.Umov_r16_rm16, DecoderOptions.Umov),
			new InstructionInfo(32, "66 0F13 18", Code.Umov_r16_rm16, DecoderOptions.Umov),
			new InstructionInfo(32, "0F13 CE", Code.Umov_r32_rm32, DecoderOptions.Umov),
			new InstructionInfo(32, "0F13 18", Code.Umov_r32_rm32, DecoderOptions.Umov),
			new InstructionInfo(32, "0F24 DE", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F26 DE", Code.Mov_tr_r32, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F34", Code.Wrecr, DecoderOptions.Ecr),
			new InstructionInfo(32, "0F36", Code.Rdecr, DecoderOptions.Ecr),
			new InstructionInfo(32, "66 0FA6 CE", Code.Xbts_r16_rm16, DecoderOptions.Xbts),
			new InstructionInfo(32, "66 0FA6 18", Code.Xbts_r16_rm16, DecoderOptions.Xbts),
			new InstructionInfo(32, "0FA6 CE", Code.Xbts_r32_rm32, DecoderOptions.Xbts),
			new InstructionInfo(32, "0FA6 18", Code.Xbts_r32_rm32, DecoderOptions.Xbts),
			new InstructionInfo(32, "66 0FA7 CE", Code.Ibts_rm16_r16, DecoderOptions.Xbts),
			new InstructionInfo(32, "66 0FA7 18", Code.Ibts_rm16_r16, DecoderOptions.Xbts),
			new InstructionInfo(32, "0FA7 CE", Code.Ibts_rm32_r32, DecoderOptions.Xbts),
			new InstructionInfo(32, "0FA7 18", Code.Ibts_rm32_r32, DecoderOptions.Xbts),
			new InstructionInfo(32, "0FA6 CE", Code.Cmpxchg486_rm8_r8, DecoderOptions.Cmpxchg486A),
			new InstructionInfo(32, "0FA6 18", Code.Cmpxchg486_rm8_r8, DecoderOptions.Cmpxchg486A),
			new InstructionInfo(32, "66 0FA7 CE", Code.Cmpxchg486_rm16_r16, DecoderOptions.Cmpxchg486A),
			new InstructionInfo(32, "66 0FA7 18", Code.Cmpxchg486_rm16_r16, DecoderOptions.Cmpxchg486A),
			new InstructionInfo(32, "0FA7 CE", Code.Cmpxchg486_rm32_r32, DecoderOptions.Cmpxchg486A),
			new InstructionInfo(32, "0FA7 18", Code.Cmpxchg486_rm32_r32, DecoderOptions.Cmpxchg486A),
			new InstructionInfo(32, "0FAE 00", Code.Zalloc_m256, DecoderOptions.Zalloc),
			new InstructionInfo(32, "67 F3 0FAE F5", Code.Umonitor_r16),
			new InstructionInfo(32, "F3 0FAE F5", Code.Umonitor_r32),
			new InstructionInfo(32, "66 0FB8 5AA5", Code.Jmpe_disp16),
			new InstructionInfo(32, "0FB8 12345AA5", Code.Jmpe_disp32),
			new InstructionInfo(32, "67 66 0F38F8 18", Code.Movdir64b_r16_m512),
			new InstructionInfo(32, "66 0F38F8 18", Code.Movdir64b_r32_m512),
			new InstructionInfo(32, "0F24 C0", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 C8", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 D0", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 D8", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 E0", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 E8", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 F0", Code.Mov_r32_tr, DecoderOptions.MovTr),
			new InstructionInfo(32, "0F24 F8", Code.Mov_r32_tr, DecoderOptions.MovTr),
		};
	}
}
#endif
