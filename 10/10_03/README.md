# 10_03

*Maak voor deze oefenign gebruikt van de bestanden `luchthavens.txt` en `vliegtuigen.txt`.*

Werk een applicatie uit om een overzicht te krijgen van alle luchthavens en toestellen die op deze luchthavens staan.

Als je de bestanden bekijkt, zie je dat een vliegtuig opgebouwd is uit een code, een type en een aantal zitplaatsen. Een luchthaven heeft een naam en een lijst van vliegtuigen die op de luchthaven staan. **Deze lijst is niet altijd even lang.** Voorzie dus een manier om hiermee om te gaan.

TIP: Begin met het uitwerken van een methode om alle vliegtuigen in een lijst te plaatsen. Werk daarna een methode uit om alle luchthavens in te lezen. Je kan hiervoor gebruik maken van de methode die je net gemaakt hebt om alle vliegtuigen in te lezen.

TIP: Maak gebruik van de `Find` methode om de vliegtuigen te zoeken die op een bepaalde luchthaven staan.

Volgende output wordt verwacht:

```plaintext
Luchthaven: Heathrow Airport (3 toestellen)       
Vliegtuig: AB123 (Boeing 747) met 416 zitplaatsen 
Vliegtuig: CD456 (Airbus A380) met 555 zitplaatsen
Vliegtuig: EF789 (Boeing 737) met 189 zitplaatsen 

Luchthaven: John F. Kennedy International Airport (3 toestellen)
Vliegtuig: GH012 (Airbus A320) met 240 zitplaatsen
Vliegtuig: IJ345 (Embraer E190) met 100 zitplaatsen
Vliegtuig: KL678 (Bombardier CRJ900) met 90 zitplaatsen

Luchthaven: Los Angeles International Airport (3 toestellen)    
Vliegtuig: MN901 (Airbus A350) met 440 zitplaatsen
Vliegtuig: OP234 (Boeing 777) met 550 zitplaatsen
Vliegtuig: QR567 (Bombardier Q400) met 78 zitplaatsen

Luchthaven: Dubai International Airport (4 toestellen)
Vliegtuig: ST890 (Embraer E175) met 88 zitplaatsen
Vliegtuig: UV123 (Airbus A330) met 300 zitplaatsen
Vliegtuig: WX456 (Boeing 767) met 290 zitplaatsen
Vliegtuig: YZ789 (Embraer E195) met 120 zitplaatsen

Luchthaven: Tokyo Haneda Airport (4 toestellen)
Vliegtuig: AB901 (Airbus A319) met 144 zitplaatsen
Vliegtuig: CD234 (Boeing 757) met 200 zitplaatsen
Vliegtuig: EF567 (Airbus A321) met 236 zitplaatsen
Vliegtuig: GH890 (Bombardier CRJ700) met 70 zitplaatsen

Luchthaven: Beijing Capital International Airport (3 toestellen)
Vliegtuig: IJ123 (Embraer E170) met 76 zitplaatsen
Vliegtuig: KL456 (Boeing 787) met 242 zitplaatsen
Vliegtuig: MN789 (Airbus A300) met 266 zitplaatsen

Luchthaven: O'Hare International Airport (4 toestellen)
Vliegtuig: OP012 (Boeing 737 MAX) met 230 zitplaatsen
Vliegtuig: QR345 (Airbus A340) met 375 zitplaatsen
Vliegtuig: ST678 (Bombardier CRJ1000) met 104 zitplaatsen
Vliegtuig: UV901 (Embraer E145) met 50 zitplaatsen

Luchthaven: Charles de Gaulle Airport (3 toestellen)
Vliegtuig: WX234 (Boeing 717) met 110 zitplaatsen
Vliegtuig: YZ567 (Airbus A310) met 280 zitplaatsen
Vliegtuig: AB890 (Boeing 727) met 189 zitplaatsen

Luchthaven: Frankfurt Airport (3 toestellen)
Vliegtuig: CD123 (Bombardier CS300) met 160 zitplaatsen
Vliegtuig: EF456 (Airbus A220) met 135 zitplaatsen
Vliegtuig: GH789 (Boeing 737 NG) met 215 zitplaatsen

Luchthaven: Singapore Changi Airport (3 toestellen)
Vliegtuig: IJ012 (Embraer E135) met 37 zitplaatsen
Vliegtuig: KL345 (Airbus A318) met 107 zitplaatsen
Vliegtuig: MN678 (Boeing 757-300) met 240 zitplaatsen

Luchthaven: Hong Kong International Airport (3 toestellen)
Vliegtuig: OP901 (Bombardier CRJ200) met 50 zitplaatsen
Vliegtuig: QR234 (Airbus A321XLR) met 244 zitplaatsen
Vliegtuig: ST567 (Boeing 737 Classic) met 149 zitplaatsen

Luchthaven: Incheon International Airport (3 toestellen)
Vliegtuig: UV890 (Embraer E140) met 44 zitplaatsen
Vliegtuig: WX123 (Airbus A380plus) met 853 zitplaatsen
Vliegtuig: YZ456 (Boeing 737 Classic) met 85 zitplaatsen

Luchthaven: Amsterdam Airport Schiphol (3 toestellen)
Vliegtuig: AB789 (Bombardier Q300) met 50 zitplaatsen
Vliegtuig: CD012 (Embraer E150) met 50 zitplaatsen
Vliegtuig: EF345 (Airbus A319neo) met 160 zitplaatsen

Luchthaven: Denver International Airport (3 toestellen)
Vliegtuig: GH678 (Boeing 737 MAX 10) met 230 zitplaatsen
Vliegtuig: IJ901 (Bombardier Q200) met 37 zitplaatsen
Vliegtuig: KL234 (Airbus A330neo) met 440 zitplaatsen

Luchthaven: Suvarnabhumi Airport (3 toestellen)
Vliegtuig: MN567 (Boeing 757-200PF) met 0 zitplaatsen
Vliegtuig: OP890 (Embraer E195-E2) met 146 zitplaatsen
Vliegtuig: QR123 (Airbus A321neo) met 240 zitplaatsen

Luchthaven: Dallas/Fort Worth International Airport (3 toestellen)
Vliegtuig: ST456 (Boeing 747-8) met 467 zitplaatsen
Vliegtuig: UV789 (Bombardier CRJ550) met 50 zitplaatsen
Vliegtuig: WX012 (Airbus A320neo) met 194 zitplaatsen

Luchthaven: Indira Gandhi International Airport (3 toestellen)
Vliegtuig: YZ345 (Boeing 737 MAX 9) met 220 zitplaatsen
Vliegtuig: AB678 (Embraer E175-E2) met 88 zitplaatsen
Vliegtuig: CD901 (Airbus A321LR) met 240 zitplaatsen
```