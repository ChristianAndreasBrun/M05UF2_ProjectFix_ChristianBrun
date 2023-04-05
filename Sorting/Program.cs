using System;
using System.Collections.Generic;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unordered list: ");
            List<int> list = new List<int>(100);    //Se crea una lista con numeros random
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next());  //Llenamos la lsita de numeros random
                Console.WriteLine(list[i]);     //Por consola se muestra los numeros generados
            }

            list = Sort(list);
            Console.WriteLine("Ordered list: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);     //Por consola se muestra los numeros generados, de manera ordenada
            }
        }

        static public List<int> Sort(List<int> list)
        {
            // Aquí se usa el algoritmo "Bubble Sort"
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[i])  //Si "j" es menor que "i", se intercambian
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
            return list;    //Se devuelve la lista ordenada
        }
    }
}
