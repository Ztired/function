// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

string StopQ(string n)
{   
    string q = "q";
    if ( n == q)
    {
       return "1"; 
    }
    return "2"; 
} 
int GetEvenNumber(int n)
{
    if ( n % 2 == 0)
    {
       return 1; 
    }
    return 2; 
}

while (true)
{
Console.Write("Введите целое цисло: ");
string n = Console.ReadLine();
StopQ(n);

if ( StopQ(n) == "1")
{
    Console.WriteLine("Программа остановлена");
    return; 
}

if (int.TryParse(n, out int number))
{
    if ( GetEvenNumber(Convert.ToInt32(n)) == 1)
    {
        Console.WriteLine("Число чётное. Программа остановлена.");
        return; 
    }
}
else
{
    Console.WriteLine("Недопустимое выражение"); 
}
}


