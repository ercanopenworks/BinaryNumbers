using System;
using System.Text;

namespace BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().TrimEnd());

            int res = convertAndGetNumbers(n);
            Console.WriteLine(res.ToString());
        }

        private static int convertAndGetNumbers(int n)
        {
            StringBuilder binaryForm = new StringBuilder();
            int resCount = 1, temp = 0, div = 0, maxCount = 1;
            while (true)
            {
                if (n < 2)
                {
                    binaryForm.Append(n.ToString());
                    break;
                }
                else
                {
                    div = n / 2;
                    temp = n - (div * 2);
                    binaryForm.Append(temp.ToString());
                    n = div;
                }
            }
            for (int i = 1; i < binaryForm.Length; i++)
            {
                if (binaryForm[i] == '1' && binaryForm[i - 1] == '1')
                {
                    resCount++;
                    maxCount=Math.Max(maxCount, resCount);
                }
                else resCount = 1;
                


            }

            return maxCount;
        }
    }
}
