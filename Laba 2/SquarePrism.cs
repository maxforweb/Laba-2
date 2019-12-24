using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_2
{
    class SquarePrism: SquareObj 
    {

        public int height;
        public int volume;

        public SquarePrism(int height, int width, string title) 
        {
            base.Width = width;
            base.Title = title;
            Height = height;
        }
        public int VolumeOfPrism()
        {
            volume = Width * Width * this.height;
            return volume;
        }

        new public int GetSquare()
        {
            return Width * Width * 6;
        }

        new public string ToString()
        {
            return this.Title + "\nwidth: " + this.Width +
            "\nheight: " + this.height +
            "\nsquare: " + this.GetSquare() +
            "\nvolume: " + this.VolumeOfPrism();
        }

        public int Height { get => height; set => height = value >= 0 ? value : 0; }
    }
}
