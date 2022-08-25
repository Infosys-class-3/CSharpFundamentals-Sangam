// Visibility/Protection Level - Access Modifiers
// private, internal, protected, public
class Person
{
    //Members: Fields, Methods
    internal string firstName;
    internal string lastName;
    internal byte age;
    internal bool isFemale;

    internal void SpeakLanuage()
    {
        Console.WriteLine(firstName + " speaks english.");
    }
}