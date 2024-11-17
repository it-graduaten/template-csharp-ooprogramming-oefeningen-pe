# 03_03

Maak een applicatie die het mogelijk maakt om geldigheid te controleren van persoonsgegevens. Voorzie een klasse die het mogelijk maakt om de geldigheid te controleren van een rijksregisternummer en een iban-nummer.

- Regels in verband met geldigheid rijksregisternummer

    - Een rijksregisternummer is als volgt opgebouwd: yy mm dd xxx zz
        met yy: geboortejaar
        mm: geboortemaand
        dd: geboortedag
        xxx: willekeurige getallen
        zz: controlegetal

    - Voor rijksregisternummers met een even jaartal:
    Neem de eerste 9 getallen van het nummer en deel deze door 97. Van deze deling heb je de rest nodig. Trek nu die rest af van 97. Het verschil (dus 97 - rest) moet overeenkomen met het controlegetal.

    Vb: rijksregisternummer 65041523034
    650415230 / 97 = 6705311 rest 63
    97-63 = 34 -> komt overeen met het controlegetal -> geldig rijksregisternummer

    - Voor rijksregisternummer met een oneven jaartal:
    Neem de cijfers op de plaats xxx (dus tussen de geboortedag en het controlegetal). Plaats voor deze getallen een 2. Deel nu dit getal door 20 en neem de rest hiervan. Het rijksregisternummer is geldig als deze rest gelijk is aan het controlegetal.

    Vb. rijksregisternummer 93051822303
    2223 / 20 = 111 rest 3
    3 = 03 -> komt overeen met het controlegetal -> geldig rijksregisternummer

- Regels ivm geldigheid met geldigheid Iban.

    - Een iban is correct wanneer de laatste 2 cijfers van de iban gelijk zijn aan de rest van volgende deling: getal gevormd door de eerste 10 cijfers van de iban / 97.

    Vb. Iban 979-9315445-55
    9799315445 / 97 = 55 -> Geldige iban

## Console applicatie
Bij het opstarten van de applicatie kan de gebruiker de voornaam, familienaam, rijksregisternummer en iban van een persoon opvragen. Daarna worden de gegevens getoond in een overzicht.

Input:
```
Geef een voornaam: Joeri
Geef een familienaam: Verlooy
Geef een rijksregisternummer: 92.09.02-316.55
Geef een Iban: 979-9315445-55
```

Output:
```
Persoonsgegevens
------

Volledige naam: Joeri Verlooy
Rijksregisternummer: 92.09.02-316.55 (ongeldig)
IBAN: 979-9315445-55 (geldig)
```