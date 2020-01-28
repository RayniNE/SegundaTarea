using System;
using System.Linq;

namespace Arreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables.
            int[] nums = new int[10];
            int mayor;
            int menor;
            Console.WriteLine("Segunda tarea: Arreglo de 10 número e imprimir el mayor y el menor.");
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("Ingrese el número de la posición {0}: ", i + 1);
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }
            mayor = nums.Max();
            menor = nums.Min();

            Console.WriteLine();

            Console.WriteLine("El número mayor es: {0}", mayor);
            Console.WriteLine("El número mayor es: {0}", menor);
            Console.ReadKey();


        }
    }
}
