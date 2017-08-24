using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pb4.DTO;

namespace pb4.Domain
{
	public class PizzaPriceManager
	{
		public static decimal CalculateCost(DTO.OrderDTO order)
		{
			decimal cost  = 0.0M;
			var prices = getPizzaPrices();
			cost += calculateSizeCosts(order,prices);
			cost += calculateCrustCost(order, prices);
			cost += calculateToppings(order, prices);

			return cost;
		}

		private static decimal calculateToppings(OrderDTO order, DTO.PizzaPriceDTO prices)
		{
			decimal cost = 0.0M;
			cost += (order.Sausage) ? prices.SausageCost : 0M;
			cost += (order.Pepperoni) ? prices.PepperoniCost : 0M;
			cost += (order.Onions) ? prices.OnionsCost : 0M;
			cost += (order.GreenPeppers) ? prices.GreenPeppersCost : 0M;
			return cost;
		}

		private static decimal calculateCrustCost(OrderDTO order, DTO.PizzaPriceDTO prices)
		{
			decimal cost = 0.0M;
			switch (order.Crust)
			{
				case pb4.DTO.Enums.CrustType.Regular:
					cost = prices.RegularCrustCost;
					break;
				case pb4.DTO.Enums.CrustType.Thin:
					cost = prices.ThinCrustCost;
					break;
				case pb4.DTO.Enums.CrustType.Thick:
					cost = prices.ThickCrustCost;
					break;
				default:
					break;
			}
			return cost;
		}

		private static decimal calculateSizeCosts(OrderDTO order, DTO.PizzaPriceDTO prices)
		{
			decimal cost = 0.0M;
			switch (order.Size)
			{
				case pb4.DTO.Enums.SizeType.Small:
					cost = prices.SmallSizeCost;
					break;
				case pb4.DTO.Enums.SizeType.Medium:
					cost = prices.MediumSizeCost;
					break;
				case pb4.DTO.Enums.SizeType.Large:
					cost = prices.LargeSizeCost;
					break;
				default:
					break;
			}
			return cost;
		}

		private static DTO.PizzaPriceDTO getPizzaPrices()
		{
			var prices = Persistence.PizzaPriceRepository.GetPizzaPrices();
			return prices;
		}
	}
}
