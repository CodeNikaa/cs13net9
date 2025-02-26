﻿

using System.Globalization;
using System.Threading.Tasks.Dataflow; //to use CultureInfo.   
// set current culture to US English so that all readers see the sae output as in the book.
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(format:"{0} apples cost {1:C}", arg0: numberOfApples, arg1: numberOfApples * pricePerApple);
string formatted = string.Format(format:"{0} apples cost {1:C}", arg0: numberOfApples, arg1: numberOfApples * pricePerApple);
//Three parameter values can use named arguments
WriteLine("{0} {1} lived in {2}.", arg0:"Roger", arg1:"Cevung", arg2:"Stockholm");
//Four or more parameter values cannot use named arguments.
WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.", "Roger", "Cevung", "Stockholm", "Education", "Optimzely");
//The following statement must be all on one line when using C# 10 or earlier. If using C#11 or later, we can include a line break in the middle of an expression but not in the string text.
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples}");

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine();
WriteLine(format:"{0,-10} {1,6}",arg0:"Name", arg1:"Count");
WriteLine(format:"{0,-10} {1,6:N0}",arg0:applesText, arg1:applesCount);
WriteLine(format:"{0,-10} {1,6:N0}",arg0:bananasText, arg1:bananasCount);

decimal value = 0.325M;
WriteLine("Currency {0:C}, Percentage {0:0.0%}", value);

/*WriteLine("Type your firstname and press ENTER: ");
string? firstName = ReadLine();
WriteLine("Type your age and press Enter: ");
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}");*/

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key:{0}, Char:{1}, Modifiers:{2}", arg0:key.Key, arg1:key.KeyChar, arg2:key.Modifiers);
