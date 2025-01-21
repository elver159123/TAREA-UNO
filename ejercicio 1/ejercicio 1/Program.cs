using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Creacion del menu para el ejercicio 1
             * definimos la variable opcion como un entero
             * creamos el ciclo do while para la seleccion de opciones              
            */
            int opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio:");
                Console.WriteLine("1. Imprimir los números pares dentro de los primeros 100 números enteros ");
                Console.WriteLine("2. Imprimir los números pares dentro de los primeros 100 números enteros ");
                Console.WriteLine("3. FizzBuzz del 1 al 50");
                Console.WriteLine("4. Imprimir los números del 1 al 10 ");
                Console.WriteLine("5. Calcular la suma de los primeros 100 números enteros ");
                Console.WriteLine("6. Imprimir los números pares dentro de los primeros 100 números enteros ");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        /* Ejercicio 1.1: Imprimir los números pares dentro de los primeros 100 números enteros sin usar if
                         * Para hacer la primera parte voy a hacer lo siguientes:
                         * 1. Usar Console.WriteLine para imprimir el mensaje "Números pares del 1 al 100"
                         * 2. Usar el bucle for para recorrer los números del 2 al 100 de 2 en 2
                         * 3. Dentro del bucle for, usar Console.Write para imprimir cada número par
                         */

                        // Ejercicio 1.1
                        Console.WriteLine("Números pares del 1 al 100:");
                        for (int i = 2; i <= 100; i += 2)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        /* Ejercicio 1.2: Imprimir los números pares dentro de los primeros 100 números enteros usando if
                         * 1. Usar Console.WriteLine para imprimir el mensaje "Números pares del 1 al 100 (usando if)"
                         * 2. Usar el bucle for para recorrer los números del 1 al 100
                         * 3. Dentro del bucle for, usar una estructura if para verificar si el número es par (i % 2 == 0)
                         * 4. Si el número es par, usar Console.Write para imprimir el número
                         */

                        // Ejercicio 1.2
                        Console.WriteLine("Números pares del 1 al 100 (usando if):");
                        for (int i = 1; i <= 100; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(i + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        /* Ejercicio 1.3: Imprimir los números del 1 al 50 con "Fizz", "Buzz", y "FizzBuzz"
                         * 1. Usar Console.WriteLine para imprimir el mensaje "FizzBuzz del 1 al 50"
                         * 2. Usar el bucle for para recorrer los números del 1 al 50
                         * 3. Dentro del bucle for, usar una estructura if-else para verificar:
                         *    a. Si el número es divisible por 3 y 5, imprimir "FizzBuzz"
                         *    b. Si el número es divisible solo por 3, imprimir "Fizz"
                         *    c. Si el número es divisible solo por 5, imprimir "Buzz"
                         *    d. Si el número no es divisible ni por 3 ni por 5, imprimir el número
                         */

                        // Ejercicio 1.3
                        Console.WriteLine("FizzBuzz del 1 al 50:");
                        for (int i = 1; i <= 50; i++)
                        {
                            if (i % 3 == 0 && i % 5 == 0)
                            {
                                Console.WriteLine("FizzBuzz");
                            }
                            else if (i % 3 == 0)
                            {
                                Console.WriteLine("Fizz");
                            }
                            else if (i % 5 == 0)
                            {
                                Console.WriteLine("Buzz");
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 4:
                        /* Ejercicio 1.4: Imprimir los números del 1 al 10 usando un bucle while
                         * 1. Usar Console.WriteLine para imprimir el mensaje "Números del 1 al 10 usando while"
                         * 2. Declarar una variable int j = 1
                         * 3. Usar el bucle while para recorrer mientras j <= 10
                         * 4. Dentro del bucle while, usar Console.Write para imprimir el valor de j
                         * 5. Incrementar la variable j en 1 (j++)
                         */

                        // Ejercicio 1.4
                        Console.WriteLine("Números del 1 al 10 usando while:");
                        int j = 1;
                        while (j <= 10)
                        {
                            Console.Write(j + " ");
                            j++;
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        /* Ejercicio 1.5: Calcular la suma de los primeros 100 números enteros usando un bucle while
                         * 1. Usar Console.WriteLine para imprimir el mensaje "Suma de los primeros 100 números enteros"
                         * 2. Declarar una variable int k = 1 y una variable int suma = 0
                         * 3. Usar el bucle while para recorrer mientras k <= 100
                         * 4. Dentro del bucle while, agregar el valor de k a la variable suma
                         * 5. Incrementar la variable k en 1 (k++)
                         * 6. Fuera del bucle while, usar Console.WriteLine para imprimir el valor de suma
                         */

                        // Ejercicio 1.5
                        Console.WriteLine("Suma de los primeros 100 números enteros:");
                        int k = 1;
                        int suma = 0;
                        while (k <= 100)
                        {
                            suma += k;
                            k++;
                        }
                        Console.WriteLine(suma);
                        break;

                    case 6:
                        /* Ejercicio 1.6: Imprimir los números pares dentro de los primeros 100 números enteros usando un bucle while
                         * 1. Usar Console.WriteLine para imprimir el mensaje "Números pares del 1 al 100 usando while"
                         * 2. Declarar una variable int l = 2
                         * 3. Usar el bucle while para recorrer mientras l <= 100
                         * 4. Dentro del bucle while, usar Console.Write para imprimir el valor de l
                         * 5. Incrementar la variable l en 2 (l += 2)
                         */

                        // Ejercicio 1.6
                        Console.WriteLine("Números pares del 1 al 100 usando while:");
                        int l = 2;
                        while (l <= 100)
                        {
                            Console.Write(l + " ");
                            l += 2;
                        }
                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}



