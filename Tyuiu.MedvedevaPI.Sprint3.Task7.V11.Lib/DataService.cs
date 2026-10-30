namespace Tyuiu.MedvedevaPI.Sprint3.Task7.V11.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task7V11
{
    public double[] GetMassFunction(int startValue, int stopValue)
    {
        double[] valueArray;
        int len = (stopValue - startValue) + 1;
        valueArray = new double[len];
        double y;
        int count = 0;
        for (int x = startValue; x<=stopValue;x++)
        {
            double d = 2 - 2 * x;
            if (d==0)
            {
                y = 0;
            }
            else
            {
                y = Math.Round((Math.Cos(x) + (Math.Sin(x) / (2 - 2 * x)) - 4 * x), 2);
               
            }
            valueArray[count] = y;
            count++;
        }
        return valueArray;
    }
}
