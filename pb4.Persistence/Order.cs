//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pb4.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public System.Guid OrderId { get; set; }
        public int Size { get; set; }
        public int Crust { get; set; }
        public bool Sausage { get; set; }
        public bool Pepperoni { get; set; }
        public bool Onions { get; set; }
        public bool GreenPeppers { get; set; }
        public decimal TotalCost { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public int PaymentType { get; set; }
        public bool Complete { get; set; }
    }
}
