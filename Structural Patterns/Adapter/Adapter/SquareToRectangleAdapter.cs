using System;

namespace Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private int width;
        private int height;
        public int Width
        {
            get => width;
            set => width = height = value;
        }

        public int Height
        {
            get => height;
            set => height = width = value;
        }

        public SquareToRectangleAdapter(Square square)
        {
            Width = square.Side;
        }
    }
}
