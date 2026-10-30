namespace Tyuiu.MedvedevaPI.Sprint3.Task6.V6.Test;

using Tyuiu.MedvedevaPI.Sprint3.Task6.V6.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidGetSumTheDivisors()
    {
        DataService ds = new DataService();
        int startValue = 16;
        int stopValue = 24;
        int res = ds.GetSumTheDivisors(startValue, stopValue);
        int wait = 11;
        Assert.AreEqual(wait, res);
    }
}
