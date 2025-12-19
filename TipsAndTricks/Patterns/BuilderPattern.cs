using static TipsAndTricks.Patterns.PatternMatching;

namespace TipsAndTricks.Patterns
{
    public class OrderBuilder
    {
        private readonly Order _order;

        private OrderBuilder(Guid customerId)
        {
            _order = new Order { CustomerId = customerId };
        }

        public static OrderBuilder Create(Guid customerId)
            => new(customerId);

        public OrderBuilder WithShippingAddress(string address)
        {
            _order.ShippingAddress = address;
            return this;
        }

        public OrderBuilder WithDiscount(decimal discount)
        {
            _order.Discount = discount;
            return this;
        }

        public OrderBuilder WithPaymentMethod(string paymentMethod)
        {
            _order.PaymentMethod = paymentMethod;
            return this;
        }

        public Order Build() => _order;


    }

    public class BuilderPattern()
    {
        public Order CreateOrderObject(Guid customerId,
                                        string shippingAddress,
                                        decimal discount,
                                        string paymentMethod)
        {

            var order = OrderBuilder
                .Create(customerId)
                .WithShippingAddress(shippingAddress)
                .WithDiscount(discount)
                .WithPaymentMethod(paymentMethod)
                .Build();

            return order;
        }
    }
}
