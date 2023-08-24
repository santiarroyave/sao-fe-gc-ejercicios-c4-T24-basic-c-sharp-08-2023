using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M4
{
    internal class Milestone2
    {
        //MILESTONE 2
        //Exercici: Revisaràs l'exercici anterior modificant-lo per afegir noves excepcions més adients.

        //FASE 1
        //  − Modifica la revisió de la comanda, si un usuari introdueix un plat que no existeix, inmediatament executa una excepció per avisar que el producte no existeix y no l’afageixis a la llista.
        //  − Crea una Excepció per la pregunta Si/No al seguir demanant e implementala.
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
            OmplirMenuPreus();
            ElegirPlats(menu.Length);
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
                    try
                    {
                        // Si es un numero lo guarda en la variable int
                        eleccioNum = int.Parse(eleccio);

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
                    catch
                    {
                        Console.WriteLine("\nEl producte que has demanat no existeix");
                        Console.WriteLine("Prem enter per tornar-ho a intentar...");
                        Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("\nHas acabat d'escollir plats");
        }
    }
}
