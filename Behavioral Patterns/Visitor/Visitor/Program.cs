using System;
using Visitor.Expressions;

namespace Visitor
{
    /// <summary>
    /// The visitor design pattern is a way of separating an algorithm from an object 
    /// structure on which it operates. A practical result of this separation is the 
    /// ability to add new operations to existing object structures without modifying 
    /// the structures. It is one way to follow the open/closed principle.
    /// 
    /// Visitor is a pattern where a component (Visitor) is allowed to traverse the
    /// entire inheritance hierarchy. Implementend by propagating a single Visit() 
    /// method throughout the entire hierarchy. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var expression = new AdditionExpression(
                new DoubleExpression(1),
                new AdditionExpression(new DoubleExpression(2), new DoubleExpression(3))
            );

            var expressionPrinter = new ExpressionPrinter();
            expressionPrinter.Visit(expression);

            Console.WriteLine(expressionPrinter);

            var calculator = new ExpressionCalculator();
            calculator.Visit(expression);
            Console.WriteLine($"{expressionPrinter} = {calculator.Result}");
        }
    }
}
