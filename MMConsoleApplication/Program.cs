﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("ModernMedical");
                    continue;
                }

                if(i % 3 == 0)
                {
                    Console.WriteLine("Modern");

                } else if(i % 5 == 0)
                {
                    Console.WriteLine("Medical");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
