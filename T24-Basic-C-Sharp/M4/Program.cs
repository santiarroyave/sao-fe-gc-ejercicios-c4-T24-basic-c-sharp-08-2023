﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T24_Basic_C_Sharp.M4
{
    internal class Program
    {
        public void Inicia()
        {
            Console.WriteLine("##################################################");
            Console.WriteLine("#                                                #");
            Console.WriteLine("# M4 - Exercici Restaurant                       #");
            Console.WriteLine("#                                                #");
            Console.WriteLine("##################################################\n");

            // - MILESTONE 1
            Console.WriteLine("MILESTONE 1");
            Console.WriteLine("--------------------------------------------------");
            Milestone1 milestone1 = new Milestone1();
            milestone1.Inicia();
        }
    }
}