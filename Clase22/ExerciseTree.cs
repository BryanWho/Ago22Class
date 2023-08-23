using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase22
{
    internal class ExerciseTree
    {
        public static void Perimetro()
        {
            int ancho, largo, perimetro;
            Console.WriteLine("Ingrese el largo");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el alto");
            largo = int.Parse(Console.ReadLine());
            perimetro = 2 * ancho + 2 * largo;
            Console.WriteLine("perimetro" + perimetro);
        }

        public static void Area()
        {
            int ancho, largo, area;
            Console.WriteLine("Ingrese el largo");
            ancho = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el alto");
            largo = int.Parse(Console.ReadLine());
            area = ancho  * largo;
            Console.WriteLine("area" + area);

        }
    }
}
