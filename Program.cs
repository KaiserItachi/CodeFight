using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 6,2,3,8};
            //var output = adjacentElementsProduct(inputArray);
            var output = makeArrayConsecutive2(inputArray);

            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        static int adjacentElementsProduct(int[] inputArray)
        {
            var len = inputArray.Length / 2;
            var end = inputArray.Length - 1;
            var max = inputArray[0] * inputArray[1];
            for (int i = 0; i < len; i++)
            {
                if (inputArray[i] * inputArray[i + 1] > max)
                {
                    max = inputArray[i] * inputArray[i + 1];
                }

                if (inputArray[end] * inputArray[end - 1] > max)
                {
                    max = inputArray[end] * inputArray[end - 1];
                }
            }

            return max;
        }

        static int shapeArea(int n)
        {
            int area = 1;

            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    var j = i - 1;
                    area = area + (4 * j);

                }
            }
            else
            {
                area = 0;
            }

            return area;
        }

        //static bool sumOfTwo(int[] a, int[] b, int v)
        //{
        //    var result = false;
        //    var c = b.OrderByDescending(x=>x).ToArray();
        //    var len = c.Length / 2;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        var r = v - a[i];

        //        if (c[0] >= r)
        //        {
        //            for (int j = 0; j < len; j++)
        //            {
        //                {
        //                    if(c[j]< r)
        //                    {
        //                        break;
        //                    }
        //                    else if(c[j]==r)
        //                    {
        //                        result = true;
        //                        break;
        //                    }
        //                }
        //            }

        //            if(c[len]>=r || !result)
        //            {
        //                for(int k=len; k<c.Length; k++)
        //                {
        //                    if (c[k] < r)
        //                    {
        //                        break;
        //                    }
        //                    else if (c[k] == r)
        //                    {
        //                        result = true;
        //                        break;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return result;
        //}

        static bool sumOfTwo(int[] a, int[] b, int v)
        {
            var result = false;
            var c = b.OrderByDescending(x => x).ToArray();
            var d = a.OrderByDescending(x => x).ToArray();
            int len = 0;
            if (c.Length >= d.Length)
                len = c.Length;
            else
                len = d.Length;

            

            return result;
        }

        static int makeArrayConsecutive2(int[] statues)
        {
            QuickSort(statues);
            //statues = statues.OrderBy(x => x).ToArray();
            var rem = 0;
            for (int i = 0; i < statues.Length; i++) 
            {
                var index = i + 1;

                if(index < statues.Length)
                {
                    var diff = statues[index] - statues[i];
                    if (diff > 1)
                    {
                        rem = rem  + (diff - 1);
                    }
                }
            }

            return rem;
        }

        private static void QuickSort(int[] a)
        {
            var end = a.Length - 1;

            Partition(a, 0, end);
        }

        private static void Partition(int[] a, int start, int end)
        {
            if (start < end)
            {
                var pivot = a[end];
                var lIndex = start;
                var uIndex = end;

                while (lIndex < uIndex)
                {
                    while (a[lIndex] < pivot)
                    {
                        lIndex++;
                    }

                    while (a[uIndex] > pivot)
                    {
                        uIndex--;
                    }

                    var temp = a[lIndex];
                    a[lIndex] = a[uIndex];
                    a[uIndex] = temp;
                }

                Partition(a, start, uIndex);
                Partition(a, lIndex + 1, end);
            }
        }
    }
}
