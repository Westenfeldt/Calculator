using System;
using Calculator;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu.StartMenu();
            string valg = Console.ReadLine();

            do
            {

                
                if (valg == "1")
                {
                    Arithmetic caclulator = new Arithmetic();
                    Console.WriteLine("Valg hvilken to tal du ønsker at plusse");


                    Console.WriteLine("Valg dit første nummer");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Valg dit andet nummer");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(caclulator.Add(num1, num2));

                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();

                    Menu.StartMenu();
                    valg = Console.ReadLine();
                }
                if (valg == "2")
                {
                    Arithmetic caclulator = new Arithmetic();
                    Console.WriteLine("Valg hvilken to tal du ønsker at trække fra hinanden");


                    Console.WriteLine("Valg dit første nummer");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Valg dit andet nummer");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(caclulator.Substract(num1, num2));

                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();

                    Menu.StartMenu();
                    valg = Console.ReadLine();
                }
                if (valg == "3")
                {
                    Arithmetic caclulator = new Arithmetic();
                    Console.WriteLine("Valg hvilken to tal du ønsker at trække fra hinanden");


                    Console.WriteLine("Valg dit første nummer");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Valg dit andet nummer");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(caclulator.Multiply(num1, num2));

                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();

                    Menu.StartMenu();
                    valg = Console.ReadLine();
                }
                if (valg == "4")
                {
                    Console.Clear();
                    Arithmetic caclulator = new Arithmetic();
                    Console.WriteLine("Valg hvilken to tal du ønsker at divideré fra hinanden");


                    Console.WriteLine("Valg dit første nummer");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Valg dit andet nummer");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(caclulator.Divide(num1, num2));

                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();

                    Menu.StartMenu();
                    valg = Console.ReadLine();

                }
                if (valg == "5")
                {
                    Geometry geometry = new Geometry();

                    Console.WriteLine("Du ønsker information omkring din trekant. Indtast siderne a, b og c");
                    Console.WriteLine("Indtast a:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indtast b:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indtast c:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    //Kan bruges til udvide med vinkle beregning.
                    //Console.WriteLine("Indtast siden A:");
                    //double A = Convert.ToDouble(Console.ReadLine());
                    //Console.WriteLine("Indtast siden B:");
                    //double B = Convert.ToDouble(Console.ReadLine());
                    //Console.WriteLine("Indtast siden C:");
                    //double C = Convert.ToDouble(Console.ReadLine());
                    

                    Console.WriteLine(Calculator.Geometry.Triangle(a, b, c));

                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();

                    Menu.StartMenu();
                    valg = Console.ReadLine();









                }
                if (valg == "6")
                {
                    Geometry geometry = new Geometry();

                    Console.WriteLine("Du ønsker information omkring din firkant. Indtast siderne a, b, c og d");
                    Console.WriteLine("Indtast a:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indtast b:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indtast c:");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indtast d:");
                    double d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(Calculator.Geometry.Sqaure(a, b, c, d));

                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();

                    Menu.StartMenu();
                    valg = Console.ReadLine();

                }

            } while (valg != "9");
            Console.WriteLine("Du har valgt at lukke lommeregneren");









        }
    }
}
