namespace TipsAndTricks.Patterns.Interfaces
{
    public interface IDiscountStrategy
    {
        decimal Apply(decimal price);
    }
}
