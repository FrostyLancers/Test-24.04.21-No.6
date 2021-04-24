using System;

namespace Test_24._04._21_No._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            int Width = int.Parse(Console.ReadLine());
            int Height = int.Parse(Console.ReadLine());
            int Level = int.Parse(Console.ReadLine());

            for (int c = 1; c <= Level; c++)
            {
                for (int a = 1; a < Width; a++)
                {
                    for (int b = 1; b <= Height; b++)
                    {
                        Console.Write(letters);
                    }
                    Console.WriteLine(letters);
                }
            }


        }
    }
}
