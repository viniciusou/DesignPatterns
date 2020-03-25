namespace Visitor.Expressions
{
    public abstract class Expression
    {
        public abstract void Accept(IExpressionVisitor visitor);
    }
}
