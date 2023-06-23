void sortowanieWstawianie(int[] tablica)
{
    int n = tablica.Length;
    for (int i = 1; i < n; ++i)
    {
        int abc = tablica[i];
        int j = i - 1;

        while (j >= 0 && tablica[j] > abc)
        {
            tablica[j + 1] = tablica[j];
            j = j - 1;
        }
        tablica[j + 1] = abc;
    }
}

int[] tablica = new int[10];
Random randNum = new Random();
for (int i = 0; i < tablica.Length; i++)
{
    tablica[i] = randNum.Next(1, 100);
}

Console.WriteLine("Tablica przed sortowaniem: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}

sortowanieWstawianie(tablica);

Console.WriteLine("\nTablica po sortowaniu: ");
for (int i = 0; i < tablica.Length; i++)
{
    Console.Write(tablica[i] + " ");
}