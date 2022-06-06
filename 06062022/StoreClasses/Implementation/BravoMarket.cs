using StoreClasses.Exceptions;
using StoreClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses.Implementation
{
    public class BravoMarket : IStore
    {
        public BravoMarket(int limit)
        {
            _products = new Product[0];
            ProductLimit = limit;
        }
        private Product[] _products;
        public Product[] Products => _products;
        private double _totalIncome;

        public int ProductLimit { get; set; }
        public double TotalIncome => _totalIncome;

        public void AddProduct(Product product)
        {
            if (ProductLimit <= _products.Length)
                throw new ProductLimitIsFilledException($"Products limit is filled");

            if (IsExistProductByNo(product.No))
                throw new ProductIsExistException($"Same product already added with {product.No} no");

            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public void SellProduct(string no)
        {
            Product product = FindProductByNo(no);

            if (product == null)
                throw new ProductNotFoundException($"There is not any product with no: {no}");

            if (product.Count < 1)
                throw new ProductStockCountException("The product is stock out");

            _totalIncome += product.Price;
            product.Count--;
        }


        public Product FindProductByNo(string no)
        {
            Product product = null;

            foreach (var pr in _products)
            {
                if (pr.No == no)
                {
                    product = pr;
                    break;
                }
            }

            return product;
        }

        public bool IsExistProductByNo(string no)
        {
            foreach (var pr in _products)
            {
                if (pr.No == no)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
