namespace d_parameteried_constructor;

class Student
{
    public int roll;
    public string name;
    public string address;
    public Student(int r, string n,string a)
    {
        roll =r;
        name =n;
        address =a;
    }
    public void displauinfo()
    {
        Console.WriteLine(name + "lives in" + address + "whose roll no. is "+roll"." )
    }
}
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
