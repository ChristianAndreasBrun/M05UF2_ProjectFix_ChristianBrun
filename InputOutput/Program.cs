﻿using System;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Please write yes/no");
                string response = Console.ReadLine().ToLower(); // NO > no
                if (response[0] == 'y')
                {
                    Console.WriteLine("Hello world");
                    running = false;
                }
                else if (response[0] == 'n')    // no esta comparando, le esta diciendo que sea igual al char
                {
                    Console.WriteLine("Goodbye world");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Not recognized");
                }
            }
        }
    }
}
