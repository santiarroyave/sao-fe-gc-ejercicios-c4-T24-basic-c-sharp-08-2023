using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M2
{
    internal class Main
    {
        public void Inicia()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("##################################################");
            Console.WriteLine("#                                                #");
            Console.WriteLine("# M2 - Exercici Lletres Repetides                #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("##################################################\n");

            // - MILESTONE 1
            Console.WriteLine("MILESTONE 1");
            Console.WriteLine("--------------------------------------------------");
            Milestone1 Milestone1 = new Milestone1();

            // - FASE 1
            Console.WriteLine("\n## Fase 1");
            Milestone1.Fase1();

            // - FASE 2
            Console.WriteLine("\n## Fase 2");
            Milestone1.Fase2();

            // - FASE 3
            Console.WriteLine("\n## Fase 3");
            Milestone1.Fase3();

            // - FASE 4
            Console.WriteLine("\n## Fase 4");
            Milestone1.Fase4();

            // - MILESTONE 2
            Console.WriteLine("MILESTONE 2");
            Console.WriteLine("--------------------------------------------------");
            Milestone2 Milestone2 = new Milestone2();

            // - Escalera de valores
            Console.WriteLine("\n## Part 1");
            Milestone2.Inicia1();

            // - Piramide invertida
            Console.WriteLine("\n## Part 2");
            Milestone2.Inicia2();
        }
    }
}
