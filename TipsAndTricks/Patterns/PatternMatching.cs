using static TipsAndTricks.Patterns.PatternMatching.Order;

namespace TipsAndTricks.Patterns
{
    public class PatternMatching
    {
        public class Order
        {
            public OrderStatus Status { get; set; }
            public enum OrderStatus { Pending, Shipped, Cancelled }

            public string GetStatusMessage(Order order)
            {
                if (order == null)
                    return "Order not found";

                if (order.Status == OrderStatus.Pending)
                    return "Order pending";

                if (order.Status == OrderStatus.Shipped)
                    return "Order shipped";

                if (order.Status == OrderStatus.Cancelled)
                    return "Order cancelled";

                return "Unknown status";
            }
        }

        public string GetStatusMessage(Order? order) =>
            order switch
            {
                null => "Order not found",
                { Status: OrderStatus.Pending } => "Order pending",
                { Status: OrderStatus.Shipped } => "Order shipped",
                { Status: OrderStatus.Cancelled } => "Order cancelled",
                _ => "Unknown status"
            };

    }
}
