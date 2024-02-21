namespace c_destructor;

class Employee
{
    public Employee()
    {
        Console.WriteLine("Constructor Called");
    }
    ~Employee()
    {
        Console.WriteLine("Destructor Called");
    }
    static void Main(string[] args)
    {
        Employee e1 =new Employee();
    }
}
