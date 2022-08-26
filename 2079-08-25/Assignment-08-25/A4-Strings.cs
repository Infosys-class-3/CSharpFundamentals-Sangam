public class Strings
{
    internal string GetDetails(string firstName, string lastName)
    {
        string fn = $"{firstName} {lastName}";
        return fn;
    }

    internal DateTime PrintDateTime()
    {
        return DateTime.Now;
    }


    internal string GetDetails(string firstName, string middleName, string lastName, byte age)
    {
        String details = $" {firstName},{middleName} ,{lastName},{age} ";
        return details;
    }

}
