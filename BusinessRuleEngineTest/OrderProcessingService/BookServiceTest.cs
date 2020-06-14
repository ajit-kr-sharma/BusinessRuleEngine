using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessingService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineTest.OrderProcessingService
{
    [TestClass]
   public class BookServiceTest
    {
        BookService bookService;

        [TestInitialize]
        public void Init()
        {
            bookService = new BookService();
        }

        [TestMethod]
        public void ProcessOrder_Success_Test()
        {
            //arrange
            BookModel model = new BookModel() { BookName="English", Price=220,Quantity=5};
            double royaltyAmount = model.Price * model.Quantity * model.Commission;
            string message = "Royalty slip created with Amount - " + royaltyAmount;
            //act
            var result=bookService.ProcessOrder<BookModel>(model);
            //assert
            Assert.IsTrue( result.IsOrderProcessed);
            Assert.AreEqual(message, result.Message);


        }

        [TestMethod]
        public void ProcessOrder_BookName_Empty_Test()
        {
            //arrange
            BookModel model = new BookModel() { BookName = "", Price = 220, Quantity = 5 };
            //act
            var result = bookService.ProcessOrder<BookModel>(model);
            //assert
            Assert.IsFalse( result.IsOrderProcessed);
        }


    }
}
