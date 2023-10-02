﻿using System;

namespace practic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablica();
            Game();
            BezNazvania();
        }
        static void Tablica()
        {
            int[,] Table = new int[10, 10];
            for (int x = 1; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Table[x, y] = (x * y);
                    Console.Write(Table[x, y] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Game()
        {
            Random chislo = new Random();
            int a = chislo.Next(1, 100);
            int b;
            Console.WriteLine("Попробуйте угадать число");
            do
            {
                b = int.Parse(Console.ReadLine());

                if 
                    (b < a) Console.WriteLine("Загаданное число больше");

                else if 

                    (b > a) Console.WriteLine("Загаданное число меньше");

            }
            while (b != a);
            Console.WriteLine("POBEDA!!!!!!!!");
         }
        
        static void BezNazvania()
        {
            Console.Write("Введи число ");
            int i = int.Parse(Console.ReadLine());
            for (int a = 1; a <= i; a++)
            {
                if (i % a == 0) Console.Write("{0} ", a);
            }

        }


        
    }
    
         
}
