using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T24_Basic_C_Sharp.M2
{
    internal class Milestone1
    {
        //MILESTONE 1
        //Exercici: L’exercici consisteix en mostrar per consola quantes vegades apareix cada lletra del teu nom i cognoms amb diferents variants(fases).

        //FASE 1
        //  - Crea una taula(char[]) amb el teu nom on cada posició correspongui a una lletra.
        //  − Fes un bucle que recorri aquesta taula i mostri per consola cadascuna de les lletres.
        public void Fase1()
        {
            char[] nom = { 'S', 'a', 'n', 't', 'i', 'a', 'g', 'o' };

            foreach (var lletra in nom)
            {
                Console.Write(lletra + " ");
            }
            Console.WriteLine();
        }

        //FASE 2
        //  − Canvia la taula per una llista(List<Character>)
        //  − Al bucle, si la lletra és una vocal imprimeix a la consola: ‘VOCAL’. Sinó, imprimeix: ‘CONSONTANT’.
        //  − Si trobes un numero, mostra per pantalla: ‘Els noms de persones no contenen números!’.
        public void Fase2()
        {
            List<char> nom = new List<char> { 'S', 'a', 'n', 't', 'i', 'a', 'g', 'o' };

            foreach (var lletra in nom)
            {
                if (Char.IsLetter(lletra))
                {
                    if ("aeiouAEIOU".Contains(lletra))
                    {
                        Console.WriteLine(lletra + " - " + "VOCAL");
                    }
                    else
                    {
                        Console.WriteLine(lletra + " - " + "CONSONANT");
                    }
                }

                if (Char.IsDigit(lletra))
                {
                    Console.WriteLine("Els noms de persones no contenen números!");
                }
            }
        }

        //FASE 3
        //  − Emmagatzemar en un Map tant les lletres de la llista com el nombre de vegades que apareixen.
        public void Fase3()
        {
            List<char> nom = new List<char> { 'S', 'a', 'n', 't', 'i', 'a', 'g', 'o' };
            Dictionary<char, int> frequenciaLletres = new Dictionary<char, int>();

            foreach (var lletra in nom)
            {
                if (Char.IsLetter(lletra))
                {
                    if (frequenciaLletres.ContainsKey(char.ToLower(lletra)))
                    {
                        frequenciaLletres[char.ToLower(lletra)]++;
                    }
                    else
                    {
                        frequenciaLletres.Add(char.ToLower(lletra), 1);
                        
                        //// Otra opción de añadir valores, cuando no existe en el map se crea un nuevo valor en esa clave
                        //frequenciaLletres[char.ToLower(lletra)] = 1; 
                    }
                }
            }

            foreach (var lletra in frequenciaLletres)
            {
                Console.WriteLine(lletra);
            }
        }

        //FASE 4
        //  − Crea una altra llista amb el teu cognom on cada posició correspongui a una lletra.
        //  − Fusiona les dues llistes en una sola. A més, afegeix una posició amb un espai buit entre la primera i la segona. És a dir, partim de la llista name i surname i al acabar l’execució només tindrem una que es dirà fullName.
        //  FullName: [‘N ’, ‘A’, ‘M’, ‘E’, ‘ ‘, ‘S’, ‘U ’, ‘R ‘, ‘N’, ‘A’, ‘M’, ‘E’]
        public void Fase4()
        {
            List<char> name = new List<char> { 'S', 'a', 'n', 't', 'i', 'a', 'g', 'o' };
            List<char> surname = new List<char> { 'A', 'r', 'r', 'o', 'y', 'a', 'v', 'e' };

            List<char> fullName = new List<char>(name);
            fullName.Add(' ');
            fullName.AddRange(surname);

            name.Clear();
            name.Clear();

            foreach (char lletra in fullName)
            {
                Console.Write(lletra);
            }
            Console.WriteLine();
        }

    }
}
