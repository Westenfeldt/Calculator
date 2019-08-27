using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Math caclulator = new Math();
            Console.WriteLine("Velkommen til lommeregneren");
            Console.WriteLine("Ønsker du at plusse to tal tryk: 1");
            Console.WriteLine("Ønsker du at minus to tal tryk: 2");



            string valg = Console.ReadLine();

            if (valg == "1")
            {
                Console.WriteLine("Valg hvilken two tal du ønsker at plusse");


                       Console.WriteLine("Valg dit første nummer");
                     double num1 = Convert.ToDouble(Console.ReadLine());
                      Console.WriteLine("Valg dit første nummer");
                      double num2 = Convert.ToDouble(Console.ReadLine());

                      Console.Write("{0} + {1} er: ", num1, num2);
                       Console.WriteLine(caclulator.Add(num1, num2));
            }
            if (valg == "2")
            {
                Console.WriteLine("Valg hvilken two tal du ønsker at trække fra hinanden");


                Console.WriteLine("Valg dit første nummer");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valg dit første nummer");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("{0} - {1} er: ", num1, num2);
                Console.WriteLine(caclulator.Substract(num1, num2));
            }


            //Valg af ønsket matematik


            // Console.WriteLine(caclulator.Add(valg, 2));

            //int tal1, tal2;






        }
    }
}
