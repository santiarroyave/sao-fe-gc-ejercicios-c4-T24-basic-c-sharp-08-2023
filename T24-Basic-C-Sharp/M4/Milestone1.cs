using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M4
{
    internal class Milestone1
    {

        //MILESTONE 1
        //Exercici:
        //L’exercici consisteix a mostrar per consola una carta d’un restaurant on afegirem diferents plats i després escollirem que volem per menjar. Un cop fet això s’haurà de calcular el preu del menjar el programa ens dirà amb quins bitllets hem de pagar.
        //Recomanacions: has de validar que les dades introduïdes per consola compleixen els requeriments de format i extensió per mitjà del control d'excepcions de C#.

        //FASE 1
        //  − Creeu una variable int per cada un dels bitllets que existeixen des de 5€ a 500€, haureu de crear un altre variable per guardar el preu total del menjar.
        //  − Creeu dos arrays, un on guardarem el menú i un altre on guardarem el preu de cada plat.
        const int BITLLET_5 = 5;
        const int BITLLET_10 = 10;
        const int BITLLET_20 = 20;
        const int BITLLET_50 = 50;
        const int BITLLET_100 = 100;
        const int BITLLET_200 = 200;
        const int BITLLET_500 = 500;

        double preuTotalMenjar;

        string[] menu = new string[5];
        double[] preuPerPlat = new double[5];

        List<string> eleccioPlats = new List<string>();

        public void Inicia()
        {
            //FASE 2
            //  - Amb un bucle for haurem d’omplir els dos arrays anteriorment creats. Afegirem el nom del plat i després el preu. Pots fer us de diccionaris de dades.
            //  - Un cop plens els dos arrays haurem de mostrar-los i preguntar que es vol per menjar, guardarem la informació en una List fent servir un bucle while.
            //  − Haurem de preguntar si es vol seguir demanant menjar. Podeu fer servir el sistema (1:Si / 0:No), per tant haureu de crear un altre variable int per guardar la informació.
            OmplirMenuPreus();
            ElegirPlats(menu.Length);

            //FASE 3
            //− Un cop hem acabat de demanar el menjar, haurem de comparar la llista amb l’array que hem fet al principi. En el cas que la informació que hem introduït a la List coincideixi amb la del array, haurem de sumar el preu del producte demanat; en el cas contrari haurem de mostrar un missatge que digui que el producte que hem demanat no existeix.
            MostrarPreu();
        }


        private void OmplirMenuPreus()
        {
            Random random = new Random();
            int minRandom = 4;
            int maxRandom = 20;

            for (int i = 0; i < menu.Length; i++)
            {
                menu[i] = $"Plat {i + 1}";
                preuPerPlat[i] = random.NextDouble() * (maxRandom - minRandom) + minRandom;
            }
        }

        public void MostrarMenu()
        {
            Console.WriteLine("Plats:");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("{0}. {1} - {2}", i + 1, menu[i], Math.Round(preuPerPlat[i], 2));
            }
        }

        public void MostrarPreu()
        {
            preuTotalMenjar = 0;

            foreach (var plat in eleccioPlats)
            {
                int i = Array.IndexOf(menu, plat);
                preuTotalMenjar += preuPerPlat[i];
            }

            Console.WriteLine("Preu total: {0} euros", Math.Round(preuTotalMenjar, 2));
        }

        private void ElegirPlats(int maxOpcion)
        {
            bool terminar = false;

            while (terminar == false)
            {
                Console.Clear();
                Console.WriteLine("Escull el numero del plat que desitges menjar");
                MostrarMenu();

                Console.WriteLine("\nPlats elegits:");
                Console.WriteLine(string.Join(", ", eleccioPlats));
                MostrarPreu();

                Console.WriteLine("\nEscriu 'ok' per acabar d'escollir.");

                string eleccio = Console.ReadLine();
                int eleccioNum;


                if (eleccio == "ok")
                {
                    terminar = true;
                }
                else
                {
                    // Si es un numero lo guarda en la variable int
                    if (int.TryParse(eleccio, out eleccioNum))
                    {
                        // Resta 1 para que coincida la eleccion con la posicion del array
                        eleccioNum -= 1;

                        // Si está dentro de los platos de la lista entra en el bucle, sino no
                        if (eleccioNum >= 0 && eleccioNum < menu.Length)
                        {
                            eleccioPlats.Add(menu[eleccioNum]);
                            Console.WriteLine("\nPlat agregat a la llista.");
                        }
                        else
                        {
                            Console.WriteLine("\nEl producte que has demanat no existeix");
                            Console.WriteLine("Prem enter per continuar...");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nValor no vàlid.");
                        Console.WriteLine("Prem enter per tornar-ho a intentar...");
                        Console.ReadLine();
                    }
                } 
            }
            Console.WriteLine("\nHas acabat d'escollir plats");
        }
    }
}
