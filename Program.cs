// задача 25
Console.WriteLine("Введите число: ");
int Num=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень: ");
int Step=int.Parse(Console.ReadLine()!);
double Value=StepenNum(Num, Step);
Console.WriteLine(Value);


double StepenNum(double Number, double Stepen)
{
    double result=Math.Pow(Number, Stepen);
    return result;
}