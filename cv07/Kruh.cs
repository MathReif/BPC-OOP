using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Kruh :Objekt2D
    {
        public double radius { get; set; }
        
        public Kruh(double radius)
        {
            this.radius = radius;
        }

        public override double Plocha()
        {
            return 2*radius*Math.PI;
        }

        public override string ToString()
        {
            return $"{Plocha()}";
        }
    }
}
