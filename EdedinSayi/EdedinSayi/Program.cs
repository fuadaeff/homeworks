namespace EdedinSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Saymaq istediyiniz ededi daxil edin:");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] == number) {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Axtardiginiz eded yoxdur!");
            }
            else
            {
                Console.WriteLine($"Axtardiginiz ededden {count} dene var!");    
            }
        }
    }
}
