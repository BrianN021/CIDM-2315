namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
// Console.WriteLine("Homework Part 1:");
//         Console.WriteLine("Enter Letter Grade:");
//         string Letter = Convert.ToString(Console.ReadLine());
//         int output;
//         switch (Letter)
//         {
//             case "A":
//             output = 4;
//             Console.WriteLine($"GPA from letter grade: {output}");
//             break;
//             case "B":
//             output = 3;
//             Console.WriteLine($"GPA from letter grade: {output}");
//             break;
//             case "C":
//             output = 2;
//             Console.WriteLine($"GPA from letter grade: {output}");
//             break;
//             case "D":
//             output = 1;
//             Console.WriteLine($"GPA from letter grade: {output}");
//             break;
//             case "F":
//             output = 0;
//             Console.WriteLine($"GPA from letter grade: {output}");
//             break;
//             default:
//             Console.WriteLine("Wrong Letter Grade!");
//             break;
//         }
// Console.WriteLine("\nHomework Part 2:");
//         double n1,n2,n3;
//         Console.WriteLine("Please input the first num:");
//         n1 = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Please input the second num:");
//         n2 = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine("Please input the third num:");
//         n3 = Convert.ToDouble(Console.ReadLine());
//         double smol;
//         if(n1>=n2 && n3>=n2){
//         smol = n2;}
//         else if(n2>=n1 && n3>=n1){
//         smol = n1;}
//         else if(n2>=n3 && n1>=n3){
//         smol = n3;}
//         else {smol = 999999;} 
//         Console.WriteLine($"The smallest number is: {smol}");

Console.WriteLine("\nHomework part 3");
    Console.WriteLine("Please input a year:");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year%4 == 0){
            Console.WriteLine($"{year} is a leap year");
        }
        else Console.WriteLine($"{year} is NOT a leap year");



          
        
    }
}