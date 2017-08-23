using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb4.DTO
{
    public class OrderDTO
    {
		public System.Guid OrderId { get; set; }
		public pb4.DTO.Enums.SizeType Size { get; set; }
		public pb4.DTO.Enums.CrustType Crust { get; set; }
		public bool Sausage { get; set; }
		public bool Pepperoni { get; set; }
		public bool Onions { get; set; }
		public bool GreenPeppers { get; set; }
		public decimal TotalCost { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public pb4.DTO.Enums.PaymentType PaymentType { get; set; }
		public bool Complete { get; set; }
	}
}
