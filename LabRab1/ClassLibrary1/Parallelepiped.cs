using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Core
{
    public class Parallelepiped : IFigure
    {
        private int _a;
        private int _b;
        private int _c;

        public Parallelepiped(int a, int b, int c)
        {
            if ((a <= 0) || (b <= 0) || (c <= 0))
            {
                throw new ShapeExeption("Размер стороны должен быть больше нуля");
            }
            _a = a;
            _b = b;
            _c = c;

        }
        public double ReturnVolume()
        {
            return _a * _b * _c;
        }
    }
}
