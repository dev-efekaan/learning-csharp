using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongVeritipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sayı1 = 54684684;
            long maxdeger = long.MaxValue;
            long mindeger = long.MinValue;

            Console.WriteLine(maxdeger); //9223372036854775807,  - 9223372036854775808 long veri tipi bu iki sayı arasını kapsar
            Console.WriteLine(mindeger); // 8 byte yer kaplar

            Console.WriteLine(sayı1);
            Console.ReadLine(); 


        }
    }
}
