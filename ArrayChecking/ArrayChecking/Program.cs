namespace ArrayChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checker = true;
            int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < numbers1.Length; i++) {
                for (int j = 0; j < numbers2.Length; j++) {
                    if (numbers1[i] == numbers2[j])
                    {
                        checker = true;
                    }
                    else
                    {
                        checker = false;
                    }
                }
            }
            Console.WriteLine(checker);
        }
    }
}
