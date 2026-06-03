# Projekt Cichnamoni

## Stav projektu

Projekt je zatim rozpracovany. Mam pripraveny zakladni navrh trid a chci postupne dodelavat soubojovou logiku.

## Hotove casti

- vytvorena trida Utok
- vytvorena trida Cichnamon
- vytvorena trida Trener
- vytvoren zaklad Program.cs
- zakladni vytvareni objektu
- pripraveny seznam Cichnamonu u trenera
- pripraveny zakladni vypis informaci

## Co zatim neni hotove

- kompletni soubojovy system
- vyber akci v boji
- ukonceni souboje
- levelovani trenera
- lepsi menu
- vice Cichnamonu
- vice utoku
- lepsi vypisy

## Proc to delam takhle

Tak nejdriv chci mit spravne navrzene tridy a objekty.
Potom budu postupne pridavat metody a souboj.

Projekt nechci delat moc slozite, protoze chci tomu sam rozumet, co kazda trida a metoda dela.

## Tridy

### Utok

Trida Utok uklada informace o jednom utoku.

Atributy:
- Nazev
- Poskozeni

Metody:
- VypisInfo()

### Cichnamon

Trida Cichnamon predstavuje jedno monstrum.

Atributy:
- Jmeno
- Zdravi
- MaxZdravi
- ZakladniUtok
- SpecialniUtok

Metody:
- Zautoc()
- SpecialniZautoc()
- UberZdravi()
- Uzdrav()
- JeNazivu()
- VypisInfo()

### Trener

Trida Trener predstavuje hrace.

Atributy:
- Jmeno
- Level
- Cichnamoni
- Vybrany

Metody:
- PridatCichnamona()
- VyberCichnamona()
- VypisCichnamony()

## Co budu delat dal

1. Dodelam vyber Cichnamona.
2. Dodelam jednoduchy souboj.
3. Pridam zakladni a specialni utok.
4. Pridam leceni.
5. Pridam konec souboje.
6. Pridam level po vyhre.
7. Upravim vypisy, aby byly prehlednejsi.