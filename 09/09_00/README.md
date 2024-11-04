# 09_00

## Klassen

### Overzicht

![Klassediagram](svg/Overview.svg)

### Auto

**Methode `Equals`**

Een auto is gelijk aan een andere auto als ze beiden van het type `Auto` zijn en hetzelfde chassisnummer hebben.

**Methode `ToString`**

De methode `ToString` geeft een string terug: `De <Merk> met chassisnummer <Chassisnummer> heeft volgende kenmerken: <Motor>.`

### Motor

**Methode `ToString`**

De methode `ToString` geeft een string terug: `Cilinderinhoud: <Cilinderinhoud> - Pk: <Pk>`

## Console applicatie

Bij het opstarten van de applicatie krijgt de gebruiker een menu met de volgende opties:

1. Auto toevoegen
2. Auto verwijderen
3. Afsluiten
   
Bij het selecteren van `Auto toevoegen` vraagt het programma alle gegevens voor een object van een auto met een motor aan te maken (Chassisnummer, Merk, Cilinderinhoud en aantal PK). Indien dit een auto is die nog niet in de lijst bestaat, zal deze toegevoegd worden aan de lijst.

Bij het selecteren van `Auto verwijderen` vraagt het programma het chassisnummer om deze in de lijst te kunnen zoeken. Indien dit een auto is die in de lijst bestaat, zal deze verwijderd worden uit de lijst.

Na het toevoegen of verwijderen van een auto, zal een overzicht van alle auto's in de lijst getoond worden.

Zolang optie 3 niet geselecteerd wordt, zal het programma blijven vragen om een nieuwe keuze op te geven na het toevoegen of verwijderen van een auto.