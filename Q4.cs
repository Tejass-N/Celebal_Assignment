using System;
class Program
{
    static void Main()
    {
        int intValue = 42; 
        double doubleValue = 3.14159; 
        bool boolValue = true; 
        char charValue = 'A'; 
        byte byteValue = 127; 
        short shortValue = 32000; 
        long longValue = 1234567890L; 
        float floatValue = 1.23f; 
        decimal decimalValue = 123.456m; 

        string firstString = "I control text";
        string secondString = "Hello, world!";

        Console.WriteLine($"int: {intValue}");
        Console.WriteLine($"double: {doubleValue}");
        Console.WriteLine($"bool: {boolValue}");
        Console.WriteLine($"char: {charValue}");
        Console.WriteLine($"byte: {byteValue}");
        Console.WriteLine($"short: {shortValue}");
        Console.WriteLine($"long: {longValue}");
        Console.WriteLine($"float: {floatValue}");
        Console.WriteLine($"decimal: {decimalValue}");
        Console.WriteLine($"string 1: {firstString}");
        Console.WriteLine($"string 2: {secondString}");
    }
}

//OUTPUT
int: 42
double: 3.14159
bool: True
char: A
byte: 127
short: 32000
long: 1234567890
float: 1.23
decimal: 123.456
string 1: I control text
string 2: Hello, world!
