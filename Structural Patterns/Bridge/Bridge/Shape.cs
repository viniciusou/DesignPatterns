using Bridge.Renderers;
using System;

namespace Bridge
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer ?? throw new ArgumentNullException(paramName: nameof(renderer));
        }

        public abstract void Draw();

        public abstract void Resize(float factor);
    }
}
