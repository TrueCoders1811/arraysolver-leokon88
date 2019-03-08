using System;
using System.Collections.Generic;

namespace SolveArrays
{
    public class ArraySolver
    {
        public int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
           
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;

        }

        public double AverageEvens(int[] numbers)
        {
            // [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
            double sum = 0;
            int count=0;
            double avg = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
                else
                {
                    sum = 0;
                    count = 1;
                }
               
            }
         
                avg = sum / count;
           
            Console.WriteLine(sum);
               Console.WriteLine(count);
               Console.WriteLine(avg);
            return avg;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            //int sum = 0;
            //int count = 0;
            //int avg = 1;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 = 0)
            //    {
            //        sum += numbers[i];
            //        count++;
            //    }
            //    if (sum != 0 && count != 0)
            //    {
            //        avg = sum / count;
            //    }
            //    Console.WriteLine(sum);
            //    Console.WriteLine(count);
            //    Console.WriteLine(avg);
            //}
            //return avg;

            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
