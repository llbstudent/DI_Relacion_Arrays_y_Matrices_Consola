using System;

namespace Ejercicio4Semana1ClasesRecuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz m;
            int filas, columnas;
            int[] silla = new int[3];
            
            Console.WriteLine("Introduce las filas:");
            filas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce las columnas:");
            columnas = Convert.ToInt32(Console.ReadLine());

            m = new Matriz(filas, columnas);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    m.rellenaMatriz(i, j);
                }
            }
            m.pintaMatriz();
            silla = m.puntoSilla();
            if (silla == null)
                Console.WriteLine("No se ha encontrado punto de silla");
            else
            {
                Console.WriteLine("El punto de silla es:{0}", silla[0]);
                Console.WriteLine("Está en la posición {0},{1}", silla[1] + 1, silla[2] + 1);
            }
            Console.ReadKey();
        }
    }
}

