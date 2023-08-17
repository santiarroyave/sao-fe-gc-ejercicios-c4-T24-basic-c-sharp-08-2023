using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M2
{
    internal class Milestone3
    {
        //MILESTONE 3

        //Exercici: En aquest exercici es proposa un exercici complex de comprovacions i bucles per crear un rellotge digital que mostra l'hora sense parar. A més té un segon d'espera per més realisme.
        //  − Només necessites 3 variables int (hour, minutes, seconds)
        //  − El rellotge ha de tenir 6 dígits en tot moment: 00:00:00
        //  − L’aplicació no ha de finalitzar mai.
        //  − Per que el rellotge trigui un segon has d’implementar: Thread.Sleep(1000);
        public void Inicia()
        {
            Console.WriteLine("Presiona cualquier tecla para iniciar el reloj.");
            Console.WriteLine("- Nota: Si se hace scroll hacia arriba con el reloj activado se imprimirá la hora en el lugar equivocado.");
            Console.ReadKey();
            Console.WriteLine();

            // Primero obtenemos la hora actual y lo almacenamos en las variables
            TimeSpan horaActual = DateTime.Now.TimeOfDay;

            int hour = horaActual.Hours;
            int minutes = horaActual.Minutes;
            int seconds = horaActual.Seconds;

            // Creación del reloj
            while (true)
            {
                // Mostrar hora
                if (hour.ToString().Length == 1)
                {
                    Console.Write("0" + hour);
                }
                else
                {
                    Console.Write(hour);
                }
                Console.Write(":");

                // Mostrar minutos
                if (minutes.ToString().Length == 1)
                {
                    Console.Write("0" + minutes);
                }
                else
                {
                    Console.Write(minutes);
                }
                Console.Write(":");

                // Mostrar segundos
                if (seconds.ToString().Length == 1)
                {
                    Console.Write("0" + seconds);
                }
                else
                {
                    Console.Write(seconds);
                }
                Console.WriteLine();


                // Esperar 1 segundo
                Thread.Sleep(1000);

                // Añadir segundo
                seconds++;


                // Calcular limites y actualizar datos
                if (seconds == 60)
                {
                    seconds = 0;
                    minutes++;

                    if (minutes == 60)
                    {
                        minutes = 0;
                        hour++;

                        if (hour == 24)
                        {
                            hour = 0;
                        }
                    }
                }

                // Posicionar cursor en su posicion para actualizar la hora
                Console.SetCursorPosition(0, Console.WindowTop + Console.WindowHeight - 2);
            }
        }
    }
}
