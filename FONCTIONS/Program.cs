using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FONCTIONS
{
    internal class Program
    {
        static int absolue (int a)
        {
            if (a < 0) return -a;
            
           else return a;
        }
        
        static void Main(string[] args)
        {
            int a;
            
            Console.WriteLine("Mets un nombre entier");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("le nombre est {0}", a);

            Console.WriteLine("La valeur absolue est {0}",absolue(a));
        }
    }
}
