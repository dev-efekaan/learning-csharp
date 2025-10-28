using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatVeritipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float mindeger = float.MinValue;       // -3,402823E+38 --- 3,402823E+38 arası ondalılı değerleri kapsar
            float maxdeger = float.MaxValue;       // 4 byte yer kaplar

            float ondaliklisayi = 58.25f;

            Console.WriteLine(ondaliklisayi);

            Console.WriteLine(mindeger);
            Console.WriteLine(maxdeger);
            Console.ReadLine();                 
        }
    }
}
    