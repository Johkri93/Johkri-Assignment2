# Johkri-Assignment2

## Projektbeskrivning
Detta projekt är en fordonsfabrik-applikation som skapar och hanterar olika typer av fordon (bil och motorcykel) med hjälp av fabriker. Applikationen följer objektorienterade principer som arv, polymorfism och interfaces. 

### Funktioner
- Skapa bilar och motorcyklar med specifika egenskaper.
- Starta och stoppa motorerna på fordonen.
- Ändra egenskaper som antal dörrar på bilar och motortyp på motorcyklar.
- Använda fabriker för att skapa fordon.
- Polymorfism används för att hantera fordonens gemensamma egenskaper.

## Strukturbeskrivning

Johkri-Assignment2/
├── Program.cs                # Huvudprogrammet som kör applikationen
├── Factories/                # Innehåller fabriker för att skapa fordon
│   ├── CarFactory.cs         # Fabrik för att skapa bilar
│   └── MotorcycleFactory.cs  # Fabrik för att skapa motorcyklar
├── Interfaces/               # Innehåller alla interfaces
│   ├── ICar.cs               # Interface för bilar
│   ├── IMotorcycle.cs        # Interface för motorcyklar
│   ├── IVehicle.cs           # Interface för fordon
│   └── IDriveable.cs         # Interface för körbara fordon
├── Models/                   # Implementering av fordon
│   ├── CarImpl.cs            # Implementering av bilar
│   └── MotorcycleImpl.cs     # Implementering av motorcyklar
├── Docs/                     # Dokumentation
│   └── Reflections.md        # Personliga reflektioner kring projektet
└── .gitignore                # Lista över filer som inte ska inkluderas i versionskontroll


## Installation och körning

### Förutsättningar
- .NET SDK installerat

### Bygga och köra projektet

1. Klona projektet från GitHub: git clone https://github.com/Johkri93/Johkri-Assignment2.git

2. Navigera till projektmappen:
cd Johkri-Assignment2

3. Bygg projektet:
dotnet build

4. Kör applikationen:
dotnet run


## Användning
När programmet körs kommer det att:
1. Skapa en bil och en motorcykel med hjälp av fabrikerna.
2. Starta och stoppa motorerna på båda fordonen.
3. Ändra antalet dörrar på bilen och motortypen på motorcykeln.
4. Skriva ut fordonens information och motorstatus.

## Reflektioner
Se [Reflections.md](./Docs/Reflections.md) för en reflektion över projektet och arbetsprocessen.