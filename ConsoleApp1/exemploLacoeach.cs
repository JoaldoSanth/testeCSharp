using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class exemploLacoeach
    {
        public static void Main(string[] args)
        {
            string[] time = { "santos", "corinthians", "palmeiras", "são paulo" };
            foreach (string i in time)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
