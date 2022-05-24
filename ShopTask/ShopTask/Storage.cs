using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTask
{
    public class Storage
    {
        protected List<Product> products { get; set; } = new List<Product>();
        //У таких випадках треба надіятись на конструктор за замовчуванням
        public Storage()
        {

        }
        public Storage(params Product[] products)
        {
            foreach (var item in products)
            {
                this.products.Add(item);
            }
        }
        public Product this[int i]
        {//Неконтрольований індекс
            get
            {
                return products[i];
            }
        }

        public void fillingByDialog()
        {
                Product tmpProduct = new Product();
                Console.WriteLine("Введіть назву продуку");
                tmpProduct.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введіть ціну продуку");
                tmpProduct.Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ведіть вагу продукту");
                tmpProduct.Weight = Convert.ToInt32(Console.ReadLine());
                products.Add(tmpProduct);        
        }

        public void changePriceOfAllProducts(int percentage)
        {
            foreach (var item in products)
            {
                item.percentСhange(percentage);
            }
        }
        public void FindMeat()
        {
            foreach (var item in products)
            {
                if (item is Meat)
                {
                    Console.WriteLine($"Meat was found {item.Name}");
                }
            }
        }
        public void PrintInfo()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"name={products[i].Name}, price={products[i].Price}, weigth={products[i].Weight}");
            }
           

        }
    }
}
