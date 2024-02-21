﻿namespace d_parameteried_constructor;

class Student
    {
    public int roll;
    public string name;
    public string address;
    public Student(int r, string n, string a)
    {
        roll = r;
        name = n;
        address = a;
    }
    public void displayInfo()
    {
        Console.WriteLine(name + " lives in " + address + " whose roll number is " + roll + ".");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(12 , "Hari Thapa", "Banepa");
        s1.displayInfo();
    }
}
