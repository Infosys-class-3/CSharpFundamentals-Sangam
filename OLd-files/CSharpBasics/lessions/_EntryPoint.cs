class EntryPoint
{
    public static void Main()
    {
        // // Create object/ Instantiate / Create Instance
        // Person sangam = new();

        // // Set sangam's (object) data
        // sangam.firstName = "Sangam";
        // sangam.lastName = "Neupane";
        // sangam.age = 23;
        // sangam.isFemale = false;

        // // Create object/ Instantiate / Create Instance
        // Person susan = new() 
        // {
        //     firstName = "Susan",
        //     lastName = "Neupane",
        //     age = 23,
        //     isFemale = true
        // };

        // // Call object method
        // sangam.SpeakLanuage();

        // Branching b = new();
        // b.LearnBranching();

        //Loop l = new();
        //l.LearnLoops();

        // string firstName = "Ram";
        // string middleName = "Hari";
        // string lastName = "Basnet";

        // string fullName = firstName + " " + middleName + " " + lastName;
        
        // // string interpolation
        // string fullName1 = $"{firstName} {middleName} {lastName}";
        // Console.WriteLine(fullName);
        // Console.WriteLine(fullName1);

        // // Verbatim character
        // string countryDescription = @"Nepal \n is \n sdfsfssff. \nshdkhfkjsfdh \n fkjsfhskjfsh fkjsf";
        // Console.WriteLine(countryDescription);

        //Pattern 1 = new();
        //1.LearnPatterns();
        Methods m = new();
       var fn =  m.GetFullName( "Ram", "RK"); 
       //var fn =  m.GetFullName( lastName:"Ram", firstName: "RK"); Named arguments
       Console.WriteLine (fn);
    }
}


