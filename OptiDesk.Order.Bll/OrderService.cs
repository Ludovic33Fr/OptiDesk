using OptiDesk.Order.Dto;

namespace OptiDesk.Order.Bll
{
    public class OrderService
    {
        public List<OrderUser> GetAllOrders() 
        {
            Random rnd = new Random();
            List<OrderUser> res = new List<OrderUser>();
            int orderId = 2000;
            for (int i = 0; i < 200; i++)
            {
                res.Add(new OrderUser(orderId++, rnd.Next(1, 10),
                    Guid.NewGuid().ToString(),
                    DateTime.Now.AddDays(-rnd.Next(100)).AddMinutes(-rnd.Next(100))));
            }

            return res;
        }

        public OrderUser GetAllOrdersById(int id)
        {
            var allOrders = GetAllOrders();
            var res = allOrders.First<OrderUser>(p => p.OrderId == id);

            return res;
        }

        public List<OrderUser> GetAllOrdersByUserId(int userId)
        {
            var allOrders = GetAllOrders();
            var res = allOrders.Where<OrderUser>(p => p.UserId == userId).ToList();

            return res;
        }
    }
}
