﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLEx02
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);

                Console.WriteLine(box);
            }

        }
    }
}
