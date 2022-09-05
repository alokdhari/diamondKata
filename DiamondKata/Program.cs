var midPointCharacter = Environment.GetCommandLineArgs()[1].ToCharArray()[0];

Console.WriteLine(new DiamondPrinter(midPointCharacter).Print());

// Wait for input
Console.ReadLine();