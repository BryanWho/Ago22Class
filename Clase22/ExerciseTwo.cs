using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22
{
    internal class ExerciseTwo
    {
        public static void Promedio()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Double promedio = 0;
            Console.WriteLine("Dígite el número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dígite el número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dígite el número 3");
            num3 = int.Parse(Console.ReadLine());
            promedio = (num1 + num2 + num3) / 3;
            Console.WriteLine("Promedio = " + promedio);

        }
    }
}
