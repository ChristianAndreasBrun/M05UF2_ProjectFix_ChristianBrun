using System;

namespace Primes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num;
            string response;
            Console.WriteLine("Enter a number: ");  // 7
            response = Console.ReadLine();
            num = int.Parse(response);  // str: 7 > lo pasa a numero > float: 7
            if (IsPrime(num))
            {
                Console.WriteLine(num + ": is prime");  // es true
            }
            else
            {
                Console.WriteLine(num + ": is not prime");  // es false
            }
        }
        public static bool IsPrime(int number)
        {
            if(number <= 1)     // cualquier numero menor que 1, no es primo
                return false;
            if (number == 2)    // igual a 2 es primo
                return true;
            if (number % 2 == 0)    // dividiendo a modulo 2 que sea igual a 0, no es primo
                return false;

            // Comprueba si el número es divisible por algún número impar mayor que 3
            for (int i = 3; i <= number / 2; i += 2)
            {
                // Si el número es divisible por "i", no es primo
                if (number % i == 0)
                {
                    return false;
                }
            }
            // Si el número no es divisible por ningún número hasta la mitad de sí mismo, entonces es primo

            //TODO
            return true;
        }
    }
}
