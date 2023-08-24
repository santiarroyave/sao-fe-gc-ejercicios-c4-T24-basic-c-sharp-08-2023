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


            // Menú
            string[] opciones = new string[5];
            opciones[0] = "M1 - Exercici Variables, Constants i bucle For";
            opciones[1] = "M2 - Exercici Lletres Repetides";
            opciones[2] = "M3 - Exercici Noms Ciutats";
            opciones[3] = "M4 - Exercici Restaurant";
            opciones[4] = "Sortir";
            int opcionSeleccionada = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tria l'opció que vols veure:");

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == opcionSeleccionada)
                        Console.Write("-> ");
                    else
                        Console.Write("   ");

                    Console.WriteLine(opciones[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    opcionSeleccionada = (opcionSeleccionada + 1) % opciones.Length;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    opcionSeleccionada = (opcionSeleccionada - 1 + opciones.Length) % opciones.Length;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (opcionSeleccionada == opciones.Length - 1)
                    {
                        break; // Salir
                    }
                    else
                    {
                        Console.WriteLine($"\n{opciones[opcionSeleccionada]}");
                        Console.WriteLine("Prem Enter per continuar...");
                        Console.ReadLine();

                        // Llama a la función que se encargará de ejecutar el código pertinente
                        ejecutarModulo(opcionSeleccionada);                    
                    }
                }
            }
        }


        private static void ejecutarModulo(int opcion)
        {
            switch (opcion)
            {
                case 0:
                    //--------------------------------------------------------
                    // M1 - Exercici Variables, Constants i bucle For
                    //--------------------------------------------------------
                    Console.Clear();
                    M1.Program m1 = new M1.Program();
                    m1.Inicia();
                    Console.ReadLine();
                    break;
                case 1:
                    //--------------------------------------------------------
                    // M2 - Exercici Lletres Repetides
                    //--------------------------------------------------------
                    Console.Clear();
                    M2.Program m2 = new M2.Program();
                    m2.Inicia();
                    break;
                case 2:
                    //--------------------------------------------------------
                    // M3 - Exercici Noms Ciutats
                    //--------------------------------------------------------
                    Console.Clear();
                    M3.Program m3 = new M3.Program();
                    m3.Inicia();
                    Console.ReadLine();
                    break;
                case 3:
                    //--------------------------------------------------------
                    // M4 - Exercici Restaurant
                    //--------------------------------------------------------
                    Console.Clear();
                    //M4.Main m4 = new M4.Main();
                    //m4.Inicia();
                    break;
            }
        }
    }
}
