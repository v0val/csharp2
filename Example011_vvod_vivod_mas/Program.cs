void FillArray(int[] collection)

{
    int dlina = collection.Length;
    int index = 0;
    while (index < dlina)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintMas(int[] col)
{
    int dlina2 = col.Length;
    int index = 0;
    while (index < dlina2)
    {
        Console.WriteLine(col[index]);
        index++;
    }
}

int[] mas =  new int[10];
FillArray(mas);
PrintMas(mas);