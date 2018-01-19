using System;

namespace sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {2, 3, 41, -21, -2, 0, 23, -42, -21, 3421, 21, -43};
            Sort sort = new Sort(array);
            sort.print();
            sort.sort1();
            sort.print();
        }
    }
}
