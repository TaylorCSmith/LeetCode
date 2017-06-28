using System;

namespace _561ArrayPartition1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayPairSum problem1 = new ArrayPairSum();

            int[] nums = { 2, 1, 4, 5, 1, 4, 1, 3, 5, 2};

            problem1.ArrayPairSumFunction(nums); // works but need to add exception if array has an odd number of elements



        }
    }
}