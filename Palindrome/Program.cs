using System;
using System.Text;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine(Palindrome(response));    //Llama la funcion
        }
        public static string Palindrome(string text)
        {
            StringBuilder sb = new StringBuilder(); //Almacena el texto y su resultado en el orden inverso

            sb.Append(text);
            for (int i = text.Length - 1; i >= 0; i--)    //"i = t.L -1" -> indice del ultimo char; Si "i >= 0" el bucle se ejecuta; El bucle decrementa "i--" en 1
            {                                             //Los caracteres del texto, los coloca en orden inverso
                sb.Append(text[i]);
            }

            return sb.ToString();   //Convierte en cadena y la devuelve
        }
    }
}
