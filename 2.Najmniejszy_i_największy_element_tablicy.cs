//Deklaracja elementów w tablicy
int[] arr = new int[10] { 31, 22, 83, 47, 59, 6, 72, 38, 91, 10 };
int min = arr[0];
int max = arr[0];

//Algorytm, który wyszukuje najmniejszy i największy element tablicy
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
        min = arr[i];
    if (arr[i] > max)
        max = arr[i];
}


//Wypisanie wszystkich elementów tablicy
Console.WriteLine("Wszystkie elementy tablicy: ");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
//Wypisanie największego i najmniejszego elementu tablocy
Console.WriteLine("\nNajmniejszy element: " + min);
Console.WriteLine("Największy element: " + max);