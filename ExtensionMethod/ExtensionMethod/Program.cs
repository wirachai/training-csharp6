using ExtensionMethod.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            Console.WriteLine(str.IsNull());
            str = "test";
            Console.WriteLine(str.IsNull());
            List<int> numbers = new List<int>();
            Console.WriteLine(numbers.IsNull());

            Console.Read();
        }
    }
}
