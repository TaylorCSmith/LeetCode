using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _476NumberComplement
{
    class SolutionClass
    {
        public void getCompliment(int n) {

            String binary = Convert.ToString(n, 2);

            // confirming that change from int to binary representation in a string
            // Console.WriteLine(binary);

            int[] binNum = binary.Select(c => int.Parse(c.ToString())).ToArray();

            // confirming that conversion to an array worked
            // Console.WriteLine(binNum[0]);

            for (int i = 0; i < binNum.Length; i++)
            {
                if(binNum[i] == 0)
                {
                    binNum[i] = 1;
                } else
                {
                    binNum[i] = 0;
                }
            }

            // confirming that switch to compliment worked (could have used foreach loop instead)
            // Console.WriteLine(binNum[0]);

            string compliment = string.Join("", binNum);

            // confirming that joining array into a string worked
            // Console.WriteLine(compliment);

            int decComp = Convert.ToInt32(compliment, 2);

            Console.WriteLine(decComp);
        }
    }
}
