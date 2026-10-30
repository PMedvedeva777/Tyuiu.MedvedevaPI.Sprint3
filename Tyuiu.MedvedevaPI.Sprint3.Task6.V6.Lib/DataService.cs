namespace Tyuiu.MedvedevaPI.Sprint3.Task6.V6.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task6V6
{
    public int GetSumTheDivisors(int startValue, int stopValue)
    {
        int x;
        int c = 0;
        for (x=startValue;x<=stopValue;x++)
        {
            for (int d = 1;d<=x;d++)
            {
                if ((x%d==0) && (d>10))
                {
                    c += 1;
                }
            }
        }
        return c;
    }
}
