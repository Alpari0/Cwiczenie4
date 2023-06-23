void sortowanieWybieranie(int[] tablica)
{
    int n = tablica.Length;

    for (int i = 0; i < n - 1; i++)
    {
        int min = i;
        for (int j = i + 1; j < n; j++)
            if (tablica[j] < tablica[min])
                min = j;

        int abc = tablica[min];
        tablica[min] = tablica[i];
        tablica[i] = abc;
    }
}

int[] tablica = new int[10];
Random losowa = new Random();
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = losowa.Next(1, 100);
}

Console.WriteLine("Tablica przed sortowaniem: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}

sortowanieWybieranie(tablica);

Console.WriteLine("\nTablica po sortowaniu: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}