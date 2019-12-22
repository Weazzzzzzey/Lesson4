using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvoApvertimas
{ 
    public class ZodziaiSakinyje 
    {
        
        public void Apvertimas()
        {
            string Sakinys = "Hello world my name is Central park";
            string[] MasZ = Sakinys.Split(' ');
            
            foreach(var a in MasZ.Reverse())
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
            ZodziaiSakinyje M = new ZodziaiSakinyje();
            M.Apvertimas();
        }
    }
}
