namespace Tyuiu.MedvedevaPI.Sprint3.Task0.V21;

using Tyuiu.MedvedevaPI.Sprint3.Task0.V21.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double value = 1.5;
        int startValue = 1;
        int stopValue = 13;
        Console.WriteLine("переменная X = " + value);
        Console.WriteLine("старт шага = " + startValue);
        Console.WriteLine("конец шага = " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Суммы ряда =" + ds.GetSumSeries(value, startValue, stopValue));
        Console.ReadKey(); 
    }
}