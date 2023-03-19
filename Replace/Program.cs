using System;
using System.Text;

namespace Replace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text");
            string response = Console.ReadLine();
            Console.WriteLine("What character to replace?");
            char search = Console.ReadLine()[0];
            Console.WriteLine("What character to replace to?"); //hola
            char replace = Console.ReadLine()[0];
            string result = Replace(response, search, replace); //hola, l, b
            Console.WriteLine(result);  // = str: hoba
        }
        public static string Replace(string text, char a, char b)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)   //hola, l, b : hoba |-> str text = hoba
            {
                if(text[i] == a)
                {
                    sb.Append(b); 
                }
                else
                {
                    sb.Append(text[i]); 
                }
            }
            return sb.ToString();
        }
    }
}
