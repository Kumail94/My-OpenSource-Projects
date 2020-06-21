using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_algorithms
{
    class Box
    {
        private double length;
        private double width;
        private double height;
        private double volume;

        public void SetDimension(double len, double wid, double hei)
        {
            this.length = len;
            this.width = wid;
            this.height = hei;
            this.volume = this.length * this.width * this.height;

        }
        public double getDimension()
        {
            return this.volume;
        }

        public static Box operator +(Box a, Box b)
        {
            Box box = new Box();
            box.length = a.length + b.length;
            box.width = a.width + b.width;
            box.height = a.height + b.height;
            return box;

        }
        //public static bool operator >(Box a, Box b)
        //{
        //    bool result = false;
        //    if (a.length > b.length && a.width > b.width && a.height > b.height && a.volume > b.volume)
        //    {
        //        Console.WriteLine("Object a is greater than object b");
        //        result = true;
        //    }
        //    else

        //        return result;

        //}
        //public static bool operator <(Box a, Box b)
        //{
        //    bool result = false;
        //    if (a.length > b.length && a.width > b.width && a.height > b.height && a.volume > b.volume)
        //    {
        //        Console.WriteLine("Object a is greater than object b");
        //        result = true;
        //    }
        //    else

        //        return result;

        //}
        public static void duplication(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if ((A[i] == A[j]) /*&& (i != j)*/)
                    {
                        Console.Write("\n");
                        Console.Write("Duplicate Number =  " + A[j]);

                    }
                }
            }
        }
        public static void LargestNumber(int[] L)
        {
            int max = L[0];
            for (int i = 1; i < L.Length; i++)
            {
                if (L[i] > max)
                {
                    max = L[i];
                }
            }
        }
        public static void SumOfArray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write(" " + sum);
        }
        public static long VeryBigSum(long[] ar)
        {
            long i;
            long sum = 0;
            for (i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine(" " + sum);
            return sum;
        }
    }
    public class Based
    {
        protected string _Value;
        public Based()
        {
            _Value = "Master";
        }
        public void Do()
        {
            Console.WriteLine(_Value);
        }

    }
    class Derived : Based
    {
        public new virtual void Do()
        {
            Console.WriteLine("Test");
        }
    }
    class Matrix
    {
        public static List<long> getDistanceMetrics(List<int> arr)
        {
            List<long> lng = new List<long>();
            
            for (int i = 0; i <= 5; i++)
            {
                if (i == 0)
                {
                    arr[i] = (arr[i] - arr[i += 2]) + (arr[i] - arr[i += 3]);
                }
                else if (i == 1)
                {
                    arr[i] = (arr[i] - arr[i += 3]);
                }
                else if (i == 2)
                {
                    arr[i] = (arr[i] - arr[i -= 2]) + (arr[i] - arr[i += 1]);
                }
                else if (i == 3)
                {
                    arr[i] = (arr[i] - arr[i -= 3]) + (arr[i] - arr[i -= 1]);
                }
                else if (i == 4)
                {
                    arr[i] = (arr[i] - arr[i -= 3]);
                }
                else if (i == 5)
                {
                    arr[i] = arr[i -= 5];
                }
            }
        
            return lng.ToList();
        }
    }
}