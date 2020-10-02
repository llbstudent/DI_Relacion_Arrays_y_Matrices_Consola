using System;
using System.Threading;

namespace Ejercicio1Semana1ClasesRecuperacion
{

    
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] dias = new int[7];
            double[] ventas = new double[7];
            double[] ventasOrdenadas = new double[7];

            Console.WriteLine("Ejercicio 1 - semana 1 recuperación");
            Thread.Sleep(1000);

            //Rellenamos los dias
            rellenarDias(dias,ventas);
            Console.WriteLine("");
            Thread.Sleep(1000);

            // Creamos un array nuevo que va almacenar la lista ORDENADA
            for (int i = 0; i < 7; i++)
            {
                ventasOrdenadas[i] = ventas[i];
            }

            Console.WriteLine("a) Mostrar ordenadas las ventas de mayor a menor.");
            ordenarVentas(ventasOrdenadas);
            Console.WriteLine("");


            // Ordenar array ventas con su día
            Console.WriteLine("b) Mostrar el día de más y menos ventas.");
            ordenarVentasConSuDia(ventas, dias);
            Console.WriteLine("");


            // Suma de ventas
            Console.WriteLine("c) Mostrar el total de ventas realizadas durante toda la semana.");
            totalDeVentas(ventas);
            Console.WriteLine("");

            //Media de ventas
            Console.WriteLine("d) Mostrar la media de las ventas realizadas durante toda la semana.");
            mediaDeVentas(ventas);

        }

        private static void mediaDeVentas(double[] ventas)
        {
            double num = 0;
            for (int i = 0; i < 7; i++)
            {
                num = num + ventas[i];
            }

            double media = num / 7;

            Console.WriteLine("La media de ventas durante la semana es de: " + media);
        }

        private static void totalDeVentas(double[] ventas)
        {
            double num = 0;
            for(int i =0; i < 7; i++)
            {
                num = num + ventas[i];
            }

            Console.WriteLine("El total de ventas en la semana es: " + num);
        }

        private static void ordenarVentasConSuDia(double[] ventas, int[] dias)
        {
            double maximo_ventas = 0;
            double minimo_ventas = double.MaxValue;
            int maximo_dia = -1;
            int minimo_dia = -1;

            for (int i = 0; i < ventas.Length; i++)
            { 
                //Buscar el maximo
                if (ventas[i] > maximo_ventas)
                {
                    maximo_ventas = ventas[i];
                    maximo_dia = i;
                }

                //Buscar menor
                if (ventas[i] < minimo_ventas)
                {
                    minimo_ventas = ventas[i];
                    minimo_dia = i; 
                }
            }

            Console.WriteLine("El dia " + dias[maximo_dia] + " se vendio " + maximo_ventas + ", fue el máximo de ventas");
            Console.WriteLine("El dia " + dias[minimo_dia] + " se vendio " + minimo_ventas + ", fue el minimo de ventas");

        }

        private static void ordenarVentas(double[] ventasOrdenadas)
        {

            for (int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6 - i; j++)
                {
                    if(ventasOrdenadas[j] < ventasOrdenadas[j+1])
                    {
                        double num;
                        num = ventasOrdenadas[j];
                        ventasOrdenadas[j] = ventasOrdenadas[j + 1];
                        ventasOrdenadas[j + 1] = num;
                    } 
                }
            }

            for (int f = 0; f < ventasOrdenadas.Length; f++)
            {
                Console.Write(ventasOrdenadas[f] + "  ");
            }

        }


        public static void rellenarDias(int[] dias, double[] ventas)
        {
            for (int i = 0; i < dias.Length; i++)
            {
                Console.WriteLine("Introduce el número de ventas del día " + (i+1) + ":");
                dias[i] = i+1;
                ventas[i] = Convert.ToDouble(Console.ReadLine());  
            }
           
        }



 

    }

    
}
