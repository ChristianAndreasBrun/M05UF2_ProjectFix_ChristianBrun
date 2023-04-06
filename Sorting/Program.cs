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
            // Algoritmo "Bubble Sort" > Se define una funcion que recibe una lista de enteros y la devuelve ordenada
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)    //Recorre la lista anidado para comparar cada elemento con los demas
                {
                    if (list[j] < list[i])  //Si "j" es menor que "i", se intercambian
                    {
                        int temp = list[i]; //Almacena el valor de la posicion "i" en una variable temporal
                        list[i] = list[j];  //Coloca el valor de la posicion "j" en la posicion "i"
                        list[j] = temp; //Coloca el valor temporal en la posicion "j"
                    }
                }
            }
            return list;    //Se devuelve la lista ordenada
        }
    }
}
