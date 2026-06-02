using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Rectangle
    {
        public struct Point
        {
            private int _x;
            private int _y;

            public int X
            {
                get { return _x; }
                set
                {
                    if (value < 0) throw new ArgumentOutOfRangeException("X не должен быть отрицательным!");
                    _x = value;
                }
            }
            public int Y
            {
                get { return _y; }
                set
                {
                    if (value < 0) throw new ArgumentOutOfRangeException("Y не должен быть отрицательным!");
                    _y = value;
                }
            }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"({_x}, {_y})";
            }
        }

        private Point _leftPoint;
        private int _width;
        private int _height;


        public int X
        {
            get => _leftPoint.X;
            set => _leftPoint.X = value;
        }

        public int Y
        {
            get => _leftPoint.Y;
            set => _leftPoint.Y = value;
        }
        public int Width
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Ширина не должна быть отрицательной");
                _width = value;
            }
        }
        public int Height
        {
            get { return _height; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Высота не должна быть отрицательной");
                _height = value;
            }
        }

        public int Square
        {
            get => _width * _height;
        }

        public int Perimeter
        {
            get => (_width + _height) / 2;
        }

        public override string ToString()
        {
            return $"Координаты: {_leftPoint}, ширина: {_width} высота: {_height}";
        }
    }
}
