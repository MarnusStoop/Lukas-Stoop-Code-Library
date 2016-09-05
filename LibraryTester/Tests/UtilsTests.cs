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

            return;
            //string[] paths = { "" };
            //string[] extensionsExpected = { "" };

            //List<bool> results = new List<bool>();

            //for(int i = 0;i < paths.Length;i++)
            //{
            //    string currentPath = paths[i];
            //    string currentExtension = extensionsExpected[i];

            //    bool result = TestFileExtensionGetter(currentPath, currentExtension);

            //    results.Add(result);
            //}

            //DisplayResults(results, extensionsExpected);

        }

        private static void DisplayResults(List<bool> results, string[] extensionsExpected)
        {
            for(int i = 0;i < results.Count;i++)
            {

            }
        }

        private static string FormatResult(bool result, string extensionExpected)
        {
            return string.Format("");
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