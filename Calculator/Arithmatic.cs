using System;
namespace Calculator
{
    class Arithmetic
    {
        public double Add(double x, double y)
        {
            Console.Write("{0} + {1} er: ", x, y);
            Console.WriteLine("  ");

            return x + y;

        }

        public double Substract(double x, double y)
        {
            Console.Write("{0} - {1} er: ", x, y);
            Console.WriteLine("  ");
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            Console.Write("{0} * {1} er: ", x, y);
            Console.WriteLine("  ");
            return x * y;
        }

        public double Divide(double x, double y)
        {

            if(x == 0)
            {
                double total = x / y;
                Console.WriteLine("Du må ikke dividere med 0");
                Console.WriteLine("{0} / {1} er: ", x, y);
                return total;
            }else
            {
                double total = x / y;
                return total;
            }



            
            


        }
    }
}