// An unsigned integer is a positive whole number or 0.
using System.Runtime.ExceptionServices;
using System.Text.Encodings.Web;

uint naturalNumber = 23;
// An intgere is a negative or positive whole number or 0;
int integerNumber = -23;
// A float is a single-precision floating-point number.
// The F or f suffix makes the value a float literal.
// The suffix is required to compile
float realNumber = 2.3f;
// A double is a double-precision floating-point number.
// double is the default for a number value with a decimal point.
double anotherRealNumber = 2.3; // A double literal value

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
// Check the three variables have the same value.

Console.WriteLine($"Decimal Notation: {decimalNotation} \nBinary Notation: {binaryNotation} \nHexadecimal Notation: {hexadecimalNotation}");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range of {int.MinValue:N0} to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range of {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}");    

Console.WriteLine("Using doubles:");

double a = 0.1;
double b = 0.2;

if(a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals:");

decimal c = 0.1M;
decimal d = 0.2M;

if(c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}

#region Special float and double values

Console.WriteLine($"double.Epsilon:{double.Epsilon}");
Console.WriteLine($"double.Epsilon to 324 decimal places:{double.Epsilon:N324}");
Console.WriteLine($"double.Epsilon to 330 decimal places:{double.Epsilon:N330}");

const int col1 = 37; // First column width
const int col2 = 7; // Second column width

string line = new string('-', col1 + col2 + 3);

Console.WriteLine(line);
Console.WriteLine($"{"Exression",-col1} | {"Value",col2}");
Console.WriteLine(line);
Console.WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
Console.WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
Console.WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
Console.WriteLine($"{"0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
Console.WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
Console.WriteLine($"{"3.0 / 0.0 == double.PositiveInfinity",-col1} | {3.0 / 0.0 == double.PositiveInfinity,col2}");
Console.WriteLine($"{"-3.0 / 0.0 == double.NegativeInfinity",-col1} | {-3.0 / 0.0 == double.NegativeInfinity,col2}");
Console.WriteLine($"{"0.0 / 3.0",-col1} | {0.0 / 3.0,col2}");
Console.WriteLine($"{"0.0 / -3.0",-col1} | {0.0 / -3.0,col2}");
Console.WriteLine(line);
#endregion