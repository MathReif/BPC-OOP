using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cv06
{
    public class Koule : Objekt3D
    {
        public double Radius { get; set; }

        public Koule(double radius)
        {
            this.Radius = radius;
        }
        public override double SpoctiPovrch()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public override double SpoctiObjem()
        {
            return 4 / 3 * Math.PI * Radius * Radius * Radius;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (radius = {1})", this.GetType().Name, Radius);
        }
    }
}