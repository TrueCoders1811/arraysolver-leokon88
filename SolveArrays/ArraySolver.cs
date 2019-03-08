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
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
