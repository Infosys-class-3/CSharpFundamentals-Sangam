// if-else - Conditionals

public class Branching
{
    internal void LearnBranching()
    {
        // Example 1
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

        // Example 2
        var marks = 23;
        if(marks < 40)
        {
            Console.WriteLine("You got E");
        }
        else if(marks < 50)
        {
            Console.WriteLine("You got D");
        }
        else if(marks < 60)
        {
            Console.WriteLine("You got C");
        }
        else if(marks < 70)
        {
            Console.WriteLine("You got B");
        }
        else
        {
            Console.WriteLine("You got A");
        }
    }

    void LearnSwitch()
    {
        var dayOfWeek = DateTime.Today.DayOfWeek;

        switch(dayOfWeek)
        {
            case DayOfWeek.Sunday: Console.WriteLine("Today is Sunday");
            break;
            case DayOfWeek.Monday: Console.WriteLine("Today is Monday");
            break;
            case DayOfWeek.Tuesday: Console.WriteLine("Today is Tuesday");
            break;
            case DayOfWeek.Wednesday: Console.WriteLine("Today is Wednesday");
            break;
            case DayOfWeek.Thursday: Console.WriteLine("Today is Thursday");
            break;
            case DayOfWeek.Friday: Console.WriteLine("Today is Friday");
            break;
            case DayOfWeek.Saturday: Console.WriteLine("Today is Saturday");
            break;
            default:Console.WriteLine("Unknown day of week");
            break;
        }        
    }
}