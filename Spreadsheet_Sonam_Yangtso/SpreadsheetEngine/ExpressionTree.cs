﻿// CptS 321: Expression Tree Code Demo of how NOT to code your assignements
// Problems and sollutions of this code will be discussed in class
// Note that if you sumbit this code you will not get ANY points for the assignments

using CptS321;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CptS321

{
    public class ExpressionTree
    {
        private ExpressionTreeNode root;


        private Dictionary<string, double> variables = new Dictionary<string, double>();

        public ExpressionTree()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpressionTreeCodeDemo.Expression"/> class.
        /// </summary>
        public ExpressionTree(string expression)
        {
            
            root = Compile(expression);
        }

        private static ExpressionTreeNode Compile(string expression)
        {
            char[] operators = { '+', '-', '*', '/', };
            if (string.IsNullOrEmpty(expression))
            {
                return null;

            }
            else
            {
                int expressionIndex = expression.Length - 1;
                while (expressionIndex > 0 && !operators.Contains(expression[expressionIndex]))
                {
                    expressionIndex--;
                }

                if (operators.Contains(expression[expressionIndex]))
                {
                    OperatorNode operatorNode = OperatorNodeFactory.CreateNewNode(expression[expressionIndex]);
                    // and start over with the left and right sub-expressions
                    operatorNode.Left = Compile(expression.Substring(0, expressionIndex));
                    operatorNode.Right = Compile(expression.Substring(expressionIndex + 1));
                    return operatorNode;

                }

                double number;
                if (double.TryParse(expression, out number))
                {
                    // we need a constantnode
                    ConstantNode newNode = new ConstantNode();

                    newNode.Value = number;
                    return newNode;

                }
                // or variable
                else
                {
                    // we need a variablenode
                    VariableNode newNode = new VariableNode();

                    newNode.Name = expression;
                    return newNode;
                }

            }
        }




        //// Precondition: n is non-null
        private double Evaluate(ExpressionTreeNode node)
        {
            // try to evaluate the node as a constant
            // the "as" operator is evaluated to null 
            // as opposed to throwing an exception

            return 0.0;
            //throw new NotSupportedException();
        }

        public double Evaluate()
        {
            return Evaluate(root);
        }

        public void SetVariable(string name, double value)
        {
            if (this.variables.ContainsKey(name))
            {
                this.variables[name] = value;
            }
        }
    }
}