using System.Reflection.Emit;

namespace AraliginCemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            Label:
            Console.WriteLine("Cemin tapmaq istediyiniz araligi daxil edin:");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            if (j > numbers.Length + 1)
            {
                Console.WriteLine("Siz boyuk indeks daxil etdiniz!Yeniden cehd edin!");
                goto Label;
            }
            for (int k = i - 1; k < j - 1; k++) {
                sum = sum + numbers[k];
            }
            Console.WriteLine($"Daxil etdiyiniz araligin cemi: {sum}");
        }
    }
}
