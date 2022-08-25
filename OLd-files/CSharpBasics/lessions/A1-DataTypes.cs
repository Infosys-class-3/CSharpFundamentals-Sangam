// Static/strongly typed vs dynamic/weakly typed

// Datatypes
// 1. Numbers
// 1.1 Integral numbers

class Datatype
{
    byte a = 255;
    short b = 32767;  //11111111111111111      
    int c = 352345235;
    long d = 34353253454564646;

    // 1.2 Floating point numbers, Precision
    float e = 45.624242342422f;
    double f = 45.34345446466464;
    decimal g = 45.345243532532235m;

    // 2. Text
    string h = @"asfaf sasfasdfasf sf\d"; // Verbatim character
    char i = 'M';
    
    // Escape sequences: \n \t \r \b \t
    
    // 3. Boolean
    bool j = false;

    // Nullables
    int? population = null;

    // Camel and pascal casing

    string personNameOfEarth = "sdfsdasf"; // Camel
                                           //class PersonManager {} // Pascal
}