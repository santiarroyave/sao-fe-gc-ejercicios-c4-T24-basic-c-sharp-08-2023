using System;
using System.Collections.Generic;
using System.Linq;
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
        public void Fase1()
        {
            string ciutat1;
            string ciutat2;
            string ciutat3;
            string ciutat4;
            string ciutat5;
            string ciutat6;

            Console.WriteLine("Introdueix els següents noms de ciutats (Barcelona, Madrid, Valencia, Malaga, Cadis, Santander) per teclat.");
            ciutat1 = Console.ReadLine();
            ciutat2 = Console.ReadLine();
            ciutat3 = Console.ReadLine();
            ciutat4 = Console.ReadLine();
            ciutat5 = Console.ReadLine();
            ciutat6 = Console.ReadLine();
        }
    }
}
