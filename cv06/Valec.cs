using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cv06
{
    public class Valec : Objekt3D
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        // 
        public Valec(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public override double SpoctiPovrch()
        {
            return 2 * Math.PI * Radius * Height + 2 * Math.PI * Radius * Radius;
        }

        public override double SpoctiObjem()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override void Draw()
        {
            Console.WriteLine("{0} (radius = {1}, height = {2})", this.GetType().Name, Radius, Height);
        }
    }
}