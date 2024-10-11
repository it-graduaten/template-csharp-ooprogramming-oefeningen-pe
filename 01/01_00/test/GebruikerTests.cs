using consoleapp.Models;

namespace test;

[TestClass]
[TestCategory("Models")]
public class GebruikerTests
{
    [TestMethod]
    public void Constructor_AlleWaardenIngevuld_PropertiesHebbenWaarden()
    {
        Gebruiker gebruiker1 = new Gebruiker();
        Assert.AreEqual(0, gebruiker1.Nummer, "Nummer is niet 0");
        Assert.AreEqual("", gebruiker1.Voornaam, "Voornaam is niet gelijk aan een lege string");
        Assert.AreEqual("", gebruiker1.Familienaam, "Familienaam is niet gelijk aan een lege string");
    }

    [TestMethod]
    public void Wissen_AllePropertiesIngevuld_AllePropertiesLeeg()
    {
        Gebruiker gebruiker1 = new Gebruiker();
        gebruiker1.Voornaam = "John";
        gebruiker1.Wissen();
        Assert.AreEqual(0, gebruiker1.Nummer, "Nummer is niet 0");
        Assert.AreEqual("", gebruiker1.Voornaam, "Voornaam is niet gelijk aan een lege string");
        Assert.AreEqual("", gebruiker1.Familienaam, "Familienaam is niet gelijk aan een lege string");
    }

    [TestMethod]
    public void ToonGegevens_AllePropertiesIngevuld_AllePropertiesInString()
    {
        Gebruiker gebruiker1 = new Gebruiker();
        gebruiker1.Nummer = 1;
        gebruiker1.Voornaam = "John";
        gebruiker1.Familienaam = "Doe";

        var output = gebruiker1.ToonGegevens();

        StringAssert.Contains(output, "1", "\"1\" is niet aanwezig in de output.");
        StringAssert.Contains(output, "John", "\"John\" is niet aanwezig in de output.");
        StringAssert.Contains(output, "Doe", "\"Doe\" is niet aanwezig in de output.");
    }
}