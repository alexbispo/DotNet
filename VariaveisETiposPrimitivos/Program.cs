using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisETiposPrimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1 =====================================================
            int idadeLeticia = 25;
            int idadeAlex = 26;
            int idadeMarinalva = 16;
            int idadeWellington = 25;
            Console.WriteLine("A média é: " + (idadeLeticia + idadeAlex + idadeMarinalva + idadeWellington) /4);
            
            // Exercicio 2 ====================================================
            //int pi = 3.14; Não compila

            // Exercicio 3 =======================================================
            double pi = 3.14;
            int piQuebrado = (int)pi;
            Console.WriteLine("piQuebrado = "+ piQuebrado);

            
            // Exercicio 4 ======================================================
            int a = 10;
            int b = 15;
            int c = 12;

            double delta;
            double a1;
            double a2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b + Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(a1 +", " + a2 );

            Console.ReadLine();
        }
    }
}
