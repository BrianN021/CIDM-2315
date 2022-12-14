class customer  {
    private int cus_id;
    public string cus_name;
    public int cus_age;
    public Customer(int cus_id, string cus_name, int cus_age){
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
    public void ChangeID(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer)
    {
        if(objCustomer.cus_age > this.cus_age)
        {
            Console.WriteLine(objCustomer.cus_name + " is older");
        }
        else if(objCustomer.cus_age < this.cus_age)
        {
            Console.WriteLine(this.cus_name + " is older");
        }
        else Console.WriteLine("Same age");
    }
}
namespace week8homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer cust1 = new Customer(cus_id:110, cus_name: "Alice", cus_age: 28);
        Customer cust2 = new Customer(cus_id:111, cus_name: "Bob", cus_age: 30);

        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

        cust1.ChangeID(220);
        cust2.ChangeID(221);

        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

        cust1.CompareAge(cus2);
    }
}

