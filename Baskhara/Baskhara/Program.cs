using System;

namespace Baskhara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, delta = 0, x1 = 0, x2 = 0;
            string entradaA = " ", entradaB = " ", entradaC = " ";
            // a, b, c são constantes da equação do 2ª grau;

            do
            {

                Console.WriteLine("Digite um valor para a: ");
                entradaA = Console.ReadLine();
                a = Convert.ToDouble(entradaA);
                Console.WriteLine("Digite um valor para b: ");
                entradaB = Console.ReadLine();
                b = Convert.ToDouble(entradaB);
                Console.WriteLine("Digite um valor para c: ");
                entradaC = Console.ReadLine();
                c = Convert.ToDouble(entradaC);

                delta = b * b - 4 * a * c;
                Console.WriteLine(delta);
                
                if (delta < 0)
                    {
                        Console.WriteLine("Não existe raiz de valor negativo dentro do conjunto dos reais.");
                        break;
                    } 
                    

                // x = (-b +- raiz de delta) / 2 * a

                x1 = (-b - Math.Round(Math.Sqrt(delta), 2)) / 2;
                x2 = (-b + Math.Round(Math.Sqrt(delta), 2)) / 2;

                Console.WriteLine("O valor de x' é: " + Math.Round(x1, 2) + ".\n" +
                    "O valor de x'' é: " + Math.Round(x2, 2) + ".");
                
            } while (a != 0 && b != 0 || c != 0);
        }
    }
}


