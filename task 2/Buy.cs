using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Buy
    {
        Product product { get; }
        private int count;

        public int Count
        {
            get { return count; }
            set
            {
                if (value > 0)
                    count = value;
                else
                    count = 0;
            }
        }


        private double countWeight;

        public double CountWeight
        {
            get { return countWeight; }
            private set { countWeight = Count * product.Weight; }
        }

        private double countPrice;

        public double CountPrice
        {
            get { return countPrice; }
            set { countPrice = Count * product.Price; }
        }

        public Buy(Product product, int Count)
        {
            this.product = product;
            this.Count = Count;
        }

        public Buy() : this(default, default)
        {

        }

        public override string? ToString()
        {
            return $"Count: {Count}, Count price: {CountPrice}, Count weight: {CountWeight}";
        }
    }


}
