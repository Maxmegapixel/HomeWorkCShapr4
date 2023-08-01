// // задача 25
// Console.WriteLine("Введите число: ");
// int Num=int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень: ");
// int Step=int.Parse(Console.ReadLine()!);
// double Value=StepenNum(Num, Step);
// Console.WriteLine(Value);


// double StepenNum(double Number, double Stepen)
// {
//     double result=Math.Pow(Number, Stepen);
//     return result;
// }

// Задача 27

// Console.WriteLine("Введите число: ");
// int Num = int.Parse(Console.ReadLine()!);
// int Value = SummNum(Num);
// Console.WriteLine(Value);

// int SummNum(int Number)
// {
//     int result = 0;
//     for (; Number > 0; Number /= 10)
//     {
//         result += Number % 10;
//     }
//     return result;
// }
// Задача 29


int[] ArrayGet(int Size)
{
    int[] result = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}

Console.WriteLine("Укажите размер массива: ");
int Value = int.Parse(Console.ReadLine()!);
int[] Array = ArrayGet(Value);
Console.WriteLine($"[{String.Join(',', Array)}]");
