class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Write("HIIIII");
        //programs 
        Console.WriteLine("Type casting ");
        int a = 10;
        double d = a; // implicit casting
        Console.WriteLine(d);

        double dd = 9.89;
        int aa = (int)dd; // explicit casting 
        Console.WriteLine(dd);
        Console.WriteLine(aa);
    }
}