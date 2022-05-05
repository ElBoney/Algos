using System;

namespace TwoSum
{
    class TwoSums
    {
        static void Main(string[] args)
        {
            int[] testOne = { 3, 7, 2, 9, 0, 8 };
            int[] testTwo = { 1, 5, 7, 1, 3, 4 };
            int[] testThree = { 14, 32, 18, 5 };
            int ansOne = 9;
            int ansTwo = 2;

            int[] firstTry = TwoSumTest(testOne, ansOne);
            Console.WriteLine($"[{firstTry[0]}, {firstTry[1]}]");
            //the correct answer shoulb be [1, 2]

            int[] secondTry = TwoSumTest(testTwo, ansTwo);
            Console.WriteLine($"[{secondTry[0]}, {secondTry[1]}]");
            //the correct answer should be [0, 3]

            int[] thirdTry = TwoSumTest(testThree, ansOne);
            Console.WriteLine($"[{thirdTry[0]}, {thirdTry[1]}]");
            //the correct answer should be [-1, -1]
            Console.ReadKey(true);
        }


        public static int[] TwoSumTest(int[] nums, int target)
        {
            foreach (int i in nums)
            {
                int targetDif = target - i;
                int iIndex = Array.IndexOf(nums, i);
                int ansIndex = Array.IndexOf(nums, targetDif, iIndex + 1);
                
                int[] answer = new int[] { iIndex, ansIndex };
                if(ansIndex != -1)
                {
                return answer;

                }
            }
            int[] stuff =  { -1, -1};
            return stuff;
        }
    }

}
