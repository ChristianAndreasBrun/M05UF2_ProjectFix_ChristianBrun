using System;

namespace ParenthesisChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parenthesis");
            string response = Console.ReadLine();
            int open = CountChars(response, '(');   //Se abre la parentesis
            int close = CountChars(response, ')');  //Se cierra la parentesis
            if (open != close)
            {
                Console.WriteLine("The parenthesis don't close");
            }
            else
            {
                Console.WriteLine("The parenthesis close");
            }
        }
        public static int CountChars(string text, char search)
        {
            int amount = 0;  // Inicializamos el contador en 0
            for (int i = 0; i < text.Length; i++)   // Recorremos la cadena de texto con un ciclo "for"
            {
                if (text[i] == search)  //Si "i" es igual a "search", incrementa el contador
                {
                    amount++;
                }
                else if (text[i] != search) //Si "i" es diferente a "search", el contador decrementa
                {
                    amount--;
                }
            }
            return amount;   
        }
    }
}