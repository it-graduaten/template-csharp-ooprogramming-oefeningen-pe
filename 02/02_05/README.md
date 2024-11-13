# 02_05

## Klassen

### Tamagotchi

- Er wordt een waarde bijgehouden die het emotionele gevoel zal voorstellen. Deze waarde kan variëren van -10 (rotslecht) tot +10 (Super). Bij een foutieve nieuwe waarde groter dan 10, wordt het ingesteld op 10. Bij een foutieve nieuwe waarde kleiner dan -10, wordt het ingesteld op -10.
- Er wordt een waarde bijgehouden die het hongersgevoel zal voorstellen. Deze waarde kan variëren van -5 (uitgehongerd) tot +20 (meer dan voldaan). Bij een foutieve nieuwe waarde groter dan 20, wordt het ingesteld op 20. Bij een foutieve nieuwe waarde kleiner dan -5, wordt het ingesteld op -5.
- Men kan een Tamagotchi eten geven. De methode eten heeft een parameter waarin men aangeeft hoeveel eenheden men geeft. Per keer kan een Tamagotchi echter slechts 3 eenheden opnemen, zelfs als er meerdere aangeboden worden. Het tijdstip van eten wordt bijgehouden bij de LaatsteMaaltijd.
- Daarnaast kan men het diertje liefkozen als het nog leeft. Telkens als men dit doet, gaat er het goedgevoel met één vermeerderd worden.
- Men kan het natuurlijk ook straffen als het nog leeft. Men geeft op hoeveel men straft. Het goed gevoel vermindert in dezelfde mate.
- Er kan gevraagd worden naar een tekstuele weergave over hoe de Tamagotchi zich voelt. Belangrijk is dat net voordat hij antwoordt, de Tamagotchi zal berekenen hoe hij zich voelt. Telkens je ernaar vraagt, zal hij zijn goedgevoel met 1 verminderen, hij mist immers je liefkozingen. Maar onder de nul zal zijn GoedGevoel op deze manier niet geraken. Als hij 30 seconden niets gegeten heeft, dan zal zijn honger met een eenheid zakken.

## Console applicatie

Schrijf een programma waarmee de gebruiker de gegevens behorende tot een tamagochi kan beheren. De gebruiker zal vanaf het opstarten steeds de keuze krijgen uit een menu om zijn actie met betrekking tot de tamagochi te bepalen. Hierna word telkens een stand van zaken getoond. Dit proces blijft lopen tot de gebruiker de stop optie kiest uit het keuzemenu.