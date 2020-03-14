﻿using Decorator.Shapes;
using System;

namespace Decorator.Decorators
{
    public class ColoredShape : IShape
    {
        private IShape shape;
        private string color;

        public ColoredShape(IShape shape, string color)
        {
            this.shape = shape ?? throw new ArgumentNullException(paramName: nameof(shape));
            this.color = color ?? throw new ArgumentNullException(paramName: nameof(color));
        }
        public string AsString() => $"{shape.AsString()} has the color {color}";
    }
}
