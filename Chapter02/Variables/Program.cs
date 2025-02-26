using System.Drawing;
using System.Xml; //to use  XmlDocument.

object heigth = 1.88;  //Storing a double in an object
object name = "Amir"; //Storing a string in an object

Console.WriteLine($"{name} is {heigth} metres tall");

//int length1 = name.Length; //This gives a compile Error
int length2 = ((string)name).Length; // Cast name to a string 

Console.WriteLine($"{name} has {length2} characters.");

dynamic something;
// Storing an array of int values in a dynamic object
// An array of any type has Legth property
something = new[]{3, 5, 7};
//Storing an int in a dynamic object
//Int does not have a Length property
////something = 12;
//Storing a string in a dynamic object
//string has a Length property
////something = "Ahmed";
//This compiles but might throw an exception at run-time
Console.WriteLine($"The length of something is {something.Length}");
//Output the type of the something variable
Console.WriteLine($"something is a {something.GetType()}");

var population = 67_000_000; // 67 million in UK
var weigth = 1.88; // in kilograms
var price = 4.99M; // in pounds stering
var food = "Apples"; // string values use double quotes
var letter = 'Z'; // char values use single quotes
var happy = true; // Booleans can only be true or false

//Good use of var because it avoids the repeated type as shown in the more verbose second statement.
var xml1 = new XmlDocument(); // Works with C#3 and later.
XmlDocument xml2 = new XmlDocument(); // Works with all C# versions.
//Bad use of var because we cannot tell the type, so we should use a specific type declaration as shown in the second statement.
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

/* Value types have memory allocated on the stack automatically */
short age; // Allocates 2 bytes of memory on the stack to store a System.Int16 value.
//long population; // Allocates 8 bytes of memory on the stack to store a System.Int64 value.
DateTime birthdate; // Allocates 8 bytes of memory on the stack to store a System.DateTime value.
Point location; // Allocates 8 bytes of memory on the stack to store a System.Drawing.Point value.
/* Reference types will only have memory allocated on the heap when new is used (but they automatically have some memory allocated on the stack to store information about themself including the memory adress of where they are on the heap). */
Person bob; // Allocates memory in the stack that can point to a Person object in the heap. Initially, bob will have the value null.

Person kim = new();
kim.BirthDate = new(1967, 12, 26);

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");

int number = 13;
Console.WriteLine($"number set to:{number}");
number = default;
Console.WriteLine($"number resets to its default:{number}");

Console.Write("A");
Console.Write("B");
Console.Write("C");

class Person
{
    public DateTime BirthDate;
}