using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cv07
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 7, 9 };
            Kruh[] kruhArr = new Kruh[] { new Kruh(4), new Kruh(5), new Kruh(1) };
            Elipsa[] elipsaArr = new Elipsa[] { new Elipsa(5, 1), new Elipsa(7, 5), new Elipsa(5, 6), new Elipsa(2, 8) };
            Obdelnik[] obdelnikArr = new Obdelnik[] { new Obdelnik(5, 6), new Obdelnik(2, 1), new Obdelnik(1, 5) };
            Ctverec[] ctverecArr = new Ctverec[] { new Ctverec(5), new Ctverec(17), new Ctverec(12), new Ctverec(8) };
            Trojuhelnik[] trojuhelnikArr = new Trojuhelnik[] { new Trojuhelnik(11, 4, 8), new Trojuhelnik(5, 6, 10), new Trojuhelnik(6, 4, 7) };
            Objekt2D[] object2DArr = new Objekt2D[] { new Kruh(5), new Elipsa(5, 1), new Obdelnik(5, 6), new Ctverec(5), new Trojuhelnik(11, 4, 8), };

            Console.WriteLine("Najvacsie a najmensie Kruhy");
            Console.WriteLine(ArrToString(Extremy.Biggest(kruhArr).ToArray()));
            Console.WriteLine(ArrToString(Extremy.Smallest(kruhArr).ToArray()));

            Console.WriteLine("\nNajvacsie a najmensie Elipsy");
            Console.WriteLine(ArrToString(Extremy.Biggest(elipsaArr).ToArray()));
            Console.WriteLine(ArrToString(Extremy.Smallest(elipsaArr).ToArray()));

            Console.WriteLine("\nNajvacsie a najmensie Obdelniky");
            Console.WriteLine(ArrToString(Extremy.Biggest(obdelnikArr).ToArray()));
            Console.WriteLine(ArrToString(Extremy.Smallest(obdelnikArr).ToArray()));

            Console.WriteLine("\nNajvacsie Stvorce");
            Console.WriteLine(ArrToString(Extremy.Biggest(ctverecArr).ToArray()));
            Console.WriteLine("\nNajmensie Stvorce");
            Console.WriteLine(ArrToString(Extremy.Smallest(ctverecArr).ToArray()));

            Console.WriteLine("\nNajvacsie a najmensie Trojuholniky");
            Console.WriteLine(ArrToString(Extremy.Biggest(trojuhelnikArr).ToArray()));
            Console.WriteLine(ArrToString(Extremy.Smallest(trojuhelnikArr).ToArray()));

            Console.WriteLine("\nNajvacsie a najmensie");
            Console.WriteLine(ArrToString(Extremy.Biggest(object2DArr).ToArray()));
            Console.WriteLine(ArrToString(Extremy.Smallest(object2DArr).ToArray()));

            Console.WriteLine("\nNajvacsi a najmensi integer");
            Console.WriteLine(ArrToString(Extremy.Biggest(arr).ToArray()));
            Console.WriteLine(ArrToString(Extremy.Smallest(arr).ToArray()));

            Console.WriteLine("Filtered values");
            Console.WriteLine(ArrToString(arr.Where(e => e > 4 && e < 8).ToArray()));
            Console.ReadLine();
        }

        // help method for return string with array
        public static string ArrToString(Array list)
        {
            string ret = "";

            foreach (var item in list)
            {
                if (ret.Equals(""))
                {
                    ret = ret + item.ToString();
                }
                else
                {
                    ret = ret + "\n" + item.ToString();
                }
            }

            return ret;
        }
    }
}