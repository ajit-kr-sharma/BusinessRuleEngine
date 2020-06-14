using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessingService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessRuleEngineTest.OrderProcessingService
{
    [TestClass]
   public class PhysicalProductOrBookServiceTest
    {
        PhysicalProductOrBookService physicalProductOrBookService;
        
        [TestInitialize]
        public void Init()
        {

            physicalProductOrBookService = new PhysicalProductOrBookService();
        }

        [TestMethod]
        public void ProcessOrder_Success_Test()
        {
            //arrange
            PhysicalProductOrBookModel model = new PhysicalProductOrBookModel() { AgentName="Ajit",AgentCommission=5};
            //act
            var result = physicalProductOrBookService.ProcessOrder<PhysicalProductOrBookModel>(model);
            //assert
            Assert.IsTrue( result.IsOrderProcessed);
            Assert.AreEqual("Commission payment is generated to the agent", result.Message);
            
        }

        [TestMethod]
        public void ProcessOrder_BookName_Empty_Test()
        {
            //arrange
            PhysicalProductOrBookModel model = new PhysicalProductOrBookModel() { AgentCommission = 5 };
            //act
            var result = physicalProductOrBookService.ProcessOrder<PhysicalProductOrBookModel>(model);
            //assert
            Assert.IsFalse( result.IsOrderProcessed);
        }
    }
}
