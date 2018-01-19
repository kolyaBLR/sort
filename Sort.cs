using System;

namespace sort
{
    class Sort
    {
        private int[] array;

        public Sort(int[] array)
        {
            this.array = array;
        }

        public void sort1(bool revert = false)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (!revert && array[i] > array[j] || revert && array[j] > array[i])
                    {
                        array[i] += array[j];
                        array[j] = array[i] - array[j];
                        array[i] -= array[j];
                    }
                }
            }
        }

        public void print()
        {
            Console.WriteLine("Печать массива начата.");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("Печать массива закончена.");
        }
    }
}