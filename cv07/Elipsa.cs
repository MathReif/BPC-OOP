using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Elipsa : Objekt2D
    {
        public double RadiusA { get; set; }
        public double RadiusB { get; set; }

        public Elipsa(double radiusA, double radiusB)
        {
            this.RadiusA = radiusA;
            this.RadiusB = radiusB;

        }
        public override double Plocha()
        {
            return Math.PI * RadiusA * RadiusB;
        }

        public override string ToString()
        {
            return $"(Elipsa: radiusA = {RadiusA}, radiusB = {RadiusB} Plocha = {Plocha()})";
        }
    }
}