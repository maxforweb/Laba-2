using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    class Square
    {
        public int width;
        public double diagonal;
        public int square;
        public int perimeter;
        public double GetDiagonal(int width )
        {
            diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(width,2));
            return diagonal;
        }
        public int GetSquare(int width)
        {
            square = Convert.ToInt32(Math.Pow(width, 2));
            return square;
        }
        public int GetPerimeter (int width)
        {
            perimeter = width * 2;
            return perimeter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square X = new Square();
            Console.WriteLine("Введите длинну стороны квадрата: ");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out X.width))
                {
                    Console.WriteLine($"Диагоняль квадрата равна: {X.GetDiagonal(X.width)}");
                    Console.WriteLine($"Площадь квадрата равна: {X.GetSquare(X.width)}");
                    Console.WriteLine($"Периметр квадрата равен: {X.GetPerimeter(X.width)}" );

                    break;
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
