using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceMakingExamples.Core
{
    public abstract class Customer
    {
        public abstract decimal DiscountPercentage { get; }
    }

    public class PayingCustomer : Customer
    {
        public override decimal DiscountPercentage
        {
            get { return 0.15m; }
        }
    }

    public class NonPayingCustomer : Customer
    {
        public override decimal DiscountPercentage
        {
            get { return 0.05m; }
        }
    }

    public class OrderProcessor
    {
        public decimal ProcessOrder(Customer customer, IEnumerable<Product> products)
        {
            decimal orderTotal = products.Sum(p => p.Price);

            orderTotal -= orderTotal * customer.DiscountPercentage;

            return orderTotal;
        }
    }

    public class Product
    {
        public int Price { get; set; }
    }
}
