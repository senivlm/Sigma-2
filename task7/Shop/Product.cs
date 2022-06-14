using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public string Name { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0;
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
                else
                    weight = 0;
            }
        }

        public Product() : this(default, default, default)
        {

        }
        public Product(string Name, double Price, double Weight)
        {
            this.Name = Name;
            this.Price = Price;
            this.Weight = Weight;
        }

        public virtual double ChangePrice(double percent)
        {
            this.Price += this.Price * percent / 100;
            return Price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}";
        }


    }
}
