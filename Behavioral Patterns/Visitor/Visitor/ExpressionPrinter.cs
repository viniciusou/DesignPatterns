using System.Text;
using Visitor.Expressions;

namespace Visitor
{
    public class ExpressionPrinter : IExpressionVisitor
    {
        StringBuilder stringBuilder = new StringBuilder();

        public void Visit(DoubleExpression doubleExpression)
        {
            stringBuilder.Append(doubleExpression.Value);
        }

        public void Visit(AdditionExpression additionExpression)
        {
            stringBuilder.Append("(");
            additionExpression.Left.Accept(this);
            stringBuilder.Append("+");
            additionExpression.Right.Accept(this);
            stringBuilder.Append(")");
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }
    }
}
