using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4.Domain
{
    public class OrderManager
    {
		public static void CreateOrder(DTO.OrderDTO orderDTO)
		{
			// MOVED from DOMAIN to WEB
			/*
			// syntax good here 

			var order = new DTO.OrderDTO();
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
			orderDTO.OrderId = Guid.NewGuid();
			orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO);
			Persistence.OrderRepository.CreateOrder(orderDTO);
		}
	}
}
