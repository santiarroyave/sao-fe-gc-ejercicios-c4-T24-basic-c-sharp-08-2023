using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M3
{
    internal class Milestone3
    {
        //MILESTONE 3
        //Exercici: Escriviu un programa que donat un numero N retorni la seqüència de Fibonacci fins al numero N. La seqüència de Fibonacci és la sèrie de nombres: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ... El número següent es troba sumant els dos números anteriors.

        public void Inicia()
        {
            Console.WriteLine("Ingressa un número:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSeqüència de Fibonacci fins al número {0}", n);
            MostrarSequenciaFibbonacci(n);
        }

        public void MostrarSequenciaFibbonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (a <= n)
            {
                Console.Write("{0} ", a);
                int c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine();
        }
    }
}
