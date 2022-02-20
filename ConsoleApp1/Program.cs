using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Convert.ToDouble(ReadLine()) == 4)
            {
                Write(1);
                ReadKey();
            }
            Write(0);
            ReadKey();
        }
    }
}
