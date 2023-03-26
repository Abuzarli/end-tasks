/* using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arrnum = { 7, 0, 3, 4, 2, 5, 9, };
            int num = 7;
            Console.WriteLine(arr(arrnum, num));
        }
        public static int arr(int[] myarr, int num)
        {
            int count = 0;
            for (int i = 0; i < myarr.Length; i++)
            {
                for (int j = i + 1; j < myarr.Length; j++)
                {
                    if ((myarr[i] + myarr[j]) == num)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

}*/





/*  using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            pipe(number);
        }
        public static void pipe(int num)
        {
            string pipes = "";
            string space = "";
            for (int i = 0; i < num; i++)
            {
                pipes = pipes + "|";
                for (int j = i; j < num - 1; j++)
                {
                    space = space + " ";
                }
                Console.WriteLine(space + pipes);
                space = "";
            }
        }
    }
} */


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            Console.WriteLine(Repeat(numArr));
        }

        public static int Repeat(int[] arr)
        {
            int num = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    num = arr[i];
                }
                count = 0;
            }

            return num;
        }
    }
}