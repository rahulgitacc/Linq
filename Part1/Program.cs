using System;
using System.IO;
using System.Linq;

namespace Part1
{
    internal class Program
    {
        private static void Main()
        {
            var filePath = @"C:\Users\rahul\Desktop\Pictures";
            TreditionalMethod(filePath);
            UseingLinqExpression(filePath);
            Console.Read();
        }

        /// <summary>
        /// UseingLinqExpression example
        /// </summary>
        /// <param name="filePath">File Path</param>
        private static void UseingLinqExpression(string filePath)
        {
            var filesList = new DirectoryInfo(filePath).GetFiles().OrderByDescending(x => x.Name).Take(10);
            foreach (var fileInfo in filesList)
                Console.WriteLine(fileInfo.Name);
        }

        /// <summary>
        /// TreditionalMethod example
        /// </summary>
        /// <param name="filePath">File Path</param>
        private static void TreditionalMethod(string filePath)
        {
            var directoryInfo = new DirectoryInfo(filePath);
            var getFiles = directoryInfo.GetFiles();
            var count = 0;
            foreach (var files in getFiles)
            {
                count++;
                //By ascending order
                Console.WriteLine(files.Name);
            }

            // By descending order
            for (var i = count - 1; i >= 0; i--)
                Console.WriteLine(getFiles[i].Name);

            Console.WriteLine($"Total number of files is {count}");
        }
    }
}
