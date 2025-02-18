// An unsigned integer is a positive whole number or 0.
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