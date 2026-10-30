namespace Tyuiu.MedvedevaPI.Sprint3.Task7.V11;

using Tyuiu.MedvedevaPI.Sprint3.Task7.V11.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+-------+-------+");
        Console.WriteLine("|   x   |  f(x) |");
        Console.WriteLine("+-------+-------+");
        for (int i = 0;i<=len-1;i++)
        {
            Console.WriteLine("|{0,5:d}   |  {1,5:f2}|", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+-------+-------+");
        Console.ReadKey();
    }
}