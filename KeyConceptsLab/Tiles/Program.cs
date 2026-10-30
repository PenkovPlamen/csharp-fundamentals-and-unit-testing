double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomHeight = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileHeight = double.Parse(Console.ReadLine());
double bathroomArea = bathroomWidth * bathroomHeight;
double bathroomSurplus = bathroomArea * 1.1;
double tileArea = tileWidth * tileHeight;
double tilesNeeded = bathroomSurplus / tileArea;
Console.WriteLine($"{Math.Round(tilesNeeded)}");