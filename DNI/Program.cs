using System;

namespace DNI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your DNI/NIF number (Without the letter):");
            int number = int.Parse(Console.ReadLine()); // Parsea el input a numero entero
            Console.WriteLine("Your complete DNI/NIF is: " + number + LetterNIF(number));
        }

        /// <summary>
        /// This 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static char LetterNIF(int number)
        {
            string letterTable = "TRWAGMYFPDXBNJZSQVHLCKE"; // Tabla de letras para calcular la letra de un DNI/NIF
            int index = number % 23; // Calcula el índice correspondiente a la letra
            return letterTable[index]; // Devuelve la letra correspondiente
        }
    }
}
