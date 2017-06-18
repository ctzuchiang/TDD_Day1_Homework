using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;
using System.Collections.Generic;
using System.Linq;

namespace ProductTests
{
    [TestClass]
    public class ProductServiceTests
    {
        private IEnumerable<ProductModel> _Product;

        [TestInitialize]
        public void SetUp()
        {
            _Product = new List<ProductModel>
            {
                new ProductModel {Id = 1, Cost = 1, Revenue = 11, SellPrice = 21},
                new ProductModel {Id = 2, Cost = 2, Revenue = 12, SellPrice = 22},
                new ProductModel {Id = 3, Cost = 3, Revenue = 13, SellPrice = 23},
                new ProductModel {Id = 4, Cost = 4, Revenue = 14, SellPrice = 24},
                new ProductModel {Id = 5, Cost = 5, Revenue = 15, SellPrice = 25},
                new ProductModel {Id = 6, Cost = 6, Revenue = 16, SellPrice = 26},
                new ProductModel {Id = 7, Cost = 7, Revenue = 17, SellPrice = 27},
                new ProductModel {Id = 8, Cost = 8, Revenue = 18, SellPrice = 28},
                new ProductModel {Id = 9, Cost = 9, Revenue = 19, SellPrice = 29},
                new ProductModel {Id = 10, Cost = 10, Revenue = 20, SellPrice = 30},
                new ProductModel {Id = 11, Cost = 11, Revenue = 21, SellPrice = 31}
            };
        }

        [TestMethod]
        public void SumGroupAmount_by_Cost_with_groupRange_3()
        {
            var expected = new[] { 6, 15, 24, 21 };

            var actual = _Product.SumGroupSize(3, x => x.Cost).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumGroupAmount_by_Cost_with_groupRange_4()
        {
            var expected = new[] { 10, 26, 30 };

            var actual = _Product.SumGroupSize(4, x => x.Cost).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumGroupAmount_by_Revenue_with_groupRange_3()
        {
            var expected = new[] { 36, 45, 54, 41 };

            var actual = _Product.SumGroupSize(3, x => x.Revenue).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumGroupAmount_by_Revenue_with_groupRange_4()
        {
            var expected = new[] { 50, 66, 60 };

            var actual = _Product.SumGroupSize(4, x => x.Revenue).ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }

        //}
        //    _Target.SumGroupAmount("Revenue", 0);
        //{
        //public void SumGroupAmount_with_0_groupRange_should_throw_ArgumentException()
        //[TestMethod]

        //[ExpectedException(typeof(ArgumentException))]

        //[ExpectedException(typeof(ArgumentException))]
        //[TestMethod]
        //public void SumGroupAmount_with_negative_groupRange_should_throw_ArgumentException()
        //{
        //    _Target.SumGroupAmount("Revenue", -1);
        //}

        //[ExpectedException(typeof(ArgumentException))]
        //[TestMethod]
        //public void SumGroupAmount_with_notExisted_column_should_throw_ArgumentException()
        //{
        //    _Target.SumGroupAmount("NoThisColumn", 3);
        //}
    }
}