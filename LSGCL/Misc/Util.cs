using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSGCL.Misc
{
    /// <summary>
    /// 
    /// </summary>
    public static class Util
    {

        public static bool CheckIfPathIsValid(string path, string expectedExtension)
        {
            bool isExtensionValid = false;

            string extension = GetFileExtension(path);

            if(extension.ToLower() == expectedExtension.ToLower())
            {
                isExtensionValid = true;
            }

            bool isPathValid = File.Exists(path);

            return isExtensionValid && isPathValid;
        }

        public static string GetFileExtension(string filePath)
        {
            int lastDotIndex = filePath.LastIndexOf('.');

            string extension = filePath.Substring(lastDotIndex + 1);

            return extension;
        }

    }
}