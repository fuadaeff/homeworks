using System.Reflection.Emit;

namespace sortingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 6, 3, 8, 7 };
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i - 1] > numbers[i]) {
                    numbers[i - 1] = numbers[i];
                }
            }
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }   
    }
}
