//hivatkozás a változóra közvetlenül.

int valtozo = 13;
string interpolalt = $"{nameof(valtozo)} értéke: {valtozo}";
Console.WriteLine(interpolalt);

//az x hexa, a 2 pedig, hogy 2db számjegyet szeretnénk
//a kimenete: "valtozo értéke hexadecimálisan: 0d"
string interpolalt2 = $"{nameof(valtozo)} értéke hexadecimálisan: {valtozo:x2}";
Console.WriteLine(interpolalt2);

//A format helyett jobb ezt használni, itt is lehet a formázási utasításokat használni.