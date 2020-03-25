using Visitor.Expressions;

namespace Visitor
{
    public interface IExpressionVisitor
    {
        void Visit(DoubleExpression doubleExpression);

        void Visit(AdditionExpression additionExpression);
    }
}
