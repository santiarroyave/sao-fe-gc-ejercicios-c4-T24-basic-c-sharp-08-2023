# C4-T24 Basic C#
## Enlaces al código
- [Program](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/Program.cs)

- M1 Ejercicio Variables, Constantes y bucle For 
    - [Program](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M1/Program.cs)
    - [Milestone 1](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M1/Milestone1.cs)
    - [Milestone 2](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M1/Milestone2.cs)
    - [Milestone 3](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M1/Milestone3.cs)

- M2 Ejercicio letras repetidas
    - [Program](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M2/Program.cs)
    - [Milestone 1](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M2/Milestone1.cs)
    - [Milestone 2](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M2/Milestone2.cs)
    - [Milestone 3](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M2/Milestone3.cs)

- M3: Ejercicio nombres ciudades
    - [Program](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M3/Program.cs)
    - [Milestone 1](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M3/Milestone1.cs)
    - [Milestone 2](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M3/Milestone2.cs)
    - [Milestone 3](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/T24-Basic-C-Sharp/M3/Milestone3.cs)

## M1 Ejercicio Variables, Constantes y bucle For 
[Enunciados M1 (pdf)](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/Enunciados/M1.%20Enunciat%20Variables.pdf)
- Milestone 1: Mostrar datos nombre, apellidos, fecha de nacimiento, años bisiestos.
- Milestone 2: Casting de double a int, float, string.
- Milestone 3: Rotar array de números sin usar librerias ni array auxiliar.

## M2 Ejercicio letras repetidas
[Enunciados M2 (pdf)](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/Enunciados/M2.%20Enunciat%20Lletres%20Repetides.pdf)
- Milestone 1: Manipular Arrays de carácteres de diferentes tipos (Array, List, Dictionary).
- Milestone 2: Escalera de números y pirámide invertida.
- Milestone 3: Reloj infinito.

## M3 Ejercicio nombres ciudades
[Enunciados M3 (pdf)](https://github.com/santiarroyave/sao-fe-gc-ejercicios-c4-T24-basic-c-sharp-08-2023/blob/main/Enunciados/M3.%20Enunciat%20Noms%20Ciutats.pdf)
- Milestone 1: Manipular Array de strings (ordenar alfabeticamente, cambiar vocal por numero, crear array con las letras).
- Milestone 2: Poner 3 notas a 5 alumnos, calcular media y mostrar si han aprobado o no.
- Milestone 3: Sucuencia de Fibonacci.

## Notas
- Se puede usar *"new string(carácter, cantidad)"* para crear cadenas con carácteres repetidos." (M2.Milestone2)
    ```c#
    string asteriscos = new string('*', 5); // *****
    ```

- Obtener hora actual (M2.Milestone3)
    ```c#
    TimeSpan horaActual = DateTime.Now.TimeOfDay;

    int hour = horaActual.Hours;
    int minutes = horaActual.Minutes;
    int seconds = horaActual.Seconds;
    ```

- Actualizar o reescribir valores de la consola.
    Útil para actualizar o reescribir valores específicos sin borrar el contenido anterior.

    - Establecer posición del cursor
        ```c#
        Console.SetCursorPosition(int left, int top):
        // - 'left' indica la posición horizontal (columna) donde se ubicará el cursor.
        // - 'top' indica la posición vertical (fila) donde se ubicará el cursor.
        ```

    - Ejemplo para posicionar el cursor en la ultima fila cuando tiene salto de línea (WriteLine).
        ```c#
        // Si se hace scroll, la ubicación será diferente
        Console.SetCursorPosition(0, Console.WindowTop + Console.WindowHeight - 2);
        ```

    - Ejemplo para posicionar el cursor en la ultima fila cuando no tiene salto de línea (Write).
        ```c#
        // Si se hace scroll, la ubicación será diferente
        Console.SetCursorPosition(0, Console.WindowTop + Console.WindowHeight - 1);
        ```

    - Borrar línea una vez seleccionada
        ```c#
        Console.Write(new string(' ', Console.WindowWidth));
        ``` 

- Métodos de Interpolación de Cadenas
    ```c#
    string mensaje = string.Format("Hola, mi nombre es {0} y tengo {1} años.", nombre, edad);
    ```

    ```c#
    string mensaje = $"Hola, mi nombre es {nombre} y tengo {edad} años.";
    ```

- Especificadores de formato

    [Documentación: Cadenas con formato numérico estándar](https://learn.microsoft.com/es-es/dotnet/standard/base-types/standard-numeric-format-strings)
    ```c#
    // Ejemplo visto en M2/Milestone3
    Console.WriteLine($"{hour:00}:{minutes:00}:{seconds:00}");
    Console.WriteLine($"{hour:D2}:{minutes:D2}:{seconds:D2}");

    // Ejemplo visto en M3/Milestone2
    Console.WriteLine("Mitjana: {0}", mitjana.ToString("F2"));
    ```
    Algunos ejemplos:
    - **{valor:F2}**: Muestra el valor numérico con 2 decimales (por ejemplo, 3.14).
    - **{valor:C}**: Muestra el valor numérico como una moneda (por ejemplo, $10.00).
    - **{valor:D4}**: Muestra el valor numérico como un número entero con al menos 4 dígitos (por ejemplo, 0012).
    - **{fecha:d}**: Muestra la fecha en formato corto (por ejemplo, 8/16/2023).
    - **{cadena,-10}**: Alinea la cadena a la izquierda con un ancho mínimo de 10 caracteres.