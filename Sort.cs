using System;

namespace sort
{
    class Sort
    {
        private int[] array;

        public int[] Array { get => array; set => array = value; }

        public Sort(int[] array) => this.array = array;


        public void bubbleSort(bool revert = false)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (!revert && array[i] > array[j] || revert && array[j] > array[i])
                    {
                        swap(i, j);
                    }
                }
            }
        }

        //Cocktail sort
        //баг! первый и последние элементы не отсортированны
        public void sort2(bool revert = false)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                for (int i = left; i < right; i++)
                    if (array[i] > array[i + 1])
                        swap(i, i + 1);
                left++;
                for (int i = right; i > left; i--)
                    if (array[i - 1] > array[i])
                        swap(i - 1, i);
                right--;
            }
        }

        private void swap(int i, int j)
        {
            array[i] += array[j];
            array[j] = array[i] - array[j];
            array[i] -= array[j];
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