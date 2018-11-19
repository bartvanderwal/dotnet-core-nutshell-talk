# .NET Core

## Vragen
- Vraag 1: Wat is het equivalent voor de JVM in .NET?
- Vraag 2: Bij Java hoort de spreuk 'Write once, run anywhere', welke spreuk hoorde bij .NET? (in ieder geval voordat .NET Core kwam)
- Vraag 3: Wat betekent `managed code`? Kun je ook 'unmanaged' code schrijven in .NET? (zo ja, hoe?, zo nee, waarom niet?)
- Vraag 4: Waarom beginnen properties in C# met een hoofdletter? (hint: gebruik het woord `structs` in je antwoord).
- Vraag 5: Wat is het equivalent van JDBC of JPA in .NET?
- Vraag 6: In wat voor soort klasse schrijf je een extension method? (hint: dit kan in Java niet, maar je kunt in Java dit keyword wel voor methodes zetten)
- Vraag 7: Welk keyword moet je voor de eerste parameter van een extensie methode zetten?
- Vraag 8: 

## Oefening extension method
Voeg een extension method `toDollar` voor floats in de `ExtensionMethods class`.

## Oefening unit test
Schrijf een xUnit unit test die test of `toDollar()` goed werkt.

## Oefening generics
Breid de extensie methode `ForEach` in `ExtensionMethods uit zodat hij voor iedere generieke `List<T>` werkt; in plaats van enkel voor `List<Talk>`

## Oefeningen Linq
Opdracht 1: Vul in de `TalksService` de methode `FindByTitleOrTalkername(string searchStringe)` in die via een linq statement op de meegegeven name een Talk vind in de `talks`. Zorg dat de unit test `FindByTitleOrTalkernameTest` werkt (`dotnet test -v m`).

Opdracht 2: Voeg in de `TalksService` een methode `SoonestTalk` toe die de eerstvolgende talk teruggeeft
Hints:
 - met `new Date()` krijg je de huidige datum/tijdstip (`var currentDate = new Date();`)
 - `select` dan `talk.ScheduledAt - currentDate`
 - met `.Min()` achteraan je link query pak je

Opdracht 3: Voeg nu ook in de `TalksController` een methode `FindByTalkTitleOrTalkername` toe die de methode uit de bijbehorende Service surface'd, zodat 

Opdracht 5: Voeg een lazy loaded property `AantalDagenTotVolgendeTalk` toe aan de TalksService


Schrijf een 