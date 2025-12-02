using System;

class Calculate
{
    static void Main()
    {
        int sum = 0;

        for (int x = 1; x <= 10; x++)
            sum += x;

        Console.WriteLine($"The sum is: {sum}");
    }
}
