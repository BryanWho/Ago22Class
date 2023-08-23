using System;

namespace Clase22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu;
            Console.WriteLine("Ejercicio 1 Porcentaje (1)");
            Console.WriteLine("Ejercicio 2 Promedio (2)");
            Console.WriteLine("Área y altura (3) ");

            menu = Console.Readline();

            switch (menu)
            {
                case '1':
                    ExerciseOne.AumentarPorcentaje();
                    ExerciseOne.DisminuirPorcentaje();
                    break;

                case '2':
                    ExerciseTwo.Promedio();
                    break;

                case '3':
                    ExerciseTree.Perimetro();
                    ExerciseTree.Area();
             break;
            }
                
            
            

        }
    }
}