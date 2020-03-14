using Decorator.Shapes;
using System;

namespace Decorator.Decorators
{
    public class TransparentShape : IShape
    {
        private IShape shape;
        private float transparency;

        public TransparentShape(IShape shape, float transparency)
        {
            this.shape = shape ?? throw new ArgumentNullException(paramName: nameof(shape));
            this.transparency = transparency;
        }
        public string AsString() => $"{shape.AsString()} has {transparency * 100.0}% transparency";
    }
}
