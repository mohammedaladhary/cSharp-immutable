
namespace c__Immutable
{
    internal class Program
    {
        static bool SearchNumber(int[] arr, int target)
        {
            foreach (int num in arr)
            {
                if (num == target)
                    return true;
                else if (num > target)
                    return false;
            }
            return false;
        }
        static void Main(string[] args)
        {
                int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
                int targetNumber = 11;

            if (SearchNumber(numbers, targetNumber))
                Console.WriteLine("Number found in the array.");
            else
                Console.WriteLine("Number not found in the array.");
        }
    }
}