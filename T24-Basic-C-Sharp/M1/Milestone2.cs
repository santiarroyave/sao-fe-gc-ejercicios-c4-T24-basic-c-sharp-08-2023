using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M1
{
    internal class Milestone2
    {
        //MILESTONE 2
        //  − Declara una variable double. Assigna-li un valor amb 4 decimals.
        //  − Declara variables de tipus: int, float i string.
        //  − Fes un "cast" de la variable double a cada una de les variables que has creat anteriorment per inicialitzar-les i pinta-les per pantalla.


        public void Inicia()
        {
            double numero = 4.5624;

            int casting1 = (int)numero;
            float casting2 = (float)numero;
            string casting3 = numero.ToString();

            Console.WriteLine("Valor de partida: {0}", numero);
            Console.WriteLine("Casting a int: {0}", casting1);
            Console.WriteLine("Casting a float: {0}", casting2);
            Console.WriteLine("Casting a string: {0}", casting3);
        }
    }
}
