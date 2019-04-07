﻿using System.Collections.Generic;
using de4dot.Bea;
using de4dot.code.deobfuscators.ConfuserEx.x86;

namespace ConfuserDeobfuscator.Engine.Routines.Ex.x86.Instructions
{
    class X86NOT : X86Instruction
    {
        public X86NOT(Disasm rawInstruction) : base()
        {
            Operands = new IX86Operand[1];
            Operands[0] = GetOperand(rawInstruction.Argument1);
        }

        public override X86OpCode OpCode { get { return X86OpCode.NOT; } }

        public override void Execute(Dictionary<string, int> registers, Stack<int> localStack)
        {
            registers[((X86RegisterOperand)Operands[0]).Register.ToString()] =
            ~registers[((X86RegisterOperand) Operands[0]).Register.ToString()];
        }

    }
}
