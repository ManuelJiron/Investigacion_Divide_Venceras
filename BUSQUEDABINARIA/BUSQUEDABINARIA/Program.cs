using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSQUEDABINARIA
{
    internal class Program
    {
        static int RaizCuadrada(int n)
        {
            if (n == 0 || n == 1)
                return n;

            int inicio = 0, fin = n, respuesta = 0;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                // Si el cuadrado del medio es exactamente igual a n
                if (medio * medio == n)
                    return medio;

                // Si el cuadrado del medio es menor que n, descartamos la mitad izquierda
                if (medio * medio < n)
                {
                    inicio = medio + 1;
                    respuesta = medio;  // Guardamos la mejor aproximación
                }
                else
                {
                    // Si el cuadrado del medio es mayor, descartamos la mitad derecha
                    fin = medio - 1;
                }
            }

            return respuesta;  // Devuelve la mejor aproximación
        }

        static void Main()
        {
            Console.WriteLine("Ingresa un número:");
            int numero = int.Parse(Console.ReadLine());

            int resultado = RaizCuadrada(numero);
            Console.WriteLine($"La raíz cuadrada entera aproximada de {numero} es {resultado}");

            Console.ReadKey();
        }
    }
}
