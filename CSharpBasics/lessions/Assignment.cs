internal class Employee
{
    internal string? name;
    internal string? email;
    internal string? contact;
    internal bool? isMale;
    internal byte age;

    internal string GetName()
    {
        return name;
    }
    internal void GetInfo()
    {
        System.Console.WriteLine($"Name : {name} \nEmail : {email} \nContact : {contact} \nMale : {isMale} \nAge : {age}"     );
    }
}

internal class Program1
{
    public static void Main(String[] args)
    {
        Employee emp = new();
        emp.name = "Ram";
        emp.email = "ram@gmail.com";
        emp.contact = "980122389";
        emp.isMale = true;
        emp.age = 30;

        Console.WriteLine("Employ name: " + emp.GetName());
        Console.WriteLine("ram");
        emp.GetInfo();
    }
    
}