// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

int slag;
slag = 0;
var random = new Random();
var tärningar = new List<Tärning>(5);
for (int i = 0; i < tärningar.Capacity; i++)
{
    tärningar.Add(new Tärning(random.Next(1,7)));
}
slag += 1;

foreach (Tärning y in tärningar)
{
    Console.WriteLine(y.tärningsnum + " " + y.spara);
}

Console.WriteLine();

Console.Write("Vad ska sparas? ");
var tärnspara = Console.ReadLine().Split(",").Select(int.Parse).ToList();
foreach (var t in tärnspara)
{ 
    tärningar[t-1].spara = true;
}
foreach (Tärning y in tärningar)
{
    Console.WriteLine(y.tärningsnum + " " + y.spara);
}

Console.WriteLine("Slå igen?");
Console.ReadLine();

foreach (var t in tärningar)
{
    if (t.spara == false)
    {
        t.tärningsnum = random.Next(1, 7);
    }
    t.spara = false;        
}

slag += 1;

foreach (Tärning y in tärningar)
{
    Console.WriteLine(y.tärningsnum + " " + y.spara);
}



class Tärning
{
    public int tärningsnum;
    public bool spara;

    public Tärning(int tärningsnum, bool spara = false)
    {
        this.tärningsnum = tärningsnum;
        this.spara = spara;
    }
}
