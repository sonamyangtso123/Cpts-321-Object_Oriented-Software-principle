﻿// <copyright file="TestClass.cs" company="Sonam Yangtso">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using CptS321;
using CptS321;
using System.Globalization;

namespace NUnit.Tests
{
    /// <summary>
    /// Test class for the Assignment4.
    /// </summary>
    [TestFixture]
    public class TestClass
    {
        /// <summary>
        /// create an instance of Spreadsheet class.
        /// </summary>
        private Spreadsheet sheet;

        /// <summary>
        /// create an instance of cell class.
        /// </summary>
        private SpreadsheetCell cell;

        /// <summary>
        /// test the SpreadsheetCell class constructor.
        /// </summary>
        [Test]
        public void TestSpreadsheetCellGetter()
        {
            this.cell = new SpreadsheetCell(9, 8);
            Assert.That(this.cell.RowIndex, Is.EqualTo(9));
            Assert.That(this.cell.ColumnIndex, Is.EqualTo(8));
        }

        /// <summary>
        /// test case for the Spreadsheet class constructor.
        /// </summary>
        [Test]
        public void TestSpreadsheetRowCount()
        {
            this.sheet = new Spreadsheet(8, 3);
            Assert.That(this.sheet.RowCount, Is.EqualTo(8));
        }

        /// <summary>
        /// test the Spreadsheet class constructor and its ColumnCount property.
        /// </summary>
        [Test]

        public void TestSpreadsheetColumnCount()
        {
            this.sheet = new Spreadsheet(3, 5);
            Assert.That(this.sheet.ColumnCount, Is.EqualTo(5));
        }

        /// <summary>
        /// Test the GetCell method in the spreadsheet class.
        /// </summary>
        [Test]

        public void TestGetCell()
        {
            this.sheet = new Spreadsheet(50, 26);
            this.sheet.GetCell(3, 5).Text = "hello";
            Assert.That(this.sheet.GetCell(3, 5).Text, Is.EqualTo("hello"));
        }

        // Start here with Homework5 Test cases

        [Test]
        public void TestExpressionNodeConstructor()
        {
            ExpressionTree expression = new ExpressionTree("8+2");
            Assert.AreEqual("10", expression.Evaluate().ToString());
        }

        [Test]
        public void TestPlusEvaluateMethod()
        {
            string expression = "3+4+3";
            ExpressionTree tree = new ExpressionTree(expression);
            Assert.AreEqual("10", tree.Evaluate().ToString());
        }

        [Test]
        public void TestMinusEvaluateMethod()
        {
            string expression = "7-3-0";
            ExpressionTree tree = new ExpressionTree(expression);
            Assert.AreEqual("4", tree.Evaluate().ToString());
        }

        [Test]
        public void TestMultiplicationEvaluateMethd()
        {
            string expression = "10*3*2";
            ExpressionTree tree = new ExpressionTree(expression);
            Assert.AreEqual("60", tree.Evaluate().ToString());
        }

        [Test]
        public void TestDivisionEvaluateMethod()
        {
            string expression = "5/2";
            ExpressionTree tree = new ExpressionTree(expression);
            Assert.AreEqual("2.5", tree.Evaluate().ToString());
        }
        [Test]
        public void TestDivideByZero()
        {
            string expression = "3950/0";
            ExpressionTree tree = new ExpressionTree(expression);
            Assert.AreEqual("∞", tree.Evaluate().ToString());

        }


    }
}
