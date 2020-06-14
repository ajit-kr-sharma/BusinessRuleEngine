using BusinessRuleEngine.Model;
using BusinessRuleEngine.Services.OrderProcessingService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessRuleEngineTest.OrderProcessingService
{
    [TestClass]
  public  class MembershipServiceTest
    {
        MembershipService membershipService;

        [TestInitialize]
        public void Init()
        {
            membershipService = new MembershipService();
        }

        [TestMethod]
        public void ProcessOrder_Success_Test()
        {
            //arrange
            MembershipModel model = new MembershipModel() 
            { 
                MembershipName = "Ajit",
                EndDate=DateTime.Today.AddDays(365),
                StartDate=DateTime.Today 
            };
            //act
            var result = membershipService.ProcessOrder<MembershipModel>(model);
            //assert
            Assert.IsTrue(result.IsOrderProcessed);
            Assert.AreEqual("Membership Activated",result.Message);
        }

        [TestMethod]
        public void ProcessOrder_BookName_Empty_Test()
        {
            //arrange
            MembershipModel model = new MembershipModel() 
            { 
                MembershipName = "", 
                EndDate = DateTime.Today.AddDays(365),
                StartDate = DateTime.Today };
            //act
            var result = membershipService.ProcessOrder<MembershipModel>(model);
            //assert
            Assert.IsFalse(result.IsOrderProcessed);
        }

    }
}
