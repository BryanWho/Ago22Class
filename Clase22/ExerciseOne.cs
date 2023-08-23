using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22
{
    public class ExerciseOne
    {
        public static void AumentarPorcentaje()
        {
            Console.WriteLine("Este algoritmo que genere un número aleatorio del 0 al 200, lo muestre y luego calcule y muestre el mismo número aumentado en un 30%.");
            Random rnd = new Random();
            int num = rnd.Next(1, 200);
            Double num30;
            num30 = num * 1.3;
            Console.WriteLine("El número aleatorio es: " + num);
            Console.WriteLine("El número aumentado su treinta porciento es: " + num30);

        }

        public static void DisminuirPorcentaje()
        {
            Console.WriteLine("Este algoritmo que genere un número aleatorio del 0 al 200, lo muestre y luego calcule y muestre el mismo número aumentado en un 30%.");
            Random rnd = new Random();
            int num = rnd.Next(1, 200);
            Double num30;
            num30 = num * 1.3;
            Console.WriteLine("El número aleatorio es: " + num);
            Console.WriteLine("El número aumentado su treinta porciento es: " + num30);

        }
    }
}
