using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
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
        public override double SpoctiPlochu()
        {
            return Math.PI * RadiusA * RadiusB;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (radiusA = {1}, radiusB = {2})", this.GetType().Name, RadiusA, RadiusB);
        }
    }
}
