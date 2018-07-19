namespace Calculator.Models
{
    public interface IParser
    {
        Formula Parse(string input);
    }
}