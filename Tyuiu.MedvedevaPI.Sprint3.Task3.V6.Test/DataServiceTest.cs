namespace Tyuiu.MedvedevaPI.Sprint3.Task3.V6.Test;
using Tyuiu.MedvedevaPI.Sprint3.Task3.V6.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidReplaceNumOnChar()
    {
        DataService ds = new DataService();
        string str = "12able 1o s4gh";
        string res = ds.ReplaceNumOnChar(str, 't');
        string wait = "ttable to stgh";
        Assert.AreEqual(wait, res);
    }
}
