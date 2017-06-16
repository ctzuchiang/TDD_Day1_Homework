using System;
using System.Collections.Generic;
using Product.Models;

namespace Product
{
    public class ProductService
    {
        private readonly IProduct _ProductRepository;

        public ProductService()
        {
            _ProductRepository = new ProductRepository();
        }

        public ProductService(IProduct productRepository)
        {
            _ProductRepository = productRepository;
        }

        internal List<Models.Product> SumGroupAmount(string groupColumnName, int groupSize)
        {
            return _ProductRepository.SumProductGroup(groupColumnName, groupSize);
        }
    }

    public interface IProduct
    {
        List<Models.Product> SumProductGroup(string column, int size);
    }

    public class ProductRepository : IProduct
    {
        public List<Models.Product> SumProductGroup(string column, int size)
        {
            throw new NotImplementedException();
        }
    }
}