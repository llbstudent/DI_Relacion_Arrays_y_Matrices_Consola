using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Semana1ClasesRecuperacion
{
    class Program
    {
        static void ahoracado()
        {
            String palabra;
            int vidas = 8;
            Boolean ganador = false;
            Console.WriteLine("***JUGADOR 1***");
            Console.WriteLine("Escribe una palabra");
            palabra = Console.ReadLine().ToString();
            Console.WriteLine("");

            char[] palabra_oculta = new char[palabra.Length];
            crearGuiones(palabra_oculta);

            Console.Clear();

            do
            {
                
                Console.WriteLine("***JUGADOR 2***");
                Console.WriteLine("¡Te toca adivinar la palabra!, tienes " + vidas + " intentos");
                Console.WriteLine("");
                char letra_recogida = Convert.ToChar(Console.ReadLine());

                Boolean acierto = false;
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra_recogida)
                    {
                        palabra_oculta[i] = letra_recogida;
                        acierto = true;
                    }
                }
                if (acierto)
                {
                    Console.WriteLine("Bien encontraste una letra");
                }
                else
                {
                    Console.WriteLine("Ups! no existe esa letra");
                    vidas--;
                }
                imprimirPalabraSecreta(palabra_oculta);
                 
                string palabra_oculta_str = new string(palabra_oculta);
                if (palabra.Equals(palabra_oculta_str))
                {
                    ganador = true;
                    Console.WriteLine("");
                    Console.WriteLine("¡¡¡¡GANASTE!!!! Pulsa cualquier tecla para continuar.");
                }
            }
            while (vidas!=0 && !ganador);
            Console.ReadKey();
        }

        static void crearGuiones(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                  
                array[i] = Convert.ToChar("-");
                
            }

            Console.WriteLine("");

            imprimirPalabraSecreta(array);
            
        }

        static void imprimirPalabraSecreta(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                 
                Console.Write(" " + array[i]);
            }
            Console.WriteLine("");
        }

        

        static void Main(string[] args)
        {
           ahoracado();

        }
    }
}
