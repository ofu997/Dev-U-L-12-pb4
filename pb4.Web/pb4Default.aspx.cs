﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pb4.DTO.Enums;

namespace pb4.Web
{
	public partial class pb4Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		/*
		protected void Button1_Click(object sender, EventArgs e)
		{
			// came from DOMAIN OrderManager.

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
			// thing works 
			Domain.OrderManager.CreateOrder(order);
		}
		*/
		protected void orderButton_Click(object sender, EventArgs e)
		{
			if (nameTextBox.Text.Trim().Length == 0)
			{
				validationLabel.Text = "Please enter a name";
				validationLabel.Visible = true;
				return;
			}
			if (addressTextBox.Text.Trim().Length == 0)
			{
				validationLabel.Text = "Please enter an address";
				validationLabel.Visible = true;
				return;
			}
			if (zipTextBox.Text.Trim().Length == 0)
			{
				validationLabel.Text = "Please ente ra zip code";
				validationLabel.Visible = true;
				return;
			}
			if (phoneTextBox.Text.Trim().Length == 0)
			{
				validationLabel.Text = "Please enter a phone number";
				validationLabel.Visible = true;
				return;
			}

			try
			{
				var order = buildOrder();
				Domain.OrderManager.CreateOrder(order);
			}
			catch (Exception e2)
			{
				validationLabel.Text = e2.Message;
				validationLabel.Visible = true;
				return; 
			}
		}

		private PaymentType determinePaymentType()
		{
			DTO.Enums.PaymentType paymentType;
			if (cashRadioButton.Checked)
			{
				paymentType = DTO.Enums.PaymentType.Cash;
			}
			else //if (creditRadioButton.Checked)
			{
				paymentType = DTO.Enums.PaymentType.Credit;
			}
			/*
			else
			{
				throw new Exception("Payment type not selected . "); 
			}
			*/
			return paymentType;
		}

		private CrustType determineCrust()
		{
			// throw new NotImplementedException();
			DTO.Enums.CrustType crust;
			if (!Enum.TryParse(crustDropDownList.SelectedValue, out crust))
			{
				throw new Exception("Can't determine pizza crust.");
			}
			return crust; 
		}

		private DTO.Enums.SizeType determineSize()
		{
			DTO.Enums.SizeType size;
			if (!Enum.TryParse(sizeDropDownList.SelectedValue, out size))
			{
				throw new Exception("Could not determine pizza crust~!");
				//order.Size = size;
			}
			return size; 
		}
		protected void recalculateTotalCost(object sender, EventArgs e)
		{
			if (sizeDropDownList.SelectedValue == String.Empty) return;
			if (crustDropDownList.SelectedValue == String.Empty) return;

			var order = buildOrder();

			try
			{
				totalLabel.Text = Domain.PizzaPriceManager.CalculateCost(order).ToString("C");
			}
			catch
			{
				//swww
			}
		}

		private DTO.OrderDTO buildOrder()
		{
			// var order = DTO.OrderDTO.
			var order = new DTO.OrderDTO();

			order.Size = determineSize();

			order.Crust = determineCrust();

			order.Sausage = sausageCheckBox.Checked;

			order.Pepperoni = pepperoniCheckBox.Checked;

			order.Onions = onionsCheckBox.Checked;

			order.GreenPeppers = greenPeppersCheckBox.Checked;

			order.Name = nameTextBox.Text;

			order.Address = addressTextBox.Text;

			order.Zip = zipTextBox.Text;

			order.Phone = phoneTextBox.Text;

			order.PaymentType = determinePaymentType();

			return order;
		}
	}
}