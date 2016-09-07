using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSGCL.Misc;

namespace LibraryTester.Tests
{
    public static class UtilsTests
    {

        public static void RunTests()
        {
            bool isRight = TestFileExtensionGetter("settings.ini", "ini");
            Console.WriteLine(isRight.ToString());
        }

        private static bool TestFileExtensionGetter(string path, string extensionExpected)
        {
            bool isWorking = false;

            string extension = Util.GetFileExtension(path);
            Console.WriteLine("Returned extension: {0}", extension);
            Console.WriteLine("Expected extension: {0}", extensionExpected);
            if(extension.ToLower() == extensionExpected.ToLower())
            {
                isWorking = true;
            }

            return isWorking;
        }

    }
}