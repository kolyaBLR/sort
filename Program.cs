using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            IOFile file = new IOFile("numbers.txt", "result.txt");
            Sort sort = new Sort(file.read());
            sort.bubbleSort();
            file.write(sort.Array);
        }
    }
}
