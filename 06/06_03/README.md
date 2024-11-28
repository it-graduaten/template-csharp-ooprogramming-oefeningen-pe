# 06_03

## Opgave

Maak een applicatie waar de gebruiker een spel kan spelen tegen de computer. De gebruiker wordt eerst gevraagd om een spel te kiezen. Hij kan kiezen tussen 3 spellen. Elk spel (bestand) bevat een aantal kaarten. Bijvoorbeeld:

```plaintext
1;schoppen;zwart
5;koeken;rood
3;ruiten;zwart
8;klaveren;zwart
10;koeken;rood
```

Het spel dat gespeeld wordt is een soort van memory. De gebruiker moet een waarde, een soort en een kleur ingeven. Er wordt dan gecontroleerd of de gekozen kaart van de gebruiker overeen komt met de huidige kaart in het spel (TIP: maak hier gebruik van de Equals methode). De kaarten worden in volgorde van het bestand gespeeld.

Indien de gebruiker juist geraden heeft, krijgt hij/zij een punt. Indien fout, krijgt de computer een punt. Het spel stopt wanneer iemand 3 punten gescoord heeft.

## Voorbeelden

```plaintext
Kies een spel: spel-1.txt
Geef een waarde: 2
Geef een soort: klaveren
Geef een kleur: zwart

U heeft niet goed gegokt! De kaart was van de kleur zwart met een waarde van 1 en schoppen als soort.

Computer: 1 - Speler: 0

Geef een waarde: 3
Geef een soort: klaveren
Geef een kleur: zwart

U heeft niet goed gegokt! De kaart was van de kleur rood met een waarde van 5 en koeken als soort.

Computer: 2 - Speler: 0

Geef een waarde: 10
Geef een soort: koeke
Geef een kleur: rood

U heeft niet goed gegokt! De kaart was van de kleur zwart met een waarde van 3 en ruiten als soort.

Computer: 3 - Speler: 0

Einde spel. De computer is de winnaar!
```

```plaintext
Kies een spel: spel-1.txt
Geef een waarde: 1
Geef een soort: schoppen
Geef een kleur: zwart

U heeft goed gegokt! De kaart was van de kleur zwart met een waarde van 1 en schoppen als soort.

Computer: 0 - Speler: 1

Geef een waarde: 2
Geef een soort: koeken
Geef een kleur: rood

U heeft niet goed gegokt! De kaart was van de kleur rood met een waarde van 5 en koeken als soort.

Computer: 1 - Speler: 1

Geef een waarde: 3
Geef een soort: ruiten
Geef een kleur: zwart

U heeft goed gegokt! De kaart was van de kleur zwart met een waarde van 3 en ruiten als soort.

Computer: 1 - Speler: 2

Geef een waarde: 8
Geef een soort: klaveren
Geef een kleur: zwart

U heeft goed gegokt! De kaart was van de kleur zwart met een waarde van 8 en klaveren als soort.

Computer: 1 - Speler: 3

Einde spel. De speler is de winnaar!
```