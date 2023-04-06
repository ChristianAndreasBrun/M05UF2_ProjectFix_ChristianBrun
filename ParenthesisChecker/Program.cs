using System;

namespace ParenthesisChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parenthesis");
            string response = Console.ReadLine();
            bool open = CountChars(response, '(');   //Se abre la parentesis
            bool close = CountChars(response, ')');  //Se cierra la parentesis
            if (open != close)
            {
                Console.WriteLine("The parenthesis don't close");
            }
            else
            {
                Console.WriteLine("The parenthesis close");
            }
        }
        public static bool CountChars(string text, char search)
        {
            int amount = 0;  // Inicializamos el contador en 0
            for (int i = 0; i < text.Length; i++)   // Recorremos la cadena de texto con un ciclo "for"
            {
                if (text[i] == '(')  // Si encontramos un paréntesis abierto, incrementamos el contador
                {
                    amount++;
                }
                else if (text[i] == ')')  // Si encontramos un paréntesis cerrado, decrementamos el contador
                {
                    amount--;
                    if (amount < 0)  // Si el contador es negativo, hay más paréntesis cerrados que abiertos, lo que es incorrecto
                    {
                        return false;  // Devolvemos "false" para indicar que la cadena de texto tiene paréntesis mal balanceados
                    }
                }
            }
            if (amount == 0)  // Si el contador es igual a 0 al final del ciclo, todos los paréntesis están correctamente balanceados
            {
                return true;  // Devolvemos "true" para indicar que la cadena de texto tiene paréntesis balanceados
            }
            else
            {
                return false;  // Si el contador es distinto de 0, hay más paréntesis abiertos que cerrados, lo que es incorrecto
            }
        }
    }
}