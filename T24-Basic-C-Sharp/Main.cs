using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T24_Basic_C_Sharp.M1;

namespace T24_Basic_C_Sharp
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            //--------------------------------------------------------
            // M1 - Exercici Variables, Constants i bucle For
            //--------------------------------------------------------
            // - MILESTONE 1
            Console.WriteLine("MILESTONE 1\n-----------------------------------------");
            Milestone1 milestone1 = new Milestone1();
            // - FASE 1
            Console.WriteLine("\n(Fase 1)");
            milestone1.Fase1();
            // - FASE 2
            Console.WriteLine("\n(Fase 2)");
            milestone1.Fase2();
            // - FASE 3
            Console.WriteLine("\n(Fase 3)");
            milestone1.Fase3();
            // - FASE 4
            Console.WriteLine("\n(Fase 4)");
            milestone1.Fase4();

            // - MILESTONE 2
            Console.WriteLine("\nMILESTONE 2\n-----------------------------------------");
            Milestone2 milestone2 = new Milestone2();
            milestone2.Inicia();
        }
    }
}
