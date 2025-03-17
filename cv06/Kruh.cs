using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Kruh : Objekt2D
    {
        public double Radius { get; set; }

        public Kruh(double radius)
        {
            this.Radius = radius;
        }
        public override double SpoctiPlochu()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (radius = {1})", this.GetType().Name, Radius);
        }
    }
}
