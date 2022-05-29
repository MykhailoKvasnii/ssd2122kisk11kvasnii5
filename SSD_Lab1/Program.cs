using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace SSD_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO");
            DateTime time = DateTime.Now;
            string format = "MMM ddd d HH:mm yyyy";
            Console.WriteLine(time.ToString(format));

        }

    }
}
