//Explicit, azaz egyértelműen megadom h mire
int x = 22;
double y = (double)x;

int z = 3;
Console.WriteLine(z / 4);
Console.WriteLine((double)z / 4);

//Implicit konverzió
//Ez rejtett konverziót jelent, akkor használd ha biztos, hogy minden esetben hiba nélkül le tud futni.

byte b = 11; //ez is mert intet konvertál bytera
int egesz = b;
double d = egesz;

double pi = 3.14;
//3 lesz, veszteség történik, ezért explicitnek van definiálva a konverzió
int egész = (int)pi;

//Convert osztály

byte b1 = 33;

int c1 = Convert.ToInt16(b1);
string s1 = Convert.ToString(b1);
bool b2 = Convert.ToBoolean(b1);
bool b3 = Convert.ToBoolean(3>5);
bool b4 = Convert.ToBoolean(5>3);

Console.WriteLine($"B3 {b3}, B4 {b4}");

//számrendszerek közti konverzió, csak strinben és csak pozítív egész számokra
//2. param a számrendszer 2,8,10,16 lehet
string s2 = Convert.ToString(b1, 2);
Console.WriteLine(s2);