using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /* Definición de la Clase Persona:
 * Objetivo: Representar una persona con nombre, edad, y DNI.
 * Atributos:
 *   - Nombre (string): Almacena el nombre de la persona.
 *   - Edad (int): Almacena la edad de la persona.
 *   - CI (string): Almacena la cedula de identidad de la persona.
 * Métodos:
 *   - MostrarInformacion(): Imprime los detalles de la persona (nombre, edad, DNI).
 * Constructor:
 *   - Permite inicializar los atributos (Nombre, Edad, DNI) al crear un objeto Persona.
 */
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string CI { get; set; }

        public Persona() { }

        public Persona(string nombre, int edad, string dni)
        {
            Nombre = nombre;
            Edad = edad;
            CI = dni;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, CI: {CI}");
        }
    }

    /* Definición de la Clase Punto:
 * Objetivo: Representar un punto en el plano cartesiano.
 * Atributos:
 *   - X(double) : Coordenada X del punto.
 *   - Y (double): Coordenada Y del punto.
 * Métodos:
 *   - MostrarPunto(): Muestra las coordenadas (X, Y) del punto.
 * Constructor:
 *   - Inicializa las coordenadas X e Y al crear un objeto Punto.
 */

    public class Punto
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto() { }

        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void MostrarPunto()
        {
            Console.WriteLine($"Punto: ({X}, {Y})");
        }
    }

    /* Definición de la Clase Circulo:
 * Objetivo: Representar un círculo con un centro (x, y) y un radio.
 * Atributos:
 *   - X (double): Coordenada X del centro del círculo.
 *   - Y (double): Coordenada Y del centro del círculo.
 *   - Radio (double): Radio del círculo.
 * Métodos:
 *   - CalcularArea(): Calcula y devuelve el área del círculo usando la fórmula πr².
 *   - MostrarCirculo(): Muestra las coordenadas del centro (X, Y) y el radio.
 * Constructor:
 *   - Inicializa X, Y, y Radio al crear un objeto Circulo.
 */
    public class Circulo
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radio { get; set; }

        public Circulo() { }

        public Circulo(double x, double y, double radio)
        {
            X = x;
            Y = y;
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public void MostrarCirculo()
        {
            Console.WriteLine($"Círculo en ({X}, {Y}) con radio {Radio}");
        }
    }


    /* Clase Program con el Método Main:
 * Objetivo: Probar todas las clases definidas.
 * Menú Interactivo:
 *   - Se usa un do-while para mostrar un menú con opciones para seleccionar y probar cada clase.
 * Opciones del Menú:
 *   - Probar Persona: Crea un objeto Persona, asigna valores y llama a MostrarInformacion().
 *   - Probar Punto: Crea un objeto Punto, asigna coordenadas y llama a MostrarPunto().
 *   - Probar Circulo: Crea un objeto Circulo, asigna valores, muestra el círculo y calcula el área.
 *   - Opción 0: Sale del programa.
 */
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Probar la clase Persona");
                Console.WriteLine("2. Probar la clase Punto");
                Console.WriteLine("3. Probar la clase Circulo");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            // Probar la clase Persona
                            Persona persona1 = new Persona("Andy Yanacallo", 26, "1724443617");
                            persona1.MostrarInformacion();
                            break;

                        case 2:
                            // Probar la clase Punto
                            Punto punto1 = new Punto(5.1, 8.3);
                            punto1.MostrarPunto();
                            break;

                        case 3:
                            // Probar la clase Circulo
                            Circulo circulo1 = new Circulo(8.0, 8.0, 13.0);
                            circulo1.MostrarCirculo();
                            Console.WriteLine($"Área del círculo: {circulo1.CalcularArea()}");
                            break;

                        case 0:
                            Console.WriteLine("Saliendo del programa...");
                            break;

                        default:
                            Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                    opcion = -1; // Para evitar salir del bucle si la entrada es inválida
                }

                Console.WriteLine(); // Línea en blanco para separación
            } while (opcion != 0);

            Console.ReadLine();
        }
    }
}
