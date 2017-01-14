using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Job, Task<int>> function = async x =>
            {
                Console.WriteLine("Starting... {0}", x.Name);
                await Task.Delay(x.Delay * 1000);   // do some aync task
                Console.WriteLine("Finished... {0}", x.Name);
                return x.Delay * 1000;
            };

            Task<int> first = function(new Job() { Name = "First", Delay = 5 });
            Task<int> second = function(new Job() { Name = "Second", Delay = 3 });
            Console.WriteLine("First elsaped time: {0}", first.Result);
            Console.WriteLine("Second elsaped time: {0}", second.Result);

            Console.Read();
        }

        public class Job
        {
            public string Name { get; set; }
            public int Delay { get; set; }
        }
    }
}
