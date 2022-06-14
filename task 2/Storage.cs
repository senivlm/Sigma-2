namespace Shop
{
    public class Storage
    {
        List<Product> Product_storage { get; }

        public Storage(params Product[] produts)
        {
            Product_storage = new List<Product>();
            foreach (var item in produts)
                Product_storage.Add(item);
        }
        public Storage()
        {
            Product_storage = new List<Product>();
        }
        public void UserInput()
        {
            string? name, category = "", type = "", expiring;
            double price, weight;

            Console.WriteLine("Enter product data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Price: ");
            price = double.Parse(Console.ReadLine());
            Console.Write("Weight: ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("(Dairy product)Expire data: ");
            expiring = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(expiring))
            {
                Console.WriteLine("(Meat) Category = ");
                category = Console.ReadLine();
                Console.WriteLine("(Meat) Meat Type = ");
                type = Console.ReadLine();
            }

            Product p;
            if (!String.IsNullOrWhiteSpace(expiring))
                p = new DairyProducts(int.Parse(expiring), name, price, weight);
            else if (!String.IsNullOrWhiteSpace(category) && !String.IsNullOrWhiteSpace(type))
                p = new Meat(category, type, name, price, weight);
            else
                p = new Product(name, price, weight);

            Product_storage.Add(p);
        }

        public void FindMeat()
        {
            Console.WriteLine("\tOnly meat");
            foreach (var item in Product_storage)
            {
                if (item is Meat)
                    Check.Output(item);
            }
        }
        public void ChangePrice(double percent)
        {
            foreach (var item in Product_storage)
                item.ChangePrice(percent);
        }

        public Product this[int index]
        {
            get
            {
                if (index >= 0 && index < Product_storage.Count)
                {
                    return Product_storage[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set
            {
                Product_storage[index] = value;
            }
        }


        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < Product_storage.Count; i++)
            {
                result += Product_storage[i].ToString();
            }
            return result;
        }

    }
}