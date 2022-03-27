using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;


namespace CSTiengViet
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }
        public string[] Color { get; set; }
        public int Brand { get; set; }
        public Product(int _id, string _name, double _price, string[] _color, int _brand)
        {
            Id = _id;
            Name = _name;
            Price = _price;
            Color = _color;
            Brand = _brand;
        }

        public override string ToString()
        {
            return $"{Id,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Color)}";
        }
    }

    public class Brand
    {
        public string BrandName { get; set; }
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var newBrand = new List<Brand>()
            {
                new Brand{Id = 1, BrandName = "AAA"},
                new Brand{Id = 2, BrandName = "BBB"},
                new Brand{Id = 4, BrandName = "CCC"},
            };

            var products = new List<Product>()
            {
             new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
             new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
             new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
             new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
             new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
             new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
             new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            // Example about join in C#
            var query = from product in products
                        join brand in newBrand on product.Brand equals brand.Id
                        select new
                        {
                            joinName = product.Name,
                            joinPrice = product.Price,
                            joinId = product.Id,
                            joinBrand = brand.BrandName
                        };
            query.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
