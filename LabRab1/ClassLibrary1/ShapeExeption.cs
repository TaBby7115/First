using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ShapeExeption : System.Exception
    {
        public ShapeExeption(string message): base(message)
        {
        }
    }
}
