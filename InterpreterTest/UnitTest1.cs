using Interpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace InterpreterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void YearTest()
        {
            Context context = new Context(DateTime.Now);
            context.Expression = "YYYY";

            string expected = "2022";
            string actual = new YearExpression().Interpret(context);


            Assert.AreEqual(expected, actual);
        }

    }
}
