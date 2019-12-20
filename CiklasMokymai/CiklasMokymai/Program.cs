using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklasMokymai
{
    public class DienosDarbas4
    {

        public void Ciklas()
        {
            for (int i = 10-1;i>=0;i--)
            {
                Console.WriteLine("I reiksmes: {0}", i);
            }

            Console.ReadKey();
        }


    } 
    
    class Program
    {
        static void Main(string[] args)
        {
            DienosDarbas4 D1 = new DienosDarbas4();
            D1.Ciklas();
        
        }
    }
}
