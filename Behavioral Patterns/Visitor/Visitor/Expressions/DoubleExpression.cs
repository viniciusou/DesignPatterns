namespace Visitor.Expressions
{
    public class DoubleExpression : Expression
    {
        public double Value;

        public DoubleExpression(double value)
        {
            Value = value;
        }
        public override void Accept(IExpressionVisitor visitor)
        {
            //double dispatch;
            visitor.Visit(this);
        }
    }
}
