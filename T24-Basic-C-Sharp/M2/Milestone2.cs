using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M2
{
    internal class Milestone2
    {
        //MILESTONE 2
        //Exercici: En aquest exercici practicaràs diversos bucles anidats.

        //  − Crea una aplicació que dibuixi una escala de nombres, sent cada línia nombres començant en un i acabant en el nombre de la línia. Aquest és un exemple, si introduïm un 5 com a alçada:
        public void Inicia1()
        {
            Console.WriteLine("De quina mida vols la escala de nombres?");
            int mida = int.Parse(Console.ReadLine());

            for (int i = 0; i < mida; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        //  − Crea una aplicació que dibuixi una piràmide invertida de asteriscs. Nosaltres li vam passar l'altura de la piràmide per teclat. Aquest és un exemple:
        public void Inicia2()
        {
            Console.WriteLine("De quina mida vols la piràmide invertida?");
            int mida = int.Parse(Console.ReadLine());
            int altura = (mida + 1) / 2;

            for (int i = 0; i < altura; i++)
            {
                //Pone espacios al principio
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                //Pone asteriscos
                for (int j = 0; j < (mida - (2*i)); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
