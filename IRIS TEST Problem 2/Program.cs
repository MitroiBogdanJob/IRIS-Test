using System.Diagnostics.CodeAnalysis;
using IRIS_TEST_Problem_2.Clients;
using IRIS_TEST_Problem_2.Interfaces;
using IRIS_TEST_Problem_2.Services;


namespace IRIS_TEST_Problem_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = { 2, 2, 1 };
            int[] nums2 = { 4, 1, 2, 1, 2 };
            int[] nums3 = { 1 };
            int[] nums4 = { 1,9,8,7,8,10 };

            INumberFinder numberFinder = new XorNumberFinder();

            NumberFinderClient client = new NumberFinderClient(numberFinder);

            client.DisplaySingleNumber(nums1);
            client.DisplaySingleNumber(nums2);
            client.DisplaySingleNumber(nums3);
            client.DisplaySingleNumber(nums4);
        }


     
    }
}
