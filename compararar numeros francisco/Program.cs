/*
 * NOMBRE: FRANCISCO GOMEZ PEREZ
 * FECHA: 20/05/2026
 * MATERIA: PROGRAMACION ESTRUCTURADA
 * DESCRIPCIÓN: Este programa se basa en pedir al usuario dos números (enteros/decimales) y compararlos
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace compararar_numeros_francisco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SE DECLARAN VARIABLES CON DOUBLE (PARA ADMITIR DECIMALES)
            string opcion;
            double numero1;
            double numero2;
            
            //BUCLE DO WHILE PARA REPETIR EL PROGRAMA
            do
            {
                //SE PONE LA FUENTE DEL TEXTO DE COLOR BLANCO PARA EDITAR LAS OTRAS FUENTES DE COLOR QUE QUERAMOS
                Console.ForegroundColor = ConsoleColor.White;

                //SE DA LA BIENVENIDA Y SE LE SOLICITA AL USUARIO LOS DOS VALORES PARA QUE INICIE EL PROGRAMA
                Console.WriteLine("Bienvenido al programa de comparar numeros");
                Console.Write("Introduce tu primer numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Introduce tu segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                //SE COMPARAN LOS NUMEROS CON EL IF
                if (numero1 > numero2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"EL PRIMER NUMERO ES EL MAYOR |{numero1} mayor que (>) {numero2}|");
                }
                else if (numero1 == numero2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"AMBOS NUMEROS SON IGUALES |{numero1} es igual que (==) {numero2}|");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"EL SEGUNDO NUMERO ES EL MAYOR |{numero1} es menor que (<) {numero2}|");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("¿Desea repetir el programa? (s/n): ");
                opcion = Console.ReadLine().ToLower();
            }
            while (opcion == "s");

            //SE DAN LAS GRACIAS Y SE BORRA EL TEXTO ANTERIOR
            Thread.Sleep(4500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Gracias por usar el programa :D!");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Pulse cualquier tecla para salir del programa");
            Console.ReadKey();
            }
        }
    }
