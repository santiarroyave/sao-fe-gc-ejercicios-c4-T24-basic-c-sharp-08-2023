using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M3
{
    internal class Program
    {
        public void Inicia()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine("#                                                #");
            Console.WriteLine("# M3 - Exercici Noms Ciutats                     #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("##################################################\n");

            // - MILESTONE 1
            Console.WriteLine("MILESTONE 1");
            Console.WriteLine("--------------------------------------------------");
            Milestone1 milestone1 = new Milestone1();
            milestone1.Inicia();

            // - MILESTONE 1
            Console.WriteLine("MILESTONE 2");
            Console.WriteLine("--------------------------------------------------");
            Milestone2 milestone2 = new Milestone2();
            milestone2.Inicia();

            Console.ReadLine();
        }
    }
}
