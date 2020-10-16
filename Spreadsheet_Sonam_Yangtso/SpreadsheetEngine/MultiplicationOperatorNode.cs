﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    public class MultiplicationOperatorNode: OperatorNode
    {
        public static char Operator
        {
            get { return '*'; }
        }

        public static ushort Precedence
        {
            get { return 1; }
        }

        public static Associative Associativity
        {
            get { return Associative.Left; }
        }

        public MultiplicationOperatorNode()
        {
        }

        public override double Evaluate()
        {
            return this.Left.Evaluate() * this.Right.Evaluate();
        }
    }
}
