int number;

number = 3;

Console.WriteLine(number);

number = number + 3;

Console.WriteLine(number);


int thisIsAVariable = 3;    // camelCase. Good convention.

int ThisISaVariable = 7;    // Legal but bad! Don't do this.

int ThisIsAVariable = 42;   // PascalCase. Not the convention to use for C# variables.

int myVariableHasMultipleWords; // camel case


string message = "Hello, World!";


Console.WriteLine(message); // This is a comment

message = "Hello, Eric!";

Console.WriteLine(message);

// See https://aka.ms/new-console-template for more information
/* This is a multi-line comment
   This is still part of the comment.
   And still part of the comment  */

int x = 7;
double y = 72.4;
char c = 'a';
string s = "Hello, world!";
string s2 = "a";
string s3 = "";

bool b = true;
bool b2 = false;


/*************************************
 * Built-In Types
 ************************************/
bool boo = true;
Boolean boo2 = false;
System.Boolean boo3 = true;

char myCharacter = 'E';
char newLine = '\n';
char tab = '\t';
char singleQuote = '\'';
char backslash = '\\';
Char myOtherChar = 'c';

string myString = "This is a string";
string interpolatedString = $"The value myCharacter is {myCharacter}";
Console.WriteLine(interpolatedString);
string verbatimString = @"\
This is a string
That spans several lines.
It includes some backslashes (\) that do not need escaped.
If I need to include a double-quote, I escape it by doubling it.
Like ""this"".
";
String myOtherString = myString;



Console.WriteLine("This is a \"string\" with quotes");
Console.WriteLine("Column1\tColumn2\tColumn3");
Console.WriteLine("Abcde\t123456\t35");

int i = 2_000_000_000;
Int32 i2 = i;
short myShort = 32767;
Int16 myShort2 = myShort;
long l = 20_000_000_000L;
Int64 l2 = l;

l = 2;

float f = 3.5f;
double d = 3.00005;
f = 0.00000300005f;
f = 3000050000000f;

decimal decim = 0.15m;


int maxInt = int.MaxValue;
int minInt = int.MinValue;
double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine(maxInt);
Console.WriteLine(minInt);
Console.WriteLine(maxDouble);
Console.WriteLine(minDouble);
Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);

f = 12.3f;
float f2 = f - 7.43f;
Console.WriteLine(f2);