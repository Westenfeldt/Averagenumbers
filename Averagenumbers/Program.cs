using System;

namespace Averagenumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabler
            string num1, num2, num3;

            Console.WriteLine("Skriv 3 tal");

            num1 = Console.ReadLine();
            num2 = Console.ReadLine();
            num3 = Console.ReadLine();

            Console.WriteLine("Du har valgt disse tal: {0} , {1} , {2}", num1, num2, num3);

            double number1 = float.Parse(num1);
            double number2 = float.Parse(num2);
            double number3 = float.Parse(num3);

            // udregning

            double gennemsnit;

            gennemsnit = (number1 + number2 + number3) / 3;

            Console.WriteLine("Gennemsnittet af dine valgte tal er: {0}", gennemsnit);



        }
    }
}
