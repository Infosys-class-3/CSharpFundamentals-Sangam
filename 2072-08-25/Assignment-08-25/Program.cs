class EntryPoint
{
    public static void Main()

    {
        Strings s = new();

        Console.WriteLine(s.GetDetails("Krishna", "Achyuta"));

        Console.WriteLine(s.PrintDateTime());


        Console.WriteLine(s.GetDetails("Krishna", "MadanMohan", "Achyuta", 16));

    }
}