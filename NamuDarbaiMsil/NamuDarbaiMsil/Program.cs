﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NamuDarbaiMsil
{
    
    public class CiklaiMail
    {

        public void Desimtukas()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Deividas {0}", i+1);
            }
        }

        public void DesimtukasNumb()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void NumbSum()
        {

            int Start = 10;
            int Pabaiga = 20;
            int Sum = 0;

            for (int i = Start; i < Pabaiga + 1; i++)
            {
                Sum = Sum + i; 
            }
            Console.WriteLine("Skaiciaus {0} ir {1} suma yra: {2}",Start,Pabaiga,Sum);
        }

        public void Simtukas()
        {

            const int iki = 100;

            for (int i = 0; i < iki + 1; i++)
            {
                if(i % 3 == 0)
                Console.WriteLine("Skaiciai dalijasi is 3 be liekanos: {0}",i);
            }
        }

        public void Trikampis()
        {

            const int iki = 5;
            Console.Clear();

            for (int i = 0; i < iki; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void Dlentele()
        {

            const int iki = 10+1;
            Console.Clear();

            for (int i = 1; i < iki; i++)
            {
                for (int j = 1; j < iki; j++)
                {
                    Console.Write("{0}*{1}={2} ", i,j,j*i);
                }
                Console.WriteLine();
            }
        }
    }

    public class Masyvai
    {

        public void Isvedimas()
        {
            int[] Arr = {1,2,3,4,5 };
            int Sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                Sum = Sum + Arr[i];
            }

            Console.WriteLine("Suma: {0}",Sum);

            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }

        }

        public void Raidinis()
        {
            string[] Arr = { "a", "b", "c","d","e"};


            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }

            for (int i = Arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(Arr[i]);
            }
        
        }

        public void Vardas()
        {
            string Vardas = "Deividas";

            for (int i = 0; i < Vardas.Length; i++)
            {
                Console.WriteLine(Vardas[i]);
            }

            for (int i = Vardas.Length-1; i >= 0; i--)
            {
                Console.WriteLine(Vardas[i]);
            }

        }

        public void Randomizeris()
        {

            Random rnd = new Random();
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1000);
            }

            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
        }

        public void Kopijavimas()
        {
            int[] arr = new int[5];
            int[] acc = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int Ivedimas = 0;

                if(int.TryParse(Console.ReadLine(), out Ivedimas))
                {
                    arr[i] = Ivedimas;
                }
                else
                    Console.WriteLine("Ivestas nekorektiskas skaicius, kuris buvo pakeistas i 0");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                acc[i] = arr[i];
            }

            Array.Sort(acc);
            //Array.Reverse(acc);
            foreach (var item in acc)
            {
                Console.Write("{0} ", item);
            }
        }

        public void TwoInOne()
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            int[] arr3 = new int[6];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = arr2.Length; i < arr3.Length; i++)
            {
                arr3[i] = arr2[i-arr2.Length];
            }

            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }
        }

        public void VardaiArr()
        {
            string[] Vardai10 = {"Vardas1" , "Vardas2", "Vardas3", "Vardas4", "Vardas5", "Vardas6", "Vardas7", "Vardas8", "Vardas9", "Vardas10" };
            string[] Vardai8 = new string[8];
            int skaitiklis = 0;

            for (int i = 0; i < Vardai10.Length; i++)
            {
                if (i == 5 || i == 7)
                {
                    skaitiklis--;
                }

                Vardai8[i + skaitiklis] = Vardai10[i];
                
            }

            foreach (var item in Vardai8)
            {
                Console.WriteLine(item);
            }
        }
    }
    

    public class Papildomi
    {
        public void VirM()
        {
            string[] Zmones =
            { 
                "Beyonce(m)", 
                "David Bowie(v)",
                "Elvis Costello(v)",
                "Madonna(m)",
                "Elton John(v)",
                "Charles Aznavour(v)"
            };

            Console.WriteLine("Vyrai:");
            for (int i = 0; i < Zmones.Length; i++)
            {
                if (Zmones[i].Contains("(v)"))
                {
                    Console.WriteLine(Zmones[i]);
                }
            }
            Console.WriteLine("Moterys:");
            for (int i = 0; i < Zmones.Length; i++)
            {
                if (Zmones[i].Contains("(m)"))
                {
                    Console.WriteLine(Zmones[i]);
                }
            }

        }

        public void Futbolas()
        {
            string results = " Manchester United 1 Chelsea 0, Arsenal 1 Manchester United 1, Manchester United 3 Fulham 1, Liverpool 2 Manchester United 1, Swansea 2 Manchester United 4";
            string[] Games = results.Split(',');
            
            foreach (var item in Games)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Games: {0}", Games.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            CiklaiMail Ciklas = new CiklaiMail();
            Masyvai Mas = new Masyvai();
            Papildomi P = new Papildomi();
            P.Futbolas();
            
            Console.ReadKey();

        }
    }
}
