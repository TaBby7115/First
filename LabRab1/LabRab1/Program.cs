using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HeadForm());
            try
            {
                List<IFigure> figure = new List<IFigure>();
                figure.Add(new Parallelepiped(2, 4, 6));
                figure.Add(new Pyramid(2, 4));
                figure.Add(new Sphere(5));
                foreach (IFigure fig in figure)
                {
                    Console.WriteLine(fig.ReturnVolume());
                }
            }

            catch (ShapeExeption e)
            {
               System.Console.WriteLine(e.Message);
            }
            Console.ReadLine();

        }
    }
}
