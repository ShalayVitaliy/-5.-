// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int Data(string text)
{
    Console.Write(text);
    string num = Console.ReadLine();
    int don = int.Parse(num);
    return don;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int Sum(int[] array)
{
    int count = 0;
    for(int i = 1; i < array.Length; i+=2)
        {
            count = count + array[i];
        }
    return count;
}

int n = Data("Enter the length of array: ");
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
Console.Write(Sum(arr));