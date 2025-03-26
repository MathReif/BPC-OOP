using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{

    public class Trojuhelnik : Objekt2D
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Trojuhelnik(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        public override double Plocha()
        {

            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public override string ToString()
        {
            return $"(Trojuhelnik: sideA = {SideA}, sideB = {SideB}, sideC = {SideC} Plocha = {Plocha()})";
        }
    }
}