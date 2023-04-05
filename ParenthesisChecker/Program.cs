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
            if(open != close)
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
            int amount = 0; //Inicializa el contador a 0
            for (int i = 0; i < text.Length; i++)   //Recorre la cadena de texto
            {
                if (text[i] == search)  //Si el caracter en la posicion "i" es igual que "search", incrmenta
                {
                    amount++;
                }
                else if (text[i] != search) //Si el caracter en la posicion "i" no es igual a "search", decrementa
                {
                    amount--;
                }
            }
            return amount;  //Devuelve el valor del contador
        }
    }
}
