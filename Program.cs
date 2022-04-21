class FizzBuzz
{
    static void Main(string[] args)
    {
        int fizz = 3;
        int buzz = 7;
        int max = 100;

        Run(fizz, buzz, max);
    }

    private static void Run(int fizz, int buzz, int max)
    {
        for (int i = 1; i <= max; ++i)
        {
            string output = CalcFizzBuzz(i, fizz, buzz);
            Console.WriteLine(output);
        }
    }

    private static bool IsDivisible(int num, int divisor)
    {
        return num % divisor == 0;
    }

    private static string CalcFizzBuzz(int num, int fizz, int buzz)
    {
        bool isFizz = IsDivisible(num, fizz);
        bool isBuzz = IsDivisible(num, buzz);

        if (isFizz && isBuzz)
        {
            return "FizzBuzz";
        }
        else if (isFizz)
        {
            return "Fizz";
        }
        else if (isBuzz)
        {
            return "Buzz";
        }
        else
        {
            return num.ToString();
        }
    }
}
