using System;
using System.IO;
using System.Linq;

namespace sort
{
    class IOFile
    {
        private StreamReader reader;
        private StreamWriter writer;

        public IOFile(string readPath, string writePath)
        {
            reader = new StreamReader(readPath);
            writer = new StreamWriter(writePath);
        }

        public int[] read()
        {
            string[] elements = reader.ReadToEnd().Split(" ");
            int[] results = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                results[i] = Convert.ToInt32(elements[i]);
            }
            return results;
        }

        public void write(int[] array) => writer.WriteLine(String.Join(" ", array));
    }
}