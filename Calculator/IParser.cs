namespace Calculator
{
    public interface IParser
    {
        Formula Parse(string input);
    }
}