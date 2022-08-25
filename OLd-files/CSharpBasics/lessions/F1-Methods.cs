public class Methods
{
    //1. Returns nothing and take no arguments.
    public void Print()
    {
        Console.WriteLine("I am from Nepal");
    }

    //2. Returns something and takes no arguements
    public string GetAddress()
    {
        string address = "Kathmandu, Nepal";
        return address;
    }

    //3.Returns something and take some arguments
    internal double Add(double x, int y)
    {
        var sum = x + y;
        return sum;

    }


    // 3. Method Overloading(Polymorphism)
    internal double Add(double a, int b, byte c)
    {
        var sum = a + b + c; // float sum = (float)a+b+c (float in side of a+b+ c is called casting.)
        return sum;

    }

    //4. Variable number of arguements
    internal double Add(params double[] numbers)
    {
        var sum = 0.0;
        foreach (var num in numbers)
        {
            sum = sum + num;
        }
        return sum;


    }

    // 5. Optional arguements
    internal string GetFullName(string firstName, string lastName, string salutation = "Mr")
    {
        string fn = $"{salutation}.{lastName}, {firstName}";
        return fn;
    }


    //6. Expression bodied members
    internal float Add(int x, int y, float z) => (float)x + y + z;


}
