using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    
    class SquareObj
    {
        int width;
        string title;
        public SquareObj()
        {
        }
        public SquareObj(int width)
        {
            Width = width;
        }
        public SquareObj(int width, string title)
        {
            this.title = title;
            Width = width;
        }
        public double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(width, 2));
        }
        public int GetSquare()
        {
            return width * width;
        }
        public int GetPerimeter()
        {
           return width * 4;
        }
        override public string ToString()
        {
            Console.WriteLine(this.Title);
            return this.Title + "\nwidth: " + this.Width +
           "\ndiagonal: " + this.GetDiagonal() +
           "\nperimeter: " + this.GetPerimeter() +
           "\nsquare: " + this.GetSquare() + "\n\n";
        }
        
        public int Width { get => width; set => width = value >= 0 ? value : 0; }
        public string Title { get => title; set => title = value; }
    }

    
}
