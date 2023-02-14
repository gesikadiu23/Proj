
class Program
{
    enum Level
    {
        Low,
        Medium,
        High,
        VeryHigh
    }

    enum Months
    {
        January,    // 0
        February,   // 1
        March = 6,    // 6
        April,      // 7
        May,        // 8
        June,       // 9
        July        // 10
    }

    static void Main(string[] args)
    {



        int shuma(int a, int b)
        {
            return a + b;
        }

        Console.WriteLine("Hello, World!");

        int a = 10;

        int b = shuma(121, 31);

        Console.WriteLine(b);

        string message = $"Hello {a} more than {b}";

        int ac = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(message);

        int[] test = new int[3];


        Level myVar = Level.Medium;

        Console.WriteLine(myVar);

        int myNum = (int)Months.April;
        Console.WriteLine(myNum);
    }
}


