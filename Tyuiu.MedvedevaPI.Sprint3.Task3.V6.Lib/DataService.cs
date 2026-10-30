namespace Tyuiu.MedvedevaPI.Sprint3.Task3.V6.Lib;

using tyuiu.cources.programming.interfaces.Sprint3;

public class DataService : ISprint3Task3V6
{
    public string ReplaceNumOnChar(string value, char item)
    {
        string result = "";
        foreach(char chr in value)
        {
            if (Char.IsDigit(chr))
            {
                result += item;

            }
            else
            {
                result += chr;
            }
        }
        return result;
    }
}
