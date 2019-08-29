using System;
namespace Calculator
{
    class Geometry

    {
        //constants
        //double pi = Math.PI;

         public static double Triangle(double a, double b, double c)
        {
            

            //udregninger
            double s = (a + b + c) / 2;
            double areal = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            double omkreds = a + b + c;
            
            

            Console.Clear();
            
            Console.WriteLine("Omkredsen er {0}", omkreds);

            // SKAL VÆRE TIL SIDST
            Console.Write("Arealet er ");

            return areal;
        }

        public static double Sqaure(double a, double b, double c, double d)
        {

            double omkreds = a + b + c + d;
            double areal = 2 * (a + b);

            Console.Clear();

            Console.WriteLine("Arealet er {0}", areal);

            // SKAL VÆRE TIL SIDST
            Console.Write("Omkredsen er ");

            return omkreds;
        }



    }
}
