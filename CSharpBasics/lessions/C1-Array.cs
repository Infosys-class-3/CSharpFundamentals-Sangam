class Array
{
    void LearnArray1D()
    {
        byte[] personAges = new byte[1000];
        string[] personNames = { "Ram", "Ajay", "Susan", "Sanam" };

        // Array Indexing
        // Set
        personAges[0] = 45;
        personAges[1] = 12;
        personAges[2] = 89;
        personAges[3] = 23;

        //Get
        var x = personAges[10];
        var x1 = personNames[1];
    }

    void LearnArray2D()
    {
        int[,] table = new int[2, 3];
        int[,,] coordinates = new int[2, 3, 4];

        // 234      23345   456457
        // 45646    809890  6757   
        table[0, 0] = 234;
        table[0, 1] = 23345;
        table[0, 2] = 456457;
        table[1, 0] = 45646;
        table[1, 1] = 809890;
        table[1, 2] = 6757;

        var x = table[1, 1];
    }

    void LearnJaggedArray()
    {
        decimal[][] table = new decimal[3][];
        table[0] = new decimal[] { 34.56m, 45.22m, 657457.2342m };
        table[1] = new decimal[] { 34.56m, 45.22m };
        table[2] = new decimal[] { 34.56m, 45.22m, 345245.35m, 4565464.2342m };

        var x = table[2][2];
    }
}