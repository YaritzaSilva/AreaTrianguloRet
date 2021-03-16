using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1;
            string entrada2;
            double Area,Base, Altura;

            Console.Beep();
            Console.WriteLine("---------");
            Console.WriteLine("Digite abaixo as medidas do triangulo, que serão calculadas");
            Console.Write("Base: ");
            entrada1 = Console.ReadLine();
            Base= Convert.ToDouble(entrada1);
            Console.Write("Altura: ");
            entrada2 = Console.ReadLine();
            Altura= Convert.ToDouble(entrada2);
            
            Area = Base*Altura/2;

            Console.Beep();
            Console.WriteLine("----------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("\n---Area---");
            Console .ResetColor ();
            Console.WriteLine($"A área é: {Area}");
            Console.WriteLine("----------");
        }
    }
}
