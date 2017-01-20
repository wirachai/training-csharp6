using CSharp6.Logger;
using System;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();

            try
            {
                logger.Write(LogLevel.Trace, "Start at " + DateTime.Now);

                int y = 0;
                int x = 10 / y;

                logger.Write(LogLevel.Trace, "Finish at " + DateTime.Now);
            }
            catch (Exception ex)
            {
                logger.Write(LogLevel.Error, ex);
            }

            Console.Read();
        }
    }
}
