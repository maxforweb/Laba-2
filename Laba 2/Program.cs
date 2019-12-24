using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            string title = "";

            Console.WriteLine("Введите длинну стороны квадрата: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out width))
                {
                    SquareObj newSquare = new SquareObj(width);
                    Console.WriteLine( newSquare.ToString());
                    break;
                }
                else if (width <= 0)
                {
                    Console.WriteLine("Ввеенная сторона квадрата должа быть больше 0");
                }
                else
                {
                    Console.WriteLine("Введенное знаечние не является числом! повторите ввод:");
                }
            }

            Console.WriteLine("\n Введите высоту для вычисления квадратной призмы: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out height))
                {
                    SquarePrism newPrism = new SquarePrism(height, width, title);
                    Console.WriteLine(newPrism.ToString());
                    break;
                }
                else if (height <= 0)
                {
                    Console.WriteLine("Ввеенная сторона квадрата должа быть больше 0");
                }
                else
                {
                    Console.WriteLine("Введенное знаечние не является числом! повторите ввод:");
                }
            }



            Console.ReadKey();

        }
    }
}
