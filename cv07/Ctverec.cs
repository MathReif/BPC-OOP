using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{ 
    public class Ctverec : Objekt2D
    {
        public double a { get; set; }

        public Ctverec(double a)
        {
            this.a = a;
        }
        public override double Plocha()
        {
            return a * a;
        }

        public override string ToString()
        {
            return $"Ctverec: (strana = {a} Plocha = {Plocha()})";

        }
    }
}