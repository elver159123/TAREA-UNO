using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*creacion de menu de opciones para realizar cada ejercicio
             * definimos opcion como una variable entera
             * creacom un ciclo do while para la seleccion de opciones
             * 
             * 
            */
            int opcion;
            do
            {
                Console.WriteLine("Selecciona un ejercicio:");
                Console.WriteLine("1. Evaluar si un número es positivo, negativo o cero");
                Console.WriteLine("2. Evaluar si una calificación es aprobada o reprobada");
                Console.WriteLine("3. Determinar el rango de un número");
                Console.WriteLine("4. Mostrar el día de la semana correspondiente");
                Console.WriteLine("5. Realizar una operación matemática (+, -, *, /) entre dos números");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        /* Ejercicio 2.1: Evaluar si un número ingresado es positivo, negativo o cero 
                         * 1. Usar Console.WriteLine para pedir al usuario que ingrese un número 
                         * 2. Usar int.TryParse para convertir la entrada del usuario en un número entero 
                         * 3. Si la conversión es exitosa: 
                         * a. Usar una estructura if-else para evaluar si el número es positivo, negativo o cero 
                         * b. Imprimir un mensaje correspondiente a la evaluación 
                         * 4. Si la conversión falla, imprimir un mensaje de error indicando que la entrada no es válida 
                         */
                        Console.WriteLine("Ejercicio 2.1: Evaluar si un número es positivo, negativo o cero");
                        Console.Write("Ingresa un número: ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            if (numero > 0)
                            {
                                Console.WriteLine("El número es positivo.");
                            }
                            else if (numero < 0)
                            {
                                Console.WriteLine("El número es negativo.");
                            }
                            else
                            {
                                Console.WriteLine("El número es cero.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                        }
                        break;

                    case 2:
                        /* Ejercicio 2.2: Evaluar si una calificación es aprobada o reprobada 
                         * 1. Usar Console.WriteLine para pedir al usuario que ingrese una calificación 
                         * 2. Usar int.TryParse para convertir la entrada del usuario en un número entero 
                         * 3. Si la conversión es exitosa: 
                         * a. Usar una estructura if para verificar si la calificación es mayor o igual a 60 
                         * b. Imprimir "Aprobado" si la calificación es mayor o igual a 60 
                         * c. Imprimir "Reprobado" si la calificación es menor a 60 
                         * 4. Si la conversión falla, imprimir un mensaje de error indicando que la entrada no es válida 
                         */
                        Console.WriteLine("Ejercicio 2.2: Evaluar si una calificación es aprobada o reprobada");
                        Console.Write("Ingresa una calificación: ");
                        if (int.TryParse(Console.ReadLine(), out int calificacion))
                        {
                            if (calificacion >= 60)
                            {
                                Console.WriteLine("Aprobado");
                            }
                            else
                            {
                                Console.WriteLine("Reprobado");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingresa una calificación numérica.");
                        }
                        break;

                    case 3:
                        /* Ejercicio 2.3: Determinar el rango de un número 
                         * 1. Usar Console.WriteLine para pedir al usuario que ingrese un número 
                         * 2. Usar int.TryParse para convertir la entrada del usuario en un número entero 
                         * 3. Si la conversión es exitosa: 
                         * a. Usar una estructura if-else para evaluar si el número es menor que 10, entre 10 y 20, o mayor que 20 
                         * b. Imprimir un mensaje correspondiente al rango en el que se encuentra el número 
                         * 4. Si la conversión falla, imprimir un mensaje de error indicando que la entrada no es válida 
                         */
                        Console.WriteLine("Ejercicio 2.3: Determinar el rango de un número");
                        Console.Write("Ingresa un número: ");
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            if (num < 10)
                            {
                                Console.WriteLine("Menor que 10");
                            }
                            else if (num <= 20)
                            {
                                Console.WriteLine("Entre 10 y 20");
                            }
                            else
                            {
                                Console.WriteLine("Mayor que 20");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
                        }
                        break;

                    case 4:
                        /* Ejercicio 2.4: Mostrar el día de la semana correspondiente 
                         * 1. Usar Console.WriteLine para pedir al usuario que ingrese un número del 1 al 7 
                         * 2. Usar int.TryParse para convertir la entrada del usuario en un número entero 
                         * 3. Si la conversión es exitosa: * a. Usar una estructura switch para evaluar el número ingresado 
                         * b. Imprimir el día de la semana correspondiente al número (por ejemplo, 1 para "Lunes") 
                         * c. Si el número no está en el rango del 1 al 7, imprimir un mensaje de error 
                         * 4. Si la conversión falla, imprimir un mensaje de error indicando que la entrada no es válida 
                         */
                        Console.WriteLine("Ejercicio 2.4: Mostrar el día de la semana correspondiente");
                        Console.Write("Ingresa un número del 1 al 7: ");
                        if (int.TryParse(Console.ReadLine(), out int dia))
                        {
                            switch (dia)
                            {
                                case 1: Console.WriteLine("Lunes"); break;
                                case 2: Console.WriteLine("Martes"); break;
                                case 3: Console.WriteLine("Miércoles"); break;
                                case 4: Console.WriteLine("Jueves"); break;
                                case 5: Console.WriteLine("Viernes"); break;
                                case 6: Console.WriteLine("Sábado"); break;
                                case 7: Console.WriteLine("Domingo"); break;
                                default: Console.WriteLine("Número inválido"); break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingresa un número del 1 al 7.");
                        }
                        break;

                    case 5:
                        /* Ejercicio 2.5: Realizar una operación matemática entre dos números 
                         *1. Usar Console.WriteLine para pedir al usuario que ingrese el primer número 
                         *2. Usar double.TryParse para convertir la entrada del usuario en un número de punto flotante 
                         *3. Si la conversión es exitosa: * a. Usar Console.WriteLine para pedir al usuario que ingrese el segundo número 
                         *b. Usar double.TryParse para convertir la entrada del usuario en un número de punto flotante 
                         *c. Si la conversión es exitosa: 
                         *I. Usar Console.WriteLine para pedir al usuario que ingrese la operación a realizar (+, -, *, /) 
                         *II. Usar un switch para evaluar la operación ingresada 
                         *III. Realizar la operación correspondiente y mostrar el resultado 
                         *IV. Si la operación es división, verificar que el segundo número no sea cero antes de realizar la operación 
                         *d. Si la conversión falla, imprimir un mensaje de error indicando que la entrada no es válida 
                         *4. Si la conversión falla, imprimir un mensaje de error indicando que la entrada no es válida 
                         */
                        Console.WriteLine("Ejercicio 2.5: Realizar una operación matemática (+, -, *, /) entre dos números");
                        Console.Write("Ingresa el primer número: ");
                        if (double.TryParse(Console.ReadLine(), out double num1))
                        {
                            Console.Write("Ingresa el segundo número: ");
                            if (double.TryParse(Console.ReadLine(), out double num2))
                            {
                                Console.Write("Ingresa la operación a realizar (+, -, *, /): ");
                                char operacion = Console.ReadKey().KeyChar;
                                Console.WriteLine();
                                switch (operacion)
                                {
                                    case '+':
                                        Console.WriteLine($"Resultado: {num1 + num2}");
                                        break;
                                    case '-':
                                        Console.WriteLine($"Resultado: {num1 - num2}");
                                        break;
                                    case '*':
                                        Console.WriteLine($"Resultado: {num1 * num2}");
                                        break;
                                    case '/':
                                        if (num2 != 0)
                                        {
                                            Console.WriteLine($"Resultado: {num1 / num2}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Error: División por cero no es permitida.");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Operación no válida.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Entrada no válida. Por favor, ingresa un número válido.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        break;
                }

                Console.WriteLine(); 
            } while (opcion != 0);
        }
    }
}
