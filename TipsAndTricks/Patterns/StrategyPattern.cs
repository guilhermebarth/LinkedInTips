using TipsAndTricks.Patterns.Interfaces;

namespace TipsAndTricks.Patterns
{
    public class WithoutStrategyPattern
    {
        public decimal CalculateDiscount(string customerType, decimal amount)
        {
            if (customerType == "Regular")
                return amount * 0.05m;

            if (customerType == "Premium")
                return amount * 0.10m;

            if (customerType == "Vip")
                return amount * 0.20m;

            throw new Exception("Invalid customer type");
        }
    }



    public class VipDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.8m;
    };

    public class StudentDiscount : IDiscountStrategy
    {
        public decimal Apply(decimal price) => price * 0.9m;
    };

    public class StrategyPattern
    {
        protected void ApplyDiscount()
        {
            // Usage
            var strategy = new VipDiscount();
            var finalPrice = strategy.Apply(100);
        }
    }
}
