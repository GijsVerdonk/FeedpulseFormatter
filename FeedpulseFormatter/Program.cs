Console.Write("Onderwerp --> ");
var subject = Console.ReadLine();

Console.Write("Wat gaat goed? --> ");
var going_well = Console.ReadLine();

Console.Write("Wat kan beter? --> ");
var can_be_done_better = Console.ReadLine();

Console.Write("Volgende stap --> ");
var next_steps = Console.ReadLine();

string currentDateTime = DateTime.Now.ToString("dd-MM-yyyy_HH_mm_ss");

string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string fullFilePath = Path.Combine(desktopPath, $"Feedpulse_gemaakt_op_{currentDateTime}.txt");


using (StreamWriter writer = File.CreateText(fullFilePath))
{
    writer.WriteLine($"Feedback over {subject}:");
    writer.WriteLine();

    writer.WriteLine($"Wat gaat volgens de docent goed?");
    writer.WriteLine(going_well);
    writer.WriteLine();

    writer.WriteLine("Waaraan moet je volgens de docent meer aandacht besteden?");
    writer.WriteLine(can_be_done_better);
    writer.WriteLine();

    writer.WriteLine("Wat is je volgende stap om de leeruitkomst(en) te behalen?");
    writer.WriteLine(next_steps);
}

Console.Clear();
Console.WriteLine($"Bestand aangemaakt. (path: {fullFilePath})");