using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M3
{
    internal class Main
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
            Milestone1 Milestone1 = new Milestone1();

            // - FASE 1
            Console.WriteLine("\n## Fase 1");
            Milestone1.Fase1();
        }
    }
}
