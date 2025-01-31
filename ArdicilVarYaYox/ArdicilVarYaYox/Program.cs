namespace ArdicilVarYaYox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 3, 5, 6, 7, 8, 9 };
            int count = 0;
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i - 1] == numbers[i]) {
                    Console.WriteLine("Ardicil eyni eded var!");
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine("Ardicil eyni eded yoxdur!");
            }
        }
    }
}
