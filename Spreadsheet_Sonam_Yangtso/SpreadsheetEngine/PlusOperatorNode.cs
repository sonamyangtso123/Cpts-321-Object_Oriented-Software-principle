﻿// <copyright file="PlusOperatorNode.cs" company="Sonam Yangtso">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CptS321
{
    /// <summary>
    /// plusOperatorNode.
    /// </summary>
    public class PlusOperatorNode : OperatorNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlusOperatorNode"/> class.
        /// gets the plus operator sign.
        /// </summary>
        ///
        public PlusOperatorNode()
            : base('+')
        {
        }

        /// <summary>
        ///
        /// gets the precedence of the operator.
        /// </summary>
        public override ushort Precedence => 5;

        /// <summary>
        /// Gets the Assocaitivity of the operator.
        /// </summary>
        public static Associative Associativity => Associative.Left;

        /// <summary>
        /// This is an override method that returns the evaluated value.
        /// </summary>
        /// <param name="variables"> variable.</param>
        /// <returns>calcualted value.</returns>
        public override double Evaluate(ref Dictionary<string, double> variables)
        {
            return this.Left.Evaluate(ref variables) + this.Right.Evaluate(ref variables);
        }
    }
}
