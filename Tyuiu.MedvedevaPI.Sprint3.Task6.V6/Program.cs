namespace Tyuiu.MedvedevaPI.Sprint3.Task6.V6;

using Tyuiu.MedvedevaPI.Sprint3.Task6.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue = 16;
        int stopValue = 24;
        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Количество делителей больше 10 = " + ds.GetSumTheDivisors( startValue,  stopValue));
        Console.ReadKey();
    }
}