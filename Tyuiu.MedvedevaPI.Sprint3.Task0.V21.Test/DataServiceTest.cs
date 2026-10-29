namespace Tyuiu.MedvedevaPI.Sprint3.Task0.V21.Test;

using Tyuiu.MedvedevaPI.Sprint3.Task0.V21.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumSeries()
    {
        DataService ds = new DataService();
        double value = 1.5;
        int startValue = 1;
        int stopValue = 13;
        double res = ds.GetSumSeries(value, startValue, stopValue);
        double wait = -63.727;
        Assert.AreEqual(wait, res);
    }
}
