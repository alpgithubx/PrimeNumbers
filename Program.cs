﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers2
{
    internal class Program
    {
        public static List<int> list = new List<int> ();
        static void Main(string[] args)
        {
            for(int i = 2; i <= 10000; i++)
            {
                if ((i > 2 && i % 2 == 0) || (i > 3 && i % 3 == 0) || (i > 5 && i % 5 == 0) || (i > 7 && i % 7 == 0))
                {
                }
                else
                {
                    if (!Kontrol(i)) continue;
                    list.Add(i);
                    Console.WriteLine($"{i} asal sayıdır.") ;

                } 
            }
            Console.ReadKey();
        }

        static bool Kontrol(int i) {
            bool durum = true;
            foreach(int sayi in list)
            {
                if(sayi != i && i % sayi == 0)
                {
                    durum = false;
                    break;
                }
            }
            return durum;
        }
    }
}
