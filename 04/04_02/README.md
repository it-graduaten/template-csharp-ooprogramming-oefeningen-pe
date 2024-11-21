# 04_02

## Klassen
Het saldo mag niet onder minimum komen. Bij foutieve waarde wordt het saldo op het minimum ingesteld.
De landcode geeft de eerste 2 karakters van het iban-nummer terug.
Bij het aanmaken van een spaarrekening, zal standaard een percentage voorzien worden van 5%.
Bij het aanmaken van een zichtrekening, zal er standaard een minimum voorzien worden van -100.

## Console applicatie
Bij het opstarten van het programma krijgt de gebruiker een menu met soorten rekeningen waaruit deze kan kiezen. Bij het ingeven van een optie worden vervolgens benodigde gegevens gevraagd.

Enkele voorbeelden:
```
0. Rekening
1. Spaarekening 
2. Zichtrekening
Maak uw keuze: 1
Geef een IBAN: BE12 1234 1234 1234
Rekening BE12 1234 1234 1234 met saldo 0 (percentage 5)
```

```
0. Rekening
1. Spaarekening 
2. Zichtrekening
Maak uw keuze: 2
Geef een IBAN: BE12 1234 1234 1234
Geef een saldo: 250
Rekening BE12 1234 1234 1234 met saldo 250 (minimum -100)
```