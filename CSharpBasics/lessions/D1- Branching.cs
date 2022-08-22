// if-else - Conditionals

class Branching
{
    internal void LearnBranching()
    {
        var x = Console.ReadLine();
        var isYes = x == "Y" || x == "y";
        
        if(isYes)
        {
            Console.WriteLine("You said Yes");
        }
        else
        {
            Console.WriteLine("You said No");
        }
    }
}