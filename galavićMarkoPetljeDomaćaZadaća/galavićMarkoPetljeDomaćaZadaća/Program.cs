using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galavićMarkoPetljeDomaćaZadaća
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            Console.WriteLine("Unesi broj ocijena");
            broj = Int32.Parse(Console.ReadLine());
            int i;
          
            for (i = 0; i <= broj; i++)
            {
                Console.WriteLine(i);
                if (i == 1)
                {
                    Console.WriteLine("Projek je 1");
                }
               
            }
         
            Console.ReadKey();
        }
    }
}
