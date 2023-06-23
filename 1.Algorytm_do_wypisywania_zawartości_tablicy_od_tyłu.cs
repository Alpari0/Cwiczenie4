
using System;

int[] tablica = new int[10];
Random losowaLiczba = new Random();
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = losowaLiczba.Next(1, 100);
}

Console.WriteLine("Tablica od tyłu:");
for (int i = tablica.Length - 1; i >= 0; i--)
{
    Console.WriteLine(tablica[i]);
}
