namespace Tyuiu.MedvedevaPI.Sprint3.Task1.V11;

using Tyuiu.MedvedevaPI.Sprint3.Task1.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double value = 0.75;
        int startValue = 1;
        int stopValue = 14;
        Console.WriteLine("переменная X = " + value);
        Console.WriteLine("старт шага = " + startValue);
        Console.WriteLine("конец шага = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Суммы ряда =" + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}