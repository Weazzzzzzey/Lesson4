using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandymams
{
    class Bandymai
    {
        public void Testavimas()
        {
            bool hell = default;
            byte a = 11, b = 22, c;
            c = (byte)(a + b);
            Console.WriteLine("Ats {0}",c);
            Console.WriteLine(hell);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Bandymai b = new Bandymai();
            b.Testavimas();
            Console.ReadKey();

        }
    }
}
