using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

class Complex
{

    public double Real;
    public double Imaginary;

    public Complex(double real = 0.0, double imaginary = 0.0)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex(a.Real +b.Real, a.Imaginary +b.Imaginary);
    }

    public static Complex operator -(Complex a, Complex b)
    {
        return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static Complex operator -(Complex a)
    {
        return new Complex(-a.Real, -a.Imaginary);
    }

    public static Complex operator *(Complex a, Complex b)
    {
        return new Complex(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
    }
    public static Complex operator /(Complex a, Complex b)
    {
       double jmenovatel = b.Real * b.Real + b.Imaginary * b.Imaginary;
       double vyslRealna =(a.Real * b.Real + a.Imaginary *b.Imaginary) / jmenovatel;
        double vyslImaginarni = (a.Imaginary * b.Real - a.Real * b.Imaginary) / jmenovatel;
        return new Complex(vyslRealna, vyslImaginarni);
    }
    public static bool operator ==(Complex a, Complex b)
    {
        return a.Real == b.Real && a.Imaginary == b.Imaginary;
    }

    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        if (Imaginary < 0)
        {
            return string.Format("{0}-{1}j", Real, -Imaginary);
        }
        else
        {
            return string.Format("{0}+{1}j", Real, Imaginary);
        }    
    }
    public Complex Zdruzene()
    {
        return new Complex(Real, -Imaginary);
    }

    public double Modul()
    {
        return Math.Sqrt(Real * Real + Imaginary * Imaginary);
    }

    public double Argument()
    {
        return Math.Atan2(Imaginary, Real);
    }

}