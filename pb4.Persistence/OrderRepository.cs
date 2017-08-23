using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4.Persistence
{
    public class OrderRepository
    {
		public static void CreateOrder()
		{
			var db = new pb4DbEntities();
			var order = new Order();
			order.OrderId = Guid.NewGuid();
			//order.Size= 1;
			// this below works for now
			order.Size = DTO.Enums.SizeType.Large;
			// DTO.Enums.SizeType.Large
			order.Crust=DTO.Enums.CrustType.Regular;
			order.Pepperoni=true;
			order.Name="the tech academy";
			order.Address="300 SW 5th Avenue";
			order.Zip="97201";
			order.Phone="123-1234";
			order.PaymentType=0;
			order.TotalCost=16.50M;

			db.Orders.Add(order);
			db.SaveChanges();
		}
    }
}
