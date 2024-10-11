namespace consoleapp.Models;

public class Gebruiker
{
    // Attributen
    private int _nummer;
    private string _voornaam;
    private string _familienaam;

    // Properties
    public int Nummer
    {
        get { return _nummer; }
        set { _nummer = value; }
    }

    public string Voornaam
    {
        get { return _voornaam; }
        set { _voornaam = value; }
    }

    public string Familienaam
    {
        get { return _familienaam; }
        set { _familienaam = value; }
    }

    // Constructor
    public Gebruiker()
    {
        this.Nummer = 0;
        this.Voornaam = "";
        this.Familienaam = "";
    }

    // Methoden
    public void Wissen()
    {
        this.Nummer = 0;
        this.Voornaam = "";
        this.Familienaam = "";
    }

    public string ToonGegevens()
    {
        return $"{Nummer.ToString()} - {Voornaam} {Familienaam}";
    }
}
