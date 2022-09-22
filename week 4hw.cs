namespace week4hw;
class Program
{
    static void Main(string[] args)
    {
        //part1
        // Console.WriteLine("Enter two integers: ");
        // int a = Convert.ToInt16(Console.ReadLine());
        // int b = Convert.ToInt16(Console.ReadLine());
        
        // Console.WriteLine($"a = {a}; b = {b}");

        // if (a>b){
        //     Console.WriteLine($"The Largest number is: {a}");
        // }
        // else
        // {
        //     Console.WriteLine($"The Largest number is: {b}");
        // }
        Console.WriteLine("Enter N:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Left or Right: ");
        string rl = Console.ReadLine();
        
    }
    static void part2(int n, string s)
    {
        if (s == "left"){
            for (int i = 1; 1 <= n; i++)
            {
                for (int j = 1; j <= i; j++)
            {
                Console.Write("");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            }
        }

        else if (s == "right"){
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
