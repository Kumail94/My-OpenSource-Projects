using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Data_Structures_and_algorithms
{
    class Program
    {
        private Program()
        {
            Console.WriteLine("Hello Main Class Constructor");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            //Polymorphism poly = new Polymorphism();
            //Console.WriteLine(" " + poly.MethodA(-3, 89));
            Console.WriteLine("\n Enter any words");
            string words = Console.ReadLine();
            int len = words.Length;
            string reverseWords = " ";
            for (int w = len-1; w >= 0; w--)
            {
                reverseWords += words[w];
            }
            Console.WriteLine("\n Original Words {0} " , words);
            Console.WriteLine("\n Reverse Words {0} ", reverseWords);
            Console.ReadKey();

            MethodOverriding m = new MethodOverriding();
            Console.WriteLine(" " + m.MethodA(-25, 80));
            Console.ReadKey();
            //FactoryPattern.FactoryMainMethod();
            //Console.ReadKey();
            SingltonPattern.SingltonMainMethod();
            Console.ReadKey();
            Based based = new Derived();
            based.Do();
            Console.ReadKey();
            long[] Big = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            Box.VeryBigSum(Big);
            Console.ReadKey();
            int[] Arr = { 1, 5, 2, 7, 4, 3 };
            Box.SumOfArray(Arr);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Number:");
            int ft = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Factorial Series Using Recurrsion:");
            for (int i = 0; i <ft; i++)
            {
                Console.Write(RecurrsionFactorial(i));
            }
           // Console.WriteLine(" " + n);
            Console.ReadKey();



            Console.WriteLine("\n Enter a Number:");
            int nos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Fibonacci Series Using Recurrsion:");
            for (int i = nos; i > 1 ; i--)
            {
                Console.Write(RecusrrsionFibonacciSeries(i));
            }
            Console.ReadKey();


            Box box = new Box();
            box.SetDimension(13.5, 9.5, 10);
            Console.WriteLine("\n Volume : {0} ", box.getDimension());
            Console.ReadKey();
            Console.WriteLine("\n Enter a Number:");
            int nos1 = Convert.ToInt32(Console.ReadLine());
            int reversed = ReversedNumber(nos1);
            Console.WriteLine("\n Entered Number: {0} \n Reversed Number: {1}", nos1, reversed);
            Console.ReadKey();

            Console.WriteLine("\nCheck the Largest numbers of an array");
            int[] Largest = { 2, 3, 4, 5, 2, 1, 3, 5, 4 };
            Box.LargestNumber(Largest);
            Console.ReadKey();

            Console.WriteLine("\nCheck the Duuplicate numbers of an array");
            int[] duplication = { 2, 3, 4, 5, 2, 1, 3, 5, 4 };
            Box.duplication(duplication);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Number:");
            int nos2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Pyramid Series:");
            int pyramid = Convert.ToInt32(PyramidSeries(nos2));
            Console.WriteLine(pyramid);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Number:");
            int nos3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Sum of the series");
            int series = Series(nos3);
            Console.WriteLine("{0} ", series);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Decimal Number:");
            int nos4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Decimal to Binary Conversion:");
            int Binary = Convert.ToInt32(BinaryNumbers(nos4));
            Console.WriteLine("\n Decimal Number: {0} \n Binary Number: {1} ", nos4, Binary);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Binary Number:");
            int nos5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Binary to Decimal Conversion:");
            int DecimaL = Convert.ToInt32(DecimalNumber(nos5));
            Console.WriteLine("\n Binary Number: {0} \n Decimal Number: {1} ", nos5, DecimaL);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Number:");
            int nos6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Total Sum of Digits using Recurrsion:");
            int sumofDigits = Convert.ToInt32(RecusrrsionSumOfDigits(nos6));
            Console.WriteLine(sumofDigits);
            Console.ReadKey();

            Console.WriteLine("\n Enter a Number:");
            int nos7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Factorial Using Recurrsion:");
            for (int i = nos7; i > 0; i--)
            {
                int factorial = Convert.ToInt32(RecurrsionFactorial(i));
                Console.WriteLine(" !" + factorial);
            }
            Console.ReadKey();

            Console.WriteLine("\n Enter a First Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Enter a Second Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Swapping between two numbers:");
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("\n {0} and {1} ", n1, n2);
            Console.ReadKey();

            Console.WriteLine("\n");
            int[] Linear = { 5, 3, 1, 8, 9, 4, 2, 7, 6 };
            Console.WriteLine("\n Linear Search:");
            int lin = Convert.ToInt32(LinearSearch(Linear, 9, 9));
            Console.WriteLine("  " + lin);
            Console.ReadKey();

            Console.WriteLine("\n");
            int[] binary = { 5, 3, 1, 8, 9, 4, 2, 7, 6 };
            Console.WriteLine("\n Binary Search:");
            int bin = Convert.ToInt32(BinarySearch(binary, 9, 6));
            Console.WriteLine("  " + bin);
            Console.ReadKey();

            int[] bubble = { 5, 3, 1, 8, 9, 4, 2, 7, 6 };
            Console.WriteLine("\n Bubble Sort:");
            BubbleSort(bubble, 9);
            for (int i = 0; i < bubble.Length; i++)
                Console.Write("  " + bubble[i]);
            Console.ReadKey();

            Console.WriteLine("\n");
            int[] modified = { 50, 3, 14, 8, 9, 4, 26, 37, 6 };
            Console.WriteLine("\n Modified Sort:");
            ModifiedSort(modified, 8);
            for (int i = 0; i < modified.Length; i++)
            {
                Console.Write("  " + modified[i]);
            }
            Console.ReadKey();

            Console.WriteLine("\n");
            int[] selection = { 5, 8, 2, 3, 4, 9, 6, 7, 1 };
            Console.WriteLine("\n Selection Sort:");
            int LOCATION, MINIMUM;
            for (int i = 0; i < selection.Length; i++)
            {
                MINIMUM = selection[i];
                LOCATION = SelectionSort(selection, i, 9);
                selection[i] = selection[LOCATION];
                selection[LOCATION] = MINIMUM;
            }
            for (int j = 0; j <= 7; j++)
            {
                Console.Write("  " + selection[j]);
            }
            Console.ReadKey();

            Console.WriteLine("\n");
            int[] Insertion = { 4, 2, 8, 6, 9, 3, 5, 1, 7 };
            Console.WriteLine("\n Insertion Sort:");
            InsertionSort(Insertion, 9);
            for (int i = 0; i < Insertion.Length - 1; i++)
            {
                Console.Write("  " + Insertion[i]);
            }
            Console.ReadKey();

            Console.WriteLine("\n");
            Console.WriteLine("\n Delegates:");
            CircleArea circle = new CircleArea(GetCircle);
            CircleArea square = new CircleArea(GetSquare);
            Console.WriteLine(" Area of Circle: " + circle.Invoke(24));
            Console.WriteLine(" Area of Square: " + square.Invoke(50));
            Console.ReadKey();

            Console.WriteLine("\n");
            Console.WriteLine("\n Lamda Expressions:");
            List<int> myList = new List<int> { 5, 3, 7, 9, 1, 2, 8, 4, 6 };
            List<int> evenNumbers = myList.Where(n => n % 2 == 0).ToList();
            Console.WriteLine("\n Even Numbers:");
            foreach (var item in evenNumbers)
            {
                Console.Write("   " + item);
            }
            Console.ReadKey();

            Console.WriteLine("\n Reversed String:");
            string reverse = ReveredString("Kumail");
            Console.Write("   " + reverse);
            Console.ReadKey();


        }

        public delegate double CircleArea(int area);

        public static double GetCircle(int radius)
        {
            return (3.14 * radius * radius);
        }
        public static double GetSquare(int sq)
        {
            return (sq * sq);
        }

        public static string ReveredString(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i > 0; i--)
            {
                reversed = str[i].ToString();
            }
            return (reversed);
        }
        public static int ReversedNumber(int num)
        {
            int reversed, rev = 0, TEMP;
            TEMP = num;
            while (num > 0)
            {
                reversed = num % 10;
                rev = rev * 10 + reversed;
                num /= 10;
            }
            num--;
            if (TEMP == rev)
            {
                Console.WriteLine("\n This is Palindrone Number:");
            }
            else
            {
                Console.WriteLine("\n This is not a Palindrone Number:");
            }
            return (rev);
        }
        public static int PyramidSeries(int len)
        {
            for (int i = 1; i <= len; i++)
            {
                for (int j = 1; j <= i; j++)

                    Console.Write("  " + j);
                Console.Write("\n");
            }
            return len;
        }
        public static int Series(int S)
        {
            int t = 1, sum = 0;
            while (S > 0)
            {
                sum += t;
                Console.Write(" " + t);
                t = t * 10 + 1;
                S--;
            }
            Console.WriteLine("\n Sum of the Digits is {0} ", sum);

            return (sum);
        }

        public static int BinaryNumbers(int deci)
        {
            int binary = 0, i = 1, remainder;
            while (deci > 0)
            {
                remainder = deci % 2;
                deci /= 2;
                binary += remainder * i;
                i *= 10;
            }
            return (binary);
        }

        public static double DecimalNumber(int bin)
        {
            double sum = 0;
            int i = 0;
            while (bin > 0)
            {
                sum = sum + Math.Pow(2, i) * (bin % 10);
                bin /= 10;
                i += 1;
            }
            return (sum);
        }

        public static int RecurrsionFactorial(int N)
        {
            int factorial = 1;
            if (N == 1)
            {
                return N;
            }
            else
            {
                factorial = N * RecurrsionFactorial(N - 1);
            }
            return (factorial);
        }

        public static int RecusrrsionFibonacciSeries(int fib)
        {

            if (fib == 1 || fib == 2)
            {
                return 1;
            }
            return (RecusrrsionFibonacciSeries(fib - 1) + RecusrrsionFibonacciSeries(fib - 2));
        }
        public static int RecusrrsionSumOfDigits(int s)
        {
            int sum = 0;
            if (s == 1)
            {
                return 1;
            }
            else
            {
                sum = s + RecusrrsionSumOfDigits(s - 1);
            }
            return (sum);
        }

        public static int LinearSearch(int[] Linear, int N, int item)
        {
            for (int i = 0; i < N; i++)
            {
                if (item == Linear[i])
                {
                    Console.WriteLine("\n Item Found , on the index of " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("\n Item not Found:");
                }
            }
            return (item);
        }
        public static int BinarySearch(int[] Binary, int N, int item)
        {
            int lowest, upper, mid;
            lowest = 0;
            upper = N - 1;
            mid = lowest + upper / 2;
            for (int i = 0; i < N; i++)
            {
                if (Binary[i] == item)
                {
                    Console.WriteLine("\n Item Found");
                }
                else if (item > Binary[i])
                {
                    lowest = mid + 1;
                }
                else
                {
                    upper = mid - 1;
                }
            }
            return (item);
        }
        public static void BubbleSort(int[] A, int N)
        {
            int temporary;
            for (int round = 1; round <= N; round++)
            {
                for (int index = 0; index < A.Length-1; index++)
                {
                    if (A[index + 1] < A[index])
                    {
                        temporary = A[index + 1];
                        A[index + 1] = A[index];
                        A[index]= temporary;
                    }
                }
            }
        }
        public static int SelectionSort(int[] A, int index, int N)
        {
            int MIN, LOC;
            MIN = A[index];
            LOC = index;
            for (int i = index + 1; i < N; i++)
            {
                if (MIN > A[i])
                {
                    MIN = A[i];
                    LOC = i;
                }
            }
            return (LOC);
        }
      public static void ModifiedSort(int[]A , int N)
        {
            int count,temp;
            for (int round = 1; round <=N; round++)
            {
                count = 0;
                for (int i = 0; i < A.Length-1; i++)
                {
                    if (A[i + 1] < A[i])
                    {
                        count = 1;
                        temp = A[i + 1];
                        A[i + 1] = A[i];
                        A[i] = temp;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine("\n total Round = {0}", round);
                }
            }
        }
        public static void InsertionSort(int []A , int n)
        {
            int temporary;
            for (int round = 1; round < n; round++)
            {
                temporary = A[round];
                for (int index = round - 1; index >= 0 && temporary < A[index]; index--)
                {
                    A[index + 1] = A[index];
                    A[index + 1] = temporary;
                }
            }
        }
        
    }
}
        