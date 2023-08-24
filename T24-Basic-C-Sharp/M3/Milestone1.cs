using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M3
{
    internal class Milestone1
    {
        //MILESTONE 1
        //Exercici: L’exercici consisteix en mostrar per consola diferents noms de ciutats partint d’un array i modificar els noms canviant lletres.

        //FASE 1
        //  - Crea sis variables tipu string buides.
        //  - Demana per consola que s’introdueixin els noms.
        //  - Introdueix els següents noms de ciutats (Barcelona, Madrid, Valencia, Malaga, Cadis, Santander) per teclat.
        //  - Mostra per consola el nom de les 6 ciutats.
        public void Inicia()
        {
            string ciutat1;
            string ciutat2;
            string ciutat3;
            string ciutat4;
            string ciutat5;
            string ciutat6;

            Console.WriteLine("Introdueix els següents noms de ciutats (Barcelona, Madrid, Valencia, Malaga, Cadis, Santander) per teclat.");
            Console.WriteLine("\n1/6:");
            ciutat1 = Console.ReadLine();
            Console.WriteLine("\n2/6:");
            ciutat2 = Console.ReadLine();
            Console.WriteLine("\n3/6:");
            ciutat3 = Console.ReadLine();
            Console.WriteLine("\n4/6:");
            ciutat4 = Console.ReadLine();
            Console.WriteLine("\n5/6:");
            ciutat5 = Console.ReadLine();
            Console.WriteLine("\n6/6:");
            ciutat6 = Console.ReadLine();

            Console.WriteLine("\nFase 1:");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6);


            //FASE 2
            //  - Un cop tenim els noms de les ciutats guardats en variables haurem de pasar l’informacio a un array (arrayCiutats).
            //  - Quan tinguem l’array ple, haurem de mostrar per consola el nom de les ciutats ordenadas per ordre alfabetic.
            string[] arrayCiutats = { ciutat1, ciutat2, ciutat3, ciutat4, ciutat5, ciutat6 };
            Console.WriteLine("\nFase 2:");
            MostrarPerOrdreAlfabetic(arrayCiutats);

            //FASE 3
            //  - Cambieu les vocals “a” dels noms de les ciutats per el numero 4 i guardeu els noms modificats en un nou array (ArrayCiutatsModificades).
            //  - Mostreu per consola l’array modificat i ordenat per ordre alfabetic.
            string[] ArrayCiutatsModificades = ModificarVocalPer4(arrayCiutats);
            Console.WriteLine("\nFase 3:");
            MostrarPerOrdreAlfabetic(ArrayCiutatsModificades);

            //FASE 4
            //  - Creeu un nou array per cada una de les ciutats que tenim. La mida dels nous arrays sera la llargada de cada string (string nomCiutat.Length).
            //  - Ompliu els nous arrays lletra per lletra.
            //  - Mostreu per consola els nous arrays amb els noms invertits (Ex: Barcelona - anolecraB).
            string[] arrayCiutat1 = new string[ciutat1.Length];
            string[] arrayCiutat2 = new string[ciutat2.Length];
            string[] arrayCiutat3 = new string[ciutat3.Length];
            string[] arrayCiutat4 = new string[ciutat4.Length];
            string[] arrayCiutat5 = new string[ciutat5.Length];
            string[] arrayCiutat6 = new string[ciutat6.Length];

            arrayCiutat1 = OmplirLletraPerLletra(ciutat1);
            arrayCiutat2 = OmplirLletraPerLletra(ciutat2);
            arrayCiutat3 = OmplirLletraPerLletra(ciutat3);
            arrayCiutat4 = OmplirLletraPerLletra(ciutat4);
            arrayCiutat5 = OmplirLletraPerLletra(ciutat5);
            arrayCiutat6 = OmplirLletraPerLletra(ciutat6);

            Console.WriteLine("\nFase 4:");
            MostrarArrayInvertit(arrayCiutat1);
            MostrarArrayInvertit(arrayCiutat2);
            MostrarArrayInvertit(arrayCiutat3);
            MostrarArrayInvertit(arrayCiutat4);
            MostrarArrayInvertit(arrayCiutat5);
            MostrarArrayInvertit(arrayCiutat6);
        }

        public void MostrarPerOrdreAlfabetic(string[] valors)
        {
            Array.Sort(valors);

            Console.WriteLine(string.Join(", ", valors));
        }

        public string[] ModificarVocalPer4(string[] valors)
        {
            for (int i = 0; i < valors.Length; i++)
            {
                valors[i] = valors[i].Replace("a", "4");
            }

            return valors;
        }

        public string[] OmplirLletraPerLletra(string valors)
        {
            string[] arrayPerLletres = new string[valors.Length];

            for (int i = 0; i < valors.Length; i++)
            {
                arrayPerLletres[i] = valors[i].ToString();
            }

            return arrayPerLletres;
        }

        public void MostrarArrayInvertit(string[] valors)
        {
            int mida = valors.Length;

            // Array normal
            for (int i = 0; i < mida; i++)
            {
                Console.Write("{0}", valors[i]);
            }

            Console.Write(" - ");

            // Array invertido
            for (int i = 0; i < mida; i++)
            {
                Console.Write("{0}", valors[mida - i - 1]);
            }

            Console.WriteLine();
        }
    }
}
