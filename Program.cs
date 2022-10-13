namespace week6hw;
class Program
{
    static void Main(string[] args)
    {
        //created a new professor object
        Professor p1 = new Professor();
        p1.profname = "Alice";
        p1.classteach = "Java";
        p1.salary = 9000;

        Professor p2 = new Professor();
        p2.profname = "Bob";
        p2.classteach = "Math";
        p2.salary = 8000;

        Student s1 = new Student();
        s1.stuname = "Lisa";
        s1.stuclass = "Java";
        s1.stugrade = 90;

        Student s2 = new Student();
        s2.name = "Tom";
        s2.stuclass = "Math";
        s2.stugrade = 80;

        p1.PrintProfessorInfo();
        p2.PrintProfessorInfo();
        s1.PrintStudentInfo();
        s2.PrintStudentInfo();

        Console.WriteLine($"The salary difference between {p1.profname} and {p2.profname} is {p1.salary - p2.salary}");
        Console.WriteLine($"The total grade of {s1.stuname} and {s2.stuname} is {s1.stugrade + s2.stugrade} ");

        
    }
}
class Professor
{
    public string profname;
    public string classteach;
    public double salary {get;set;}

    public void PrintProfessorInfo(){
        System.Console.WriteLine($"Professor {profname} teaches {classteach}, and the salary is: {salary} ");
    }
}
class Student
{
    public string stuname;
    public string stuclass;
    public double stugrade{get;set;}

    public void PrintStudentInfo(){
        System.Console.WriteLine($"Student {stuname} enrolls {stuclass}, and the grade is: {stugrade} ");

    }
}