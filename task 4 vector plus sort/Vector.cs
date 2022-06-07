using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vector
{
    class Vector
    {
        private int[] arr;


        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        public Vector() { }

        public void RandomInitialization(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
        }

        public void RandomInitialization()
        {
            //int index = Array.IndexOf(arr, 2);
            //Console.WriteLine(index);

            Random random = new Random();
            int x;
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i] == 0)
                {
                    x = random.Next(1, arr.Length + 1);
                    bool isExist = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (x == arr[j])
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                    {
                        arr[i] = x;
                        break;
                    }
                }
            }
        }

        public Pair[] CalculateFreq()
        {

            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pairs[i] = new Pair(0, 0);

            }
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if (arr[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = arr[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public bool IsArrPalindrom()
        {
            bool result = true;
            for (int i = 0; i < arr.Length - 1 / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                    result = false;
            }
            return result;
        }

        public void Reverse()
        {
            int temp;
            for (int i = 0; i < arr.Length - 1 - i; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        public string Continuity()
        {
            Pair count = new Pair(0, 1);
            Pair currentCount = new Pair(0, 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (count.Freq > arr.Length - i)
                    break;
                if (arr[i] == arr[i + 1])
                {
                    currentCount.Freq++;
                    currentCount.Number = arr[i];
                }
                else
                {
                    if (count.Freq < currentCount.Freq)
                    {
                        count.Freq = currentCount.Freq;
                        count.Number = currentCount.Number;
                        currentCount.Freq = 1;
                    }
                }
            }

            return count.ToString();
        }

        public int Length
        {
            get
            {
                return arr.Length;
            }
        }

        public void Bubble()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j + 1] > arr[i])
                    {
                        int item = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = item;
                    }
                }
            }
        }

        public void Counting()
        {
            if (arr.Length > 0)
            {
                int max = arr[0];
                int min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }

                int[] temp = new int[max - min + 1];

                for (int i = 0; i < arr.Length; i++)
                {
                    temp[arr[i] - min]++;
                }
                int k = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    for (int j = 0; j < temp[i]; j++)
                    {
                        arr[k] = i + min;
                        k++;
                    }
                }
            }
        }

        public enum Pivot { first, last, middle }
        public void QuickSort(int low, int high, Pivot pivot)
        {

            if (low < high)
            {
                int pivotIndex;
                pivotIndex = Partition(low, high, pivot);
                QuickSort(low, pivotIndex - 1, pivot);
                QuickSort(pivotIndex + 1, high, pivot);
            }

            //return new Vector(arr);
        }

        private int Partition(int low, int high, Pivot p)
        {
            int pivot;
            int i = low;
            int j = high;
// Краще switch і в enum значення з великої літери
            if (p == Pivot.first)
                pivot = arr[low];
            else if (p == Pivot.last)
                pivot = arr[high];
            else
                pivot = arr[(high + low) / 2];

            while (true)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;
                if (i >= j) return j;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }


        private void Merge(int left, int q, int right)
        {
            int i = left, j = q, k = 0;//k runs on temp
            int[] temp = new int[right - left];
            while (i < q && j < right)
            {
                if (arr[i] < arr[j])
                    temp[k] = arr[i++];
                else
                    temp[k] = arr[j++];
                k++;
            }

            if (i == q)
                for (int l = j; l < right; l++)
                    temp[k++] = arr[l];
            else
                while (i < q)
                {
                    temp[k] = arr[i];
                    k++; i++;
                }

            for (int l = 0; l < temp.Length; l++)
                arr[l + left] = temp[l];
        }

        public void SplitMergeSort(int start, int end)
        {
            if (end - start <= 1)
                return;
            int middle = (start + end) / 2;
            SplitMergeSort(start, middle);
            SplitMergeSort(middle, end);
            Merge(start, middle, end);
        }

        public void SplitMergeSort()
        {
            SplitMergeSort(0, arr.Length);
        }

        public void ReadFromFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            string str = reader.ReadLine();
        }

        public override string ToString()
        {
            return string.Join(" ", arr);
        }
    }
}
