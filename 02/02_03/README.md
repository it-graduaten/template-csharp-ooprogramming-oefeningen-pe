# 02_03

Maak een applicatie die het mogelijk maakt om de gegevens bij te houden in verhouding met het onderhoud van een auto. Allereerst geeft de gebruiker de hoeveelheid brandstof (in liter), huidig kilometerstand (in kilometer) en de kilometerstand (in kilometer) van het laatste onderhoud op. Vervolgens heeft de gebruiker de mogelijkheid om te kiezen uit een menu. Hierbij kan er gekozen worden om een aantal kilometers toe te voegen aan de kilometerstand. Hierna word een overzicht afgedrukt waarbij de status van de auto word weergegeven.

De hoeveelheid brandstof kan niet groter zijn dan 60 en niet kleiner zijn dan 0. Bij een foutieve nieuwe waarde kleiner dan 0, zal 0 ingesteld worden. Bij foutieve nieuwe waarde groter dan 60, wordt 60 ingesteld. Beide kilometerstanden kunnen niet kleiner zijn dan 0. Bij een foutieve nieuwe waarde kleiner dan 0, zal 0 ingesteld worden.

Per kilometer zal 0.05 liter verdwijnen uit de brandstof. Indien de brandstof onder de 10 liter komt, zal er vloeistof aangevuld moeten worden. Vanaf 25.000 kilometer gereden te hebben sinds het laatste onderhoud, zal er onderhoud aan de auto vereist zijn.

## Console applicatie

### Voorbeeld auto in orde
```plaintext
Geef hoeveelheid brandstof: 30
Geef huidige kilometerstand: 24000
Geef kilometerstand laatste onderhoud: 0

Opties
---------------
1. Voeg 25 kilometer toe 
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit

Geef een keuze: 2

Status
------
De auto is volledig in orde!
```

### Voorbeeld brandstof aanvullen
```plaintext
Geef hoeveelheid brandstof: 12
Geef huidige kilometerstand: 20000
Geef kilometerstand laatste onderhoud: 0

Opties
---------------
1. Voeg 25 kilometer toe 
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. vul brandstof aan
5. Voer onderhoud uit

Geef een keuze: 3

Status
------
Voeg brandstof toe aub!
```

### Voorbeeld onderhoud vereist
```plaintext
Geef hoeveelheid brandstof: 60
Geef huidige kilometerstand: 24999
Geef kilometerstand laatste onderhoud: 0

Opties
---------------
1. Voeg 25 kilometer toe 
2. Voeg 100 kilometer toe
3. Voeg 1000 kilometer toe
4. Vul brandstof aan
5. Voer onderhoud uit

Geef een keuze: 1

Status
------
Er is dringend onderhoud nodig!
```