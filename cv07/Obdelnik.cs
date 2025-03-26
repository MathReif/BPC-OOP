using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Obdelnik : Objekt2D
    {
        public double a { get; set; }
        public double b { get; set; }

        public Obdelnik(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double Plocha()
        {
            return a * b;
        }

        public override string ToString()
        {
            return $"(Obdelnik: lenght = {a}, width = {b} Plocha = {Plocha()})";
        }
    }
}