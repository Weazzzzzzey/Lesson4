﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai
{
    public class Masyvai
    {
        public void MasyvasF()
        {

            string[] SavaitesD =
            {
                "Pirmadienis",
                "Antradienis",
                "Treciadienis",
                "Ketvirtadienis",
                "Penktadienis",
                "Sestadienis",
                "Sekmadienis"
            };

            Console.WriteLine(SavaitesD[2]);

            SavaitesD[2] = "TRECIADIENIS";

            Console.WriteLine(SavaitesD[2]);

            /*
            foreach(string diena in SavaitesD)
            {
                Console.WriteLine(diena);
            }

            for (int i = 0; i < SavaitesD.Length;i++)
            {
                Console.WriteLine(SavaitesD[i]);
            }
            */
            Console.ReadKey(); 
        }

        public void uzpildymas()
        {
            int[] skaiciai = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(1, 100);
            }

            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Masyvai M = new Masyvai();
            //M.MasyvasF();
            M.uzpildymas();
        }
    }
}
