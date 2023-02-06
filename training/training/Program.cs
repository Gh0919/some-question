using System;

namespace training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Help copy
            var copy = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(copy[0]);
            var b = copy[1];
            for (int i = 0; i < a; i++)
            {
                Console.Write("copy of ");
            }
            Console.WriteLine(b);
            //2. A simple question
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("man khoshghlab hastam");
            }
            //3. Mobile charging
            int ch = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i = 1; i <= ch; i++)
            {
                j += i;
            }
            Console.WriteLine(j);
            //4.Yellow question
            int repeat = Convert.ToInt32(Console.ReadLine());
            Console.Write("W");
            for (int i = 0; i < repeat; i++)
            {
                Console.Write("o");
            }
            Console.WriteLine("w");
            //5.Simpler
            int[] numbers = new int[4];
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            float max = numbers[0];
            float min = numbers[0];
            float sum = numbers[0];
            float multi = numbers[0];
            for (int i = 1; i < 4; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
                multi *= numbers[i];
                if (max <= numbers[i])
                {
                    max = numbers[i];
                }
                else if (min >= numbers[i])
                {
                    min = numbers[i];
                }
            }
            Console.Write($"Sum : {sum} \nAverage : {sum / 4} \nProduct : {multi} \nMAX : {max} \nMIN : {min}");
            ///////////////////////////////////

        }
    }
}
