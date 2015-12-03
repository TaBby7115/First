using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Core
{
    public class Pyramid : IFigure
    {
        private int _square; 
        private int _heigth;
        public Pyramid(int square, int heigth)
        {
            if ((square <= 0) || (heigth <= 0))
            {
                throw new ShapeExeption("Message");
            }

            _square = square;
            _heigth = heigth;//проверка
        }
        public double ReturnVolume()
        {
            return 1 / 3.0 * _square * _heigth;
        }
    }
}
