namespace OptiDesk.Order.Dto
{
    public class OrderUser
    {
        public int UserId { get; set; }

        public int OrderId { get; set; }

        public String ProductRef { get; set; }

        public DateTime OrderTime { get; set; }

        public OrderUser(int orderId, int userId, string productRef, DateTime orderTime)
        {
            OrderId = orderId;
            UserId = userId;
            ProductRef = productRef;
            OrderTime = orderTime;
        }   
    }
}
