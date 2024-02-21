namespace f_non_compatible_type_conversion;

class Program
{
    static void Main(string[] args)
    {
        string a="127";
        int b=Convert.ToInt32(a);
        int c=345;
        int sum=b+c;
       // int hello=(int)hi;//cannot convert string into integer
       //int hello =int.Parse(hi);
        Console.WriteLine("sum =" +sum);
       // Console.WriteLine(sum);
    }
}
