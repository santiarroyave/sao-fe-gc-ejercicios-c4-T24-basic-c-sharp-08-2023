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
            // Nota / indice
            // Cada módulo tiene su propio main donde se llaman a sus respectivas funciones que ejecutan cada parte del ejercicio.

            //   M1                   M2                  M3                  M4
            //    - Milestone 1        - Milestone 1       - Milestone 1       - Milestone 1
            //        - Fase 1             - Fase 1            - Fase 1            - Fase 1
            //        - Fase 2             - Fase 2            - Fase 2            - Fase 2
            //        - Fase 3             - Fase 3            - Fase 3            - Fase 3
            //        - Fase 4             - Fase 4            - Fase 4       - Milestone 2
            //    - Milestone 2       - Milestone 2       - Milestone 2       - Milestone 3
            //    - Milestone 3       - Milestone 3       - Milestone 3


            //--------------------------------------------------------
            // M1 - Exercici Variables, Constants i bucle For
            //--------------------------------------------------------
            M1.Main m1 = new M1.Main();
            m1.Inicia();

            //--------------------------------------------------------
            // M2 - Exercici Lletres Repetides
            //--------------------------------------------------------
            M2.Main m2 = new M2.Main();
            m2.Inicia();
        }
    }
}
