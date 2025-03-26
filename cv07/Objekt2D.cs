using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cv07
{

    public abstract class Objekt2D : I2D,IComparable
    {
        protected double Area { get; set; }
        public abstract double Plocha();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            else if (this.Plocha() > ((Objekt2D)obj).Plocha())
            {
                return 1;
            }
            else if (this.Plocha() < ((Objekt2D)obj).Plocha())
            {
                return -1;
            }
            else
            {       
                return 0;
            }
        }
    }
}
