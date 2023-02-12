int myAge = 33;
string myName = "Ewa";
string mySex = "Kobieta";
string mySex2 = "Mężczyzna";
var myAge2 = 17;
bool man = true;

if (myAge < 40 && mySex == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else
{
    Console.WriteLine("Nie jestem Kobiętą poniżej 30 lat");
}

if (myName == "Ewa" && myAge == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

if (mySex2 != "Kobieta" && myAge2 < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

if (myAge > 30 && mySex2 == "Mężczyzna")
{
    if (myAge < 40)
        Console.WriteLine("Jestem mężczyzną w sile wieku");
}

if (man == true)
{
    Console.WriteLine("Jestem Mężczyzną");
}
if (man != false)
    Console.WriteLine("Jestem Kobietą");






