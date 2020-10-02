using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Semana1ClasesRecuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[5,3];

            matriz1[0,0] = 5;
            matriz1[0, 1] = 8;
            matriz1[0, 2] = 9;
            matriz1[1, 0] = 4;
            matriz1[1, 1] = 7;
            matriz1[1, 2] = 10;
            matriz1[2, 0] = 9;
            matriz1[2, 1] = 1;
            matriz1[2, 2] = 6;
            matriz1[3, 0] = 2;
            matriz1[3, 1] = 5;
            matriz1[3, 2] = 4;
            matriz1[4, 0] = 8;
            matriz1[4, 1] = 6;
            matriz1[4, 2] = 2;

            

            int[,] matriz2 = new int[5, 3];

            for (int i = 0; i < 5; i++)
            {
              for (int j= 0; j < 3; j++)
                {
                    double valor = Convert.ToDouble(matriz1[i, j]);
                    if (j % 2 == 0)
                    {
                        matriz2[i, j] = Convert.ToInt32(Math.Pow(valor, 3));
                    }
                    else
                    {
                        matriz2[i, j] = Convert.ToInt32(Math.Pow(valor, 2));
                    }
                   

                    Console.Write(matriz1[i, j]+" ");

                   
                }
                Console.WriteLine("");
            }
            Console.WriteLine("------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                      

                    Console.Write(matriz2[i, j] + " ");


                }
                Console.WriteLine("");
            }




            Console.ReadKey();


        }
    }
}
