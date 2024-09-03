using IRIS_TEST_Problem_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRIS_TEST_Problem_2.Clients
{
    internal class NumberFinderClient
    {
     
            private readonly INumberFinder _numberFinder;

            public NumberFinderClient(INumberFinder numberFinder)
            {
                _numberFinder = numberFinder;
            }

            public void DisplaySingleNumber(int[] nums)
            {
                int result = _numberFinder.FindSingleNumber(nums);
                Console.WriteLine($"Single number in [{string.Join(", ", nums)}]: {result}");
            }
    }
}

