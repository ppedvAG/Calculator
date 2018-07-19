namespace Calculator.Models
{
    public interface ICalculationOperation
    {
        char Operator { get; }
        int Calculate(int v1, int v2);
    }
}
