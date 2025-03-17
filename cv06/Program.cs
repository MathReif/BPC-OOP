using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cv06
{
    public class Program
    {
        static void Main(string[] args)
        {
            double totalArea = 0;
            double totalSurface = 0;
            double totalVolume = 0;
            Kruh circle = new Kruh(2);
            Obdelnik rectangle = new Obdelnik(2, 4);
            Elipsa ellipse = new Elipsa(2, 3);
            Trojuhelnik triangle = new Trojuhelnik(3, 2, 2);
            Kvadr cuboid = new Kvadr(2, 3, 4);
            Valec cylinder = new Valec(2, 5);
            Koule sphere = new Koule(2);
            Jehlan pyramid = new Jehlan(2, 3, 5);

            List<GrObject> objects = new List<GrObject>() {
                circle, rectangle, ellipse, triangle,
                cuboid, cylinder, sphere, pyramid
            };

            foreach (var item in objects)
            {
                item.Draw();
                if (item is Objekt2D)
                {
                    totalArea += ((Objekt2D)item).SpoctiPlochu();
                }
                else if (item is Objekt3D)
                {
                    totalSurface += ((Objekt3D)item).SpoctiPovrch();
                    totalVolume += ((Objekt3D)item).SpoctiObjem();
                }
                else
                {
                    Console.WriteLine("not 2D or 3D object");
                }
            }

            Console.WriteLine("Celkova plocha {0:F4}.\nCelkovy povrch {1:F2}.\n" +
                "Celkovy objem {2:F2}.", totalArea, totalSurface, totalVolume);
            Console.ReadLine();

        }
    }
}