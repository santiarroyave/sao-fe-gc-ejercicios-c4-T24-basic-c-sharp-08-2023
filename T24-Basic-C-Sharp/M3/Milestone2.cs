using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M3
{
    internal class Milestone2
    {
        //MILESTONE 2
        //Exercici: En aquest exercici crearàs un array bidimensional on introduiràs 3 notes per a 5 alumnes.Es calcularà la nota mitjana de cada alumna i s'indicarà si han suspès o no.
        //  - Crea un array bidimensional capaç de guardar 3 notes de 5 alumnes.
        //  - Omple l’array amb un bucle demanant els valors per pantalla (nota entre 0 i 10), has d’identificar per pantalla quan és una agrupació d’un alumne nou.
        //  - Recorre l'array, fes la Mitjana aritmètica de les 3 notes i indica si l'alumne ha aprovat o suspès

        double[,] notesAlumnes = new double[5, 3];

        public void Inicia()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Alumne {0}: \n", i + 1);

                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingressa la nota {0}: ", j + 1);
                    double nota;

                    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
                    {
                        Console.Write("Has d'introduir una nota vàlida (entre 0 y 10): ");
                    }

                    notesAlumnes[i, j] = nota;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Notes dels alumnes:");
            for (int i = 0; i < 5; i++)
            {
                double sumaNotes = 0;
                double mitjana = 0;

                Console.Write("Alumne {0}: \n", i + 1);
                Console.Write("- Notes: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(notesAlumnes[i, j] + " ");
                    sumaNotes += notesAlumnes[i, j];
                }

                mitjana = sumaNotes / 3;

                Console.WriteLine();
                Console.Write("- Mitjana: {0}", mitjana.ToString("F2"));
                if (mitjana >= 5)
                {
                    Console.WriteLine(" (Aprovat)");
                }
                else
                {
                    Console.WriteLine(" (Suspès)");
                }
                Console.WriteLine();
            }
        }
    }
}
