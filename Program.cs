using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmaneHack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Starting AutoWebClicker scrtipt...");

            SuiteTests st = new SuiteTests();
            st.CollectPoints();


            Console.WriteLine("Finished AutoWebClicker script...");
        }
    }
}
