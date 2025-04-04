﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Obdelnik : Objekt2D
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public Obdelnik(double lenght, double width)
        {
            this.Lenght = lenght;
            this.Width = width;
        }
        public override double SpoctiPlochu()
        {
            return Lenght * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (lenght = {1}, width = {2})", this.GetType().Name, Lenght, Width);
        }
    }
}
