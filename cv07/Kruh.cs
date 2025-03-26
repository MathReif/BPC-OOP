using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Kruh : Objekt2D
    {
        public double radius { get; set; }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
                this.Area = Plocha();
            }
        }

        public Kruh(double radius)
        {
            this.radius = radius;
        }
        public override double Plocha()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"(Kruh: radius = {Radius} Plocha = {Plocha()})";
        }
    }
}