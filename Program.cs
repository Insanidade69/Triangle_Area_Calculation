using System;
using System.Globalization;

namespace Aulas
{
    class Program
    {
        
        static void Main()
        {
            Triangle x, y; //Decalro variaveis do tipo criado da classe
            x = new Triangle(); //instancia da variavel (obejto X)
            y = new Triangle(); //instancia da variavel (objeto Y)

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-= Triangle Area Calculation =-=-=-=-=-=-=-=-=-=-");

            Console.WriteLine("Type three values of A: (One value per line)");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //atributo a
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //atributo b
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //atributo c

            Console.WriteLine("Type three values of A: (One value per line)");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("The value of area X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("The value of area Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            if (areaX > areaY)
            {
                Console.WriteLine("The bigger area is X.");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("The bigger area is Y.");
            }
            else
            {
                Console.WriteLine("The areas is equals.");
            }

        }
    }
}