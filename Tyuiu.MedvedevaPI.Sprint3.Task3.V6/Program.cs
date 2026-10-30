namespace Tyuiu.MedvedevaPI.Sprint3.Task3.V6;

using Tyuiu.MedvedevaPI.Sprint3.Task3.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string value = "12able 1o s4gh";
        char chr = 't';
        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Искомый символ = " + chr);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Итоговая строка =" + ds.ReplaceNumOnChar(value,chr));
        Console.ReadKey();
    }
}