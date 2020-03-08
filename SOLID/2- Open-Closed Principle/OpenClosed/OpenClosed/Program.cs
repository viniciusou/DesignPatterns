using OpenClosed.Specifications;
using System;

namespace OpenClosed
{
    class Program
    {
        /// <summary>
        /// "Software entities (classes, modules, functions, etc.)
        /// should be open for extension, but closed for modification"
        /// 
        /// Extend ProductFilter without changing it by using inheritance.
        /// </summary>
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var productFilter = new ProductFilter();
            Console.WriteLine("Green products:");
            foreach (var product in productFilter.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {product.Name} is green");
            }

            Console.WriteLine("Large blue items:");
            foreach (var product in productFilter.Filter(products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {product.Name} is blue and large");
            }
        }
    }
}
