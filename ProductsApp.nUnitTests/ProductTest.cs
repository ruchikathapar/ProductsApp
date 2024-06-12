
using global::RuchikaProductApp;
using System;

namespace ProductsApp.nUnitTests
{
    [TestFixture]
    public class ProductTest
    {
        // ProductID tests
        [Test]
        public void Product_ProductID_ValidValues_ShouldCreateProduct()
        {
            // Arrange
            int productId = 1;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productId, product.ProductID);
        }

        [Test]
        public void Product_ProductID_OutOfRange_ShouldThrowException()
        {
            // Arrange
            // Use out of range value for ProductID
            int productId = 0;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 10;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(productId, productName, price, stock));
        }

        [Test]
        public void Product_ProductID_MaximumValue_ShouldCreateProduct()
        {
            // Arrange
            int productId = 10000;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productId, product.ProductID);
        }


        // ProductName tests
        [Test]
        public void Product_ProductName_ValidValue_ShouldCreateProduct()
        {
            // Arrange
            int productId = 1;
            string productName = "Test Product";
            decimal price = 100;
            int stock = 10;

            // Act
            Product product = new Product(productId, productName, price, stock);

            // Assert
            Assert.AreEqual(productName, product.ProductName);
        }

        [Test]
        public void Product_ProductName_NullValue_ShouldThrowException()
        {
            // Arrange
            int productId = 1;
            string productName = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Product(productId, productName, 100, 10));
        }

        [Test]
        public void Product_ProductName_EmptyValue_ShouldThrowException()
        {
            // Arrange
            int productId = 1;
            string productName = "";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new Product(productId, productName, 100, 10));
        }
    
    // Price tests
        [Test]
        public void Product_Price_ValidValues_ShouldCreateProduct()
        {
            // Arrange
            decimal price = 100;

            // Act
            Product product = new Product(1, "Test Product", price, 10);

            // Assert
            Assert.AreEqual(price, product.Price);
        }

        [Test]
        public void Product_Price_OutOfRange_ShouldThrowException()
        {
            // Arrange
            // Use out of range value for Price
            decimal price = 5001;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(1, "Test Product", price, 10));
        }

        [Test]
        public void Product_Price_MaximumValue_ShouldCreateProduct()
        {
            // Arrange
            decimal price = 5000;

            // Act
            Product product = new Product(1, "Test Product", price, 10);

            // Assert
            Assert.AreEqual(price, product.Price);
        }

        // Stock tests
        [Test]
        public void Product_Stock_ValidValues_ShouldCreateProduct()
        {
            // Arrange
            int stock = 10;

            // Act
            Product product = new Product(1, "Test Product", 100, stock);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        [Test]
        public void Product_Stock_OutOfRange_ShouldThrowException()
        {
            // Arrange
            // Use out of range value for Stock
            int stock = 100001;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Product(1, "Test Product", 100, stock));
        }

        [Test]
        public void Product_Stock_MaximumValue_ShouldCreateProduct()
        {
            // Arrange
            int stock = 100000;

            // Act
            Product product = new Product(1, "Test Product", 100, stock);

            // Assert
            Assert.AreEqual(stock, product.Stock);
        }

        // Stock increase methods tests
        [Test]
        public void IncreaseStock_ValidAmount_ShouldIncreaseStock()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100, 10);
            int increaseAmount = 5;

            // Act
            product.IncreaseStock(increaseAmount);

            // Assert
            Assert.AreEqual(15, product.Stock);
        }

        [Test]
        public void IncreaseStock_InvalidAmount_ShouldThrowException()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100, 10);
            int increaseAmount = -5;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(increaseAmount));
        }

        [Test]
        public void IncreaseStock_MaximumStock_ShouldNotThrowException()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100, 100000);
            int increaseAmount = 1;

            // Act & Assert
            Assert.DoesNotThrow(() => product.IncreaseStock(increaseAmount));
        }

        // Stock decrease methods tests
        [Test]
        public void DecreaseStock_ValidAmount_ShouldDecreaseStock()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100, 10);
            int decreaseAmount = 5;

            // Act
            product.DecreaseStock(decreaseAmount);

            // Assert
            Assert.AreEqual(5, product.Stock);
        }

        [Test]
        public void DecreaseStock_InvalidAmount_ShouldThrowException()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100, 10);
            int decreaseAmount = -5;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(decreaseAmount));
        }

        [Test]
        public void DecreaseStock_AmountGreaterThanStock_ShouldThrowException()
        {
            // Arrange
            Product product = new Product(1, "Test Product", 100, 10);
            int decreaseAmount = 15;

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => product.DecreaseStock(decreaseAmount));
        }
    }
}
