using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryTester.Tests;

namespace LibraryTester
{
    class Program
    {
        static void Main(string[] args)
        {
            UtilsTests.RunTests();

            Console.Read();
        }
    }
}