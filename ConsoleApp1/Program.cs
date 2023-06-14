// See https://aka.ms/new-console-template for more information
//declare some random bullshit variables to play with
float piAsFloat = 3.14159265359F;
double piAsDouble = 3.14159265359D;
int myInteger = 0;
uint myUnsignedInt = 2;
//byte mySbyte = 255;
//byte myByte = 255;
//short myShort = -11;
//long myLong = -14;
//ulong myUlong = 16;
//short myUshort = 13;
bool myTrue = true;
bool myFalse = false;
//quick and dirty write to console
Console.WriteLine("UInt type: {0}", myUnsignedInt);
Console.WriteLine("Int type(signed): {0}", myInteger);
Console.WriteLine("");
Console.WriteLine("Pi as a float: {0}", piAsFloat);
Console.WriteLine("Pi as double: {0}", piAsDouble); 
Console.WriteLine("This is a an example of different \"Float Types\"");

//if true
if (myTrue)
{
    Console.WriteLine("myTrue was True");
}
// if false
if (!myFalse)
{
    Console.WriteLine("This prints if myFalse is false");
}
// dirty while loop
int i = 0;
while(i<=10)
{
    Console.WriteLine("i is currently: {0}", i);
    i++;
}
// creates int array
int[] myIntArray = {1, 2, 3, 4, 5};

//creates empty int array (must declare expected amount of values)
int[] myEmptyArray = new int[5];

// Arrays are zero indexed
// print 3rd element of array
Console.WriteLine("3rd element (2 index): {0}", myIntArray[2]);

//Tuple. Declared like (value, value, value)

(string, string, int) tuple = ("String 1", "String 2", 10);

// print elements like this 
Console.WriteLine("Tuple value 1 {0}", tuple.Item1);
Console.WriteLine("Tuple value 2 {0}", tuple.Item2);
Console.WriteLine("Tuple value 3 {0}", tuple.Item3);

