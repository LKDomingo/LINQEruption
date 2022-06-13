List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!


// First Eruption in Chile
Eruption? ChileEruption = eruptions.FirstOrDefault(p => p.Location == "Chile");
System.Console.WriteLine($"Chile Eruption: {ChileEruption}");

// Hawaiian Island Eruption
Eruption? HIEruption = eruptions.FirstOrDefault(p => p.Location == "Hawaiian Is");
if (HIEruption != null) {
System.Console.WriteLine($"Hawaiian Island Eruption: {HIEruption}");
} else {
    System.Console.WriteLine("No Hawaiian Is Eruption found.");
}

// First eruption after 1900 and in New Zealand
Eruption? NZAfter1900 = eruptions.FirstOrDefault(p => p.Location == "New Zealand" && p.Year > 1900);
System.Console.WriteLine($"First New Zealand eruption after 1900: {NZAfter1900}");

// All eruptions over 2000m elevation
IEnumerable<Eruption> HighElev = eruptions.Where(e => e.ElevationInMeters > 2000);
PrintEach(HighElev, "High Elevation Eruptions:");

// Volcano name starting with 'Z'
IEnumerable<Eruption> ZVolcanoes = eruptions.Where(z => z.Volcano[0] == 'Z');
int count = 0;
foreach (Eruption i in ZVolcanoes) {
    count ++;
}
PrintEach(ZVolcanoes, $"Zvolcanoes count: {count}");
System.Console.WriteLine($"");

// Highest elevation Volcano
Eruption? HighestVolcano = eruptions.OrderByDescending(p => p.ElevationInMeters).FirstOrDefault();
int HighestVolcanoElevation = HighestVolcano.ElevationInMeters;
System.Console.WriteLine($"Highest Elevation Volcano in Meters: {HighestVolcanoElevation}");

// Find Highest elevation Volcano name with Elevation int
HighestVolcano = eruptions.Where(e => e.ElevationInMeters == HighestVolcanoElevation).FirstOrDefault();
string HighestVolcanoName = HighestVolcano.Volcano;
System.Console.WriteLine($"Highest Elevation Volcano name: {HighestVolcanoName}");

// All Volcano names alphabetically
IEnumerable<Eruption> AllEruptionsAlphabetically = eruptions.OrderBy(a => a.Volcano);
PrintEach(AllEruptionsAlphabetically, "All Eruptions Alphabetically:");

// All eruptions
IEnumerable<Eruption> EruptionsPre1000 = AllEruptionsAlphabetically.Where(d => d.Year < 1000);
PrintEach(EruptionsPre1000, "All eruptions before 1000");

// All eruptions 
IEnumerable<string> EruptionsPre1000Names = EruptionsPre1000.Select(v => v.Volcano);
PrintEach(EruptionsPre1000Names, "All eruptions before 1000");

// 


// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

