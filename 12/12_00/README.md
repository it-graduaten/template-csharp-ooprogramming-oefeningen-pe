# 12_00

## Klassen

Begin met het kopieren van de oplossing van oefening 04.02 naar deze oefening. Verwijder de validatie die op de property `Saldo` staat.

Maak een extra klasse `SaldoOnderNulException` die een exception voorstelt wanneer het saldo onder nul gaat. Deze klasse moet overerven van `Exception`.

In de klasse `Bankrekening` pas je de methode `Afhalen` aan zodat deze een exception `SaldoOnderNulException` gooit wanneer het saldo onder nul gaat.

## Console applicatie

Wanneer er te veel geld wordt afgehaald, moet de console applicatie een foutmelding geven. Deze foutmelding moet worden opgevangen en de exception message weergeven.