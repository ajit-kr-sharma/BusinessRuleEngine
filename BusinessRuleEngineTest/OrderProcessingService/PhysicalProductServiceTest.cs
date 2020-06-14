using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessingService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineTest.OrderProcessingService
{
    [TestClass]
   public class PhysicalProductServiceTest
    {
        PhysicalProductService physicalProductService;

        [TestInitialize]
        public void Init()
        {

            physicalProductService = new PhysicalProductService();
        }

        [TestMethod]
        public void ProcessOrder_Success_Test()
        {
            //arrange
            PhysicalProductModel model = new PhysicalProductModel() { Name = "Books",Description="Packed" };
            //act
            var result = physicalProductService.ProcessOrder<PhysicalProductModel>(model);
            //assert
            Assert.IsTrue(result.IsOrderProcessed);
            Assert.AreEqual("Packing slip created for physical product", result.Message) ;
        }

        [TestMethod]
        public void ProcessOrder_BookName_Empty_Test()
        {
            //arrange
            PhysicalProductModel model = new PhysicalProductModel() { Name = "", Description = "Packed" };
            //act
            var result = physicalProductService.ProcessOrder<PhysicalProductModel>(model);
            //assert
            Assert.IsFalse(result.IsOrderProcessed);
        }
    }
}
