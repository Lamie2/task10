using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //int[] nums = { 7, 9, 14, 5 };
            //AddToArray(ref nums, 8);
            //Console.WriteLine(nums);
            #endregion

            #region task3

            //Console.WriteLine("zehmet olmasa eded daxil edin");
            //int number = Convert.ToInt32(Console.ReadLine());
            //FindSqrtRoot(ref number);
            ////Console.WriteLine(FindSqrtRoot (ref number));
            #endregion


            Console.Write("Eded daxil edin: ");
           int num = Convert.ToInt32(Console.ReadLine());
            int Number = FindNewNumber(num, 8);
            Console.WriteLine(Number);


        }




        #region task1 method
        //    static void AddToArray(ref int[] arr, int val)
        //{
        //    //int[] newArr = new int[arr.Length + 1];
        //    //for (int i = 0; i < arr.Length; i++)
        //    //{
        //    //    newArr[i] = arr[i];
        //    //}
        //    //newArr[arr.Length] = val;
        //    

        //}
        #endregion

        #region task3 method

        static int FindSqrtRoot(ref int number)
            {
                int root = 0;
                if (number > 0)
                {
                    for (int i = 0; i * i <= number; i++)
                    {
                        root = i;
                    }
                }

                return root;

            }
            #endregion


        static int FindNewNumber(int num, int digit)
        {
            int newNumber = 0;
            int LastNum = 0;
            int x = 1;
            int i = 1;

            LastNum = num % 10;
            num = (num - LastNum) / 10;

            while (i<digit)
            {
                x *= 10;
                i++;
            }
            newNumber = (LastNum * x) + num;
            return newNumber;
        }
        






    }
}
