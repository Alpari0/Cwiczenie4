void sortowanieBabelkowe(int[] tablica)
{
    int n = tablica.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (tablica[j] > tablica[j + 1])
            {
                int abc = tablica[j];
                tablica[j] = tablica[j + 1];
                tablica[j + 1] = abc;
            }
}
int[] tablica = new int[10];
Random losowaLiczba = new Random();
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = losowaLiczba.Next(1, 100);
}

Console.WriteLine("Tablica przed sortowaniem: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}

sortowanieBabelkowe(tablica);

Console.WriteLine("\nTablica po sortowaniu: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}