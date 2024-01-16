// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        arr[i] = rnd.Next(1, 10);
    }    
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine(" ");    
}

void FlipArray(int[] arr)
{
    int var = 0;
    for (int i = 0, j = arr.Length - 1; i <= j; i++, j--)
    {
        var = arr[i];
        arr[i] = arr[j];
        arr[j] = var;
    }
}

int n = 10;
int [] arr = new int [n];
FillArray(arr);
PrintArray(arr);
FlipArray(arr);
PrintArray(arr);



