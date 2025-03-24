using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public abstract class Objekt2D : I2D
    {
        public abstract double Plocha();
        public interface IComparable
        {
            double CompareTo(Objekt2D obj);
        }
    }
}
