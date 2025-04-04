﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    
    public abstract Objekt2D : I2D,IComparable
    {
        protected double Area { get; set; }
    public abstract double Plocha();

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        if ((obj as Object2D) == null)
        {
            throw new Exception("object is not the same cannot compare ");
        }
        else if (this.Area > ((Object2D)obj).Area)
        {
            return 1;
        }
        else if (this.Area == ((Object2D)obj).Area)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

}
    }
