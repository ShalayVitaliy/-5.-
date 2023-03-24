// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int Prompt(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Int16.Parse(value);
    return result;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 1000);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(",", array)}]");
}

int Diff(int[] array)
{
    int max = array[0];
    int min = array[0];
    int result =0;
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    Console.WriteLine($"Max = {max}, Min = {min}");
    return (max - min);    
}

int n = Prompt("Enter the size of array: ");
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
Console.Write($"Difference = {Diff(arr)}");