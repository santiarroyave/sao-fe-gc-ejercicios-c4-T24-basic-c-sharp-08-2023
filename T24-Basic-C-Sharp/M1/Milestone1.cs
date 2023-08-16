using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace T24_Basic_C_Sharp.M1
{
    internal class Milestone1
    {
        //MILESTONE 1

        //FASE 1
        //  − Crea tres variables string e inicialitzales amb les dades pertinents(nom, cognom1, cognom2).
        //  − Crea tres variables int e inicialitzales amb les dades pertinents (dia, mes, any).
        //  − Mostra per pantalla les variables string concatenant-les en aquest ordre(cognom1 + cognom2, + nom).
        //  − Mostra per pantalla les variables int concatenant-les amb “/” entre cada una d’elles.
        public void Fase1()
        {
            string nom = "Santi";
            string cognom1 = "Arroyave";
            string cognom2 = "O.";

            int dia = 16;
            int mes = 8;
            int any = 2023;

            Console.WriteLine("{0} {1} {2}", cognom1, cognom2, nom);
            Console.WriteLine("{0}/{1}/{2}", dia, mes, any);
        }

        //FASE 2
        //  − Sabent que l’any 1948 es un any de traspàs:
        //  − Creeu una constant amb el valor de l’any (1948).
        //  − Creeu una variable que guardi cada quan hi ha un any de traspàs.
        //  − Calculeu quants anys de traspàs hi ha entre 1948 i el vostre any de naixement i emmagatzemeu el valor resultant en una variable.
        //  − Mostreu per pantalla el resultat del càlcul.
        public void Fase2()
        {
            const int ANYTRASPAS = 1948;
            int frequencia = 4;
            int anyNaixement = 1998;

            int quantitatAnysTraspas = (anyNaixement - ANYTRASPAS) / frequencia;

            Console.WriteLine("Entre el {0} i el {1} hi ha {2} anys de traspàs.", ANYTRASPAS, anyNaixement, quantitatAnysTraspas);
        }

        //FASE 3
        //  − Partint de l’any 1948 heu de fer un bucle for i mostrar els anys de traspàs fins arriba al vostre any de naixement.
        //  − ATENCIO! Haureu de canviar el tipus de variable de l’any 1948 per poder modificar-la.
        //  − Creeu una variable bool que sera certa si l’any de naixement és de traspàs o falsa si no ho és.
        //  − En cas de que la variable bool sigui certa, heu de mostrar per consola una frase on ho digui, en cas de ser falsa mostrareu la frase pertinent. Creeu dues variables string per guardar les frases.
        public void Fase3()
        {
            const int ANYTRASPAS = 1948;
            int anyNaixement = 1998;
            bool? anyNaixementEsDeTraspas = null;
            List<int> anysTraspas = new List<int>();
            string fraseEsTraspas = "L'any de naixement es un any de traspàs";
            string fraseNoEsTraspas = "L'any de naixement no es un any de traspàs";

            for (int i = ANYTRASPAS; i <= anyNaixement; i++)
            {
                if (i % 4 == 0)
                {
                    anysTraspas.Add(i);
                }

                if (anyNaixement % 4 == 0)
                {
                    anyNaixementEsDeTraspas = true;
                }
                else
                {
                    anyNaixementEsDeTraspas = false;
                }
            }
            Console.WriteLine("Anys de traspàs entre el {0} i el {1}:", ANYTRASPAS, anyNaixement);
            Console.WriteLine(string.Join(", ", anysTraspas));
            if (anyNaixementEsDeTraspas == true)
            {
                Console.WriteLine(fraseEsTraspas);
            }
            else
            {
                Console.WriteLine(fraseNoEsTraspas);
            }
        }

        //FASE 4
        //  − Creeu una variable on juntareu el nom i els cognoms (tot en una variable) i un altre on juntareu la data de naixement separada per “/” (tot en una variable). Mostreu per consola les variables del nom complet, la data de naixement i si l’any de naixement es de traspàs o no.
        // Exemple de sortida per consola:
        //  El meu nom és Juan Perez Gonzalez
        //  Vaig néixer el 01 / 01 / 1979
        //  El meu any de naixement és de traspàs
        public void Fase4()
        {
            string nom = "Santi";
            string cognom1 = "Arroyave";
            string cognom2 = "O.";
            string espacio = " ";

            int dia = 5;
            int mes = 3;
            int any = 1998;
            string barra = "/";

            string nomCognoms = nom + espacio + cognom1 + espacio + cognom2;
            string dataCompleta = dia + barra + mes + barra + any;

            int anyNaixement = 1998;
            string fraseAnyNaixement;

            if (anyNaixement % 4 == 0)
            {
                fraseAnyNaixement = "El meu any de naixement és de traspàs";
            }
            else
            {
                fraseAnyNaixement = "El meu any de naixement no és de traspàs";
            }

            Console.WriteLine("El meu nom es {0}", nomCognoms);
            Console.WriteLine("Vaig nèixer el {0}", dataCompleta);
            Console.WriteLine(fraseAnyNaixement);
        }
    }
}
