using System.Collections.Generic;
using System.Linq;
using shoppapp.webui.Models;

namespace shoppapp.webui.Data
{
    public static class ProductRepository
    {
        private static List<ProductEntity> _productList = null;
        static ProductRepository()
        {
            _productList = new List<ProductEntity>
            {
                new ProductEntity {ProductId=1,Name="Asus",Price=4000,Description="Search of Incredible",IsApproved=false,ImageUrl="asus.jpg",CategoryId=1},
                new ProductEntity {ProductId=2,Name="Lenovo",Price=3500,Description="Lenovo işte",ImageUrl="lenovo.png",CategoryId=1},
                new ProductEntity {ProductId=3,Name="MacBook Pro",Price=6000,Description="MacOs",IsApproved=true,ImageUrl="macbook.png",CategoryId=1},
                new ProductEntity {ProductId=4,Name="Monster",Price=6000,Description="Gerçek Oyun Severlere",IsApproved=true,ImageUrl="monster.jpg",CategoryId=1},

                new ProductEntity {ProductId=5,Name="Iphone",Price=4000,Description="11 Pro",IsApproved=false,ImageUrl="11ProMax.jpg",CategoryId=3},
                new ProductEntity {ProductId=6,Name="Xiaomi",Price=3500,Description="Note 8 Pro",ImageUrl="note8pro.jpg",CategoryId=3},
                new ProductEntity {ProductId=7,Name="Samsung",Price=6000,Description="Note 10",IsApproved=true,ImageUrl="note10.jpg",CategoryId=3},
                new ProductEntity {ProductId=8,Name="Sony",Price=6000,Description="Xperia",IsApproved=true,ImageUrl="xperia.jpg",CategoryId=3}
            };
        }
        public static List<ProductEntity> Products
        {
            get
            {
                return _productList;
            }
        }


        public static void AddProduct(ProductEntity product)
        {
            _productList.Add(product);
        }

        public static ProductEntity GetProductById(int id)
        {
            return _productList.FirstOrDefault(p => p.ProductId == id);
        }
        public static void EditProduct(ProductEntity product)
        {
            foreach (var item in _productList)
            {
                if (item.ProductId == product.ProductId)
                {
                    item.Name = product.Name;
                    item.Price = product.Price;
                    item.Description = product.Description;
                    item.ImageUrl = product.ImageUrl;
                    item.IsApproved = product.IsApproved;
                }
            }
        }
        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _productList.Remove(product);
            }
        }

    }
}