using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ArrayPairSum
{
    public void ArrayPairSumFunction(int[] nums)
    {
        // runs correctly
        int sum = 0;

        for (int n = 0; n < nums.Length; n = n + 2)
        {
            int[] temp = new int[2];
            temp[0] = nums[n];
            temp[1] = nums[n + 1];

            sum = sum + temp.Min();
        }

        Console.WriteLine(sum);
    }
}