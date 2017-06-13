using System;
using System.Collections.Generic;
using Product.Models;

namespace Product
{
    public class ProductService
    {
        private readonly ProductRepository _ProductRepository;

        public ProductService()
        {
            _ProductRepository = new ProductRepository();
        }

        public ProductService(ProductRepository productRepository)
        {
            _ProductRepository = productRepository;
        }

        internal List<ProductItem> SumGroupAmount(string groupColumnName, int groupRange)
        {
            return _ProductRepository.SumProductStoreProcedure(groupColumnName, groupRange);
        }
    }

    public class ProductRepository
    {
        virtual internal List<ProductItem> SumProductStoreProcedure(string column, int range)
        {
            throw new NotImplementedException();
        }
    }
}