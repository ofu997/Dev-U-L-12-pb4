using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace pb4.Persistence
{
    public class OrderRepository
    {
		public static void CreateOrder(DTO.OrderDTO orderDTO)
		{
			var db = new pb4DbEntities();

			var order = ConvertToEntity(orderDTO);
			/*
			order.OrderId = Guid.NewGuid();

			//order.Size= 1;
			// this below works for now
			order.Size = DTO.Enums.SizeType.Large;

			// DTO.Enums.SizeType.Large
			order.Crust = DTO.Enums.CrustType.Thick;
			order.Pepperoni = true;
			order.Name = "the tech academy";
			order.Address = "300 SW 5th Avenue";
			order.Zip = "97201";
			order.Phone = "123-1234";
			order.PaymentType = DTO.Enums.PaymentType.Credit;
			order.TotalCost = 16.50M;
			*/
			db.Orders.Add(order);
			db.SaveChanges();
		}

		private static Order ConvertToEntity(DTO.OrderDTO orderDTO)
		{
			// syntax good here
			var order = new Order();

			order.OrderId = orderDTO.OrderId;
			order.Size = orderDTO.Size;
			order.Crust = orderDTO.Crust;
			order.Sausage = orderDTO.Sausage;
			order.Pepperoni = orderDTO.Pepperoni;
			order.Onions = orderDTO.Onions;
			order.GreenPeppers = orderDTO.GreenPeppers;
			order.Name = orderDTO.Name;
			order.Address = orderDTO.Address;
			order.Phone = orderDTO.Phone;
			order.Zip = orderDTO.Zip;
			order.TotalCost = orderDTO.TotalCost;
			order.PaymentType = orderDTO.PaymentType;
			order.Complete = orderDTO.Complete;

			return order;
		}

		public static List<DTO.OrderDTO> GetOrders()
		{
			var db = new pb4DbEntities();
			// complete for completed 
			var orders = db.Orders.Where(p=>p.Complete==false).ToList();

			var ordersDTO = convertToDTO(orders);
			return ordersDTO;
		}
		private static List<DTO.OrderDTO> convertToDTO(List<Order> orders)
		{
			var ordersDTO = new List<DTO.OrderDTO>();
			foreach (var order in orders)
			{
				var orderDTO = new DTO.OrderDTO();
				orderDTO.OrderId = order.OrderId;
				orderDTO.Crust = order.Crust;
				orderDTO.Size = order.Size;
				orderDTO.Name = order.Name;
				// do hcange these 
				orderDTO.Address = order.Address;
				orderDTO.Zip = order.Zip;
				orderDTO.Phone = order.Phone;
				// toppings 12:00
				orderDTO.Sausage = order.Sausage;
				orderDTO.Pepperoni = order.Pepperoni;
				orderDTO.Onions = order.Onions;
				orderDTO.GreenPeppers = order.GreenPeppers;
				orderDTO.PaymentType = order.PaymentType;
				orderDTO.Complete = order.Complete;

				ordersDTO.Add(orderDTO);
			}
			return ordersDTO;
		}
	}
}
