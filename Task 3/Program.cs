// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void PrintArrayNumbers(int[] list, int i)
{
    if (i < list.Length)
    {
        Console.Write(list[i] + " ");
        PrintArrayNumbers(list, i+1);

    }
}
void PrintReverseArray(int[] list, int j)
{
    if (list.Length > 0)
    {
        Console.Write(list[list.Length-j-1] + " ");
        PrintReverseArray(list, j+1);
    }
}
int[] array = {1, 10, 3, 54, 8};
PrintArrayNumbers(array, 0);
Console.WriteLine();
PrintReverseArray(array, 0);