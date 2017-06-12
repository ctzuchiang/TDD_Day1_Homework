using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product;

namespace ProductTests
{
    [TestClass()]
    public class ProductServiceTests
    {
        [ExpectedException(typeof(NotImplementedException))]
        [TestMethod()]
        public void TotalGroupAmountTest()
        {
            //Arrange
            var target = new ProductService();

            //Act
            target.TotalGroupAmount("Cost", 3);

        }
    }
}
