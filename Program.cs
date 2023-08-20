using System;
using System.Collections.Generic;

namespace integer_ikililerinin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n tane integer sayı giriniz(sayıların arasına boşluk ekleyerek): ");
            string input = Console.ReadLine();

            string[] nums = input.Split(' ');
            Dictionary<int, int> output = new Dictionary<int, int>();
            int c = 0;

            for (int i = 0; i < nums.Length; i += 2)
            {
                int num1 = int.Parse(nums[i]);
                int num2 = int.Parse(nums[i + 1]);
                int sum = num1 + num2;

                if (num1 == num2)
                {
                    output.Add(c, sum * sum);
                }
                else
                {
                    output.Add(c, sum);
                }
                c++;
            }

            foreach (var item in output)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
