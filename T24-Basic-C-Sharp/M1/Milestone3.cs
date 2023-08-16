using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M1
{
    internal class Milestone3
    {
        //MILESTONE 3
        //  Declara un array de numeros int e inicialitzala amb valors del 1 al 10
        //  − Rota l’array sense utilitzar un array auxiliar ni llibreries. Pots utilizar una variable auxiliar.
        //  Array exemple:
        //  int[] array ={ 1,2,3,4,5,6,7,8,9,10 };

        public void Inicia()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int tamaño = numeros.Length;
            int mitad = tamaño / 2;


            for (int i = 0; i < mitad; i++)
            {
                int temp = numeros[i];

                numeros[i] = numeros[tamaño - i - 1];
                numeros[tamaño - i - 1] = temp;
            }

            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
        }
    }
}
