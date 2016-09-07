using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LSGCL.DataHandlers;

namespace LSGCL.Misc
{
    public static class csvFileHandler
    {

        public static List<List<string>> Read(string filepath, char delimiter = ',')
        {

            List<List<string>> linesData = new List<List<string>>();
            List<string> lines = FileHandler.Read(filepath);

            foreach(string line in lines)
            {
                List<string> lineData = new List<string>();
                string[] splitLine = line.Split(delimiter);

                foreach(var item in splitLine)
                {
                    lineData.Add(item);
                }

                linesData.Add(lineData);
            }

            return linesData;
        }

        public static void Write(string filepath, List<List<string>> data, char delimiter = ',')
        {
            List<string> formattedData = new List<string>();

            foreach(List<string> item in data)
            {
                string formattedLine = FormatLine(item, delimiter);

                formattedData.Add(formattedLine);
            }

            FileHandler.Write(formattedData, filepath);
        }

        private static string FormatLine(List<string> data, char delimiter = ',')
        {
            string formattedString = "";

            foreach(string item in data)
            {
                formattedString = string.Format("{0}{1}{2}", formattedString, delimiter, item);
            }

            return formattedString;
        }

    }
}