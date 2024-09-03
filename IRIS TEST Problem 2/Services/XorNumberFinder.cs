using IRIS_TEST_Problem_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS_TEST_Problem_2.Services
{
    internal class XorNumberFinder : INumberFinder
    {
        public int FindSingleNumber(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Array must be non-empty and not null.");
            }

            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}
