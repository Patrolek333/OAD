using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; 

class Program
{
    static void Main()
    {
        string inputFile = "ranking_raw.txt";
        string outputFile = "ranking_clean.txt";

        List<string> lines = new List<string>(File.ReadAllLines(inputFile));

        if (lines.Count == 0)
        {
            Console.WriteLine("Error: Plik jest pusty");
            return;
        }

        List<string> cleanLines = new List<string>();

        string header = lines[0];
        cleanLines.Add(header);

        for (int i = 1; i < lines.Count; i++)
        {
            string line = lines[i].Trim();

            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] fields = line.Split(';');

            if (fields.Length != 5)
                continue; 

            string nick = fields[0];
            string czas = fields[1];
            string raw = fields[2];
            string status = fields[3];
            string opis = fields[4];


            int punkty;
            if (!int.TryParse(raw, out punkty))
                punkty = 0;

            if (status.ToUpper() == "HACKER" 
                czas == "00:00:01" 
                czas == "0:00:01")
            {
                continue; 
            }

            string newLine = $"{nick};{czas};{punkty};{status};{opis}";
            cleanLines.Add(newLine);
        }

        File.WriteAllLines(outputFile, cleanLines);

        Console.WriteLine("=== Prawidowy ranking (ranking_clean.txt) ===");
        foreach (string l in File.ReadAllLines(outputFile))
        {
            Console.WriteLine(l);
        }
    }
}