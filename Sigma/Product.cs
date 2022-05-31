using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        public string Name { get; set; }
        private float price;

        public float Price
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

        private float weight;

        public float Weight
        {
            get { return weight; }
            set 
            { 
                if(value > 0)
                    weight = value;
                else
                    weight = 0;
            }
        }

        public Product() : this(default, default, default)
        {

        }
        public Product(string Name, float Price, float Weight)
        {
            this.Name = Name;
            this.Price = Price;
            this.Weight = Weight;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Weight: {Weight}";
        }


    }
}
