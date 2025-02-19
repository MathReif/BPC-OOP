using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestComplex
{
    const double epsilon = 1E-6;

    public static void Test(Complex skutecna, Complex ocekavana, string nazev)
    {
        if (Math.Abs(skutecna.Real - ocekavana.Real) < epsilon &&
            Math.Abs(skutecna.Imaginary - ocekavana.Imaginary) < epsilon)
        {
            Console.WriteLine("test {0}: OK", nazev);
        }
        else
        {
            Console.WriteLine("Test {0}: Chyba: Ocekavana hodnota {1},skutecna {2}", nazev, ocekavana, skutecna);
        }
    }
}
