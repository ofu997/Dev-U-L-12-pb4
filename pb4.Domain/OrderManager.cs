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
			// validation
			if (orderDTO.Address.Trim().Length == 0)
				throw new Exception("address is required.");
			if (orderDTO.Name.Trim().Length == 0)
				throw new Exception("name is required.");
			if (orderDTO.Phone.Trim().Length == 0)
				throw new Exception("phone is required.");
			if (orderDTO.Zip.Trim().Length == 0)
				throw new Exception("zip code is required.");

			orderDTO.OrderId = Guid.NewGuid();
			orderDTO.TotalCost = PizzaPriceManager.CalculateCost(orderDTO);
			Persistence.OrderRepository.CreateOrder(orderDTO);
		}

		public static object GetOrders()
		{
			return Persistence.OrderRepository.GetOrders();
		}
	}
}
