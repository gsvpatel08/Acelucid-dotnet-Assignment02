using System;

class Triangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the height of the triangle: ");
        
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = height - i; j > 0; j--)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
