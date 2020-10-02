using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Semana1ClasesRecuperacion
{
    class Program
    {

        static void mostrarSubCadena()
        {
            String frase;
            String[] fraseArray = new String[50];
            char delimitador = ' ';


            Console.WriteLine("Introduce una frase: ");
            frase = Console.ReadLine();

            fraseArray = frase.Split(delimitador);



            foreach (String subcadena in fraseArray)
            {
                Console.WriteLine(subcadena);
            }

           subCadenaConEspacio(fraseArray);

        }
        static void subCadenaConEspacio(String[] array)
        {
            int cont = 0;
            foreach (String palabra in array)
            {
                
                for(int i = 0; i< palabra.Length; i += 2)
                {
                    string respuesta = palabra.Substring(i, Math.Min(2,palabra.Length -i));
                    Console.Write(respuesta + " ");
                }
            }

        }



       static void Main(string[] args)
       {
         mostrarSubCadena();
            Console.ReadKey();
       }
    }
}
