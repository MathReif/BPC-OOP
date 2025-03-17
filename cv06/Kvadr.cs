using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cv06
{
    public class Kvadr : Objekt3D
    {

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Kvadr(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double SpoctiPovrch()
        {
            return 2 * ((a*b)+(b*c)+(a*c));
        }

        public override double SpoctiObjem()
        {
            return a * b * c;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (a = {1}, b = {2}, c = {3})", this.GetType().Name, a, b, c);
        }
    }
}