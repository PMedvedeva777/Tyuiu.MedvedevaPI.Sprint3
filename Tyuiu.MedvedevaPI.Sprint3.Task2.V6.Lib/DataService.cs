namespace Tyuiu.MedvedevaPI.Sprint3.Task2.V6.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task2V6
{
    public double GetMultiplySeries(double value, int startValue, int stopValue)
    {
        double MultSeries = 1;
        do
        {
            MultSeries = MultSeries * (Math.Pow(value, startValue) * Math.Cos(4));
            startValue++;
        } while (startValue <= stopValue);
        return Math.Round(MultSeries, 3);
    }
}
