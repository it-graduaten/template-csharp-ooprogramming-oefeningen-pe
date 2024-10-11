using consoleapp.Models;

// Ask for a number
Console.Write("Geef een nummer: ");
int nummer = int.Parse(Console.ReadLine());
// Ask for a name
Console.Write("Geef een voornaam: ");
string voornaam = Console.ReadLine();
// Ask for a family name
Console.Write("Geef een familienaam: ");
string familienaam = Console.ReadLine();

Gebruiker gebruiker1 = new Gebruiker();

gebruiker1.Nummer = nummer;
gebruiker1.Voornaam = voornaam;
gebruiker1.Familienaam = familienaam;

Console.WriteLine(gebruiker1.ToonGegevens());