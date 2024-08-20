using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the height of the triangle: ");
        int height = int.Parse(Console.ReadLine());

        for (int i = 1; i <= height; i++)
        {
            for (int j = 0; j <= height-i; j++)
            {
                Console.Write(" ");
            }
            for(int k=0;k<(2*i-1);k++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}