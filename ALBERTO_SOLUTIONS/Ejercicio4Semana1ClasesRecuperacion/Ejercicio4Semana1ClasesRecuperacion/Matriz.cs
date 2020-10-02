using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio4Semana1ClasesRecuperacion
{
    class Matriz
    {
        private int nfilas;
        private int ncolumnas;
        public int Filas
        {
            get { return nfilas; }
            set { nfilas = value; }
        } 

        public int Columnas
        {
            get { return ncolumnas; }
            set { ncolumnas = value; }
        }
        private int[,] m;

        public int[,] M
        {
            get { return m; }
            set { m = value; }
        }

        public Matriz(int f, int c)
        {
            nfilas = f;
            ncolumnas = c;
            m = new int[f, c];
        }
        public void pintaMatriz()
        {
            Console.WriteLine("Matriz:");
            for (int i = 0; i < Filas; i++)
            {
                for (int j = 0; j < Columnas; j++)
                {
                    Console.Write("{0} ", m[i, j]);
                }
                Console.WriteLine();

            }
        }
        public void rellenaMatriz(int i, int j)
        {
            int valor;
            Console.WriteLine("Introduce el elemento {0},{1}", i + 1, j + 1);
            try
            {
                valor = Convert.ToInt32(Console.ReadLine());
                m[i, j] = valor;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "El valor no es valido");
            }
        }
        public int[] puntoSilla()
        {
            bool encontrado = true;

            int[] silla = new int[3];


            for (int i = 0; i < Filas; i++)
            {
                silla[0] = m[i, 0];
                encontrado = true;
                for (int j = 0; j < Columnas; j++)
                {
                    if (silla[0] > m[i, j])
                    {
                        silla[0] = m[i, j];
                        silla[1] = i;
                        silla[2] = j;
                    }

                }
                for (int k = 0; k < Filas; k++)
                {

                    if (silla[0] < m[k, silla[2]])
                    {
                        encontrado = false;
                    }
                }

            }
            if (encontrado)
                return silla;
            else
                return null;
        }
    }
}
