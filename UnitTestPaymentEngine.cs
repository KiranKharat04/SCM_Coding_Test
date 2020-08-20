using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCM_Coding_Business_Rules_Engine.BusinessComponent;
using SCM_Coding_Business_Rules_Engine.FactoryPayPattern;

namespace SCM_Coding_Business_Rules_Engine.Tests
{
    [TestClass]
    public class UnitTestPaymentEngine
    {
        [TestMethod]
        public void Actiavte_Membership()
        {
            //Arrange
            int active = 3;
            IPaymentRule payrule = PayMethod.PaymentGetWay(active);
            //Act
            bool result = payrule.PaymentGetWay();
            //Assert
            Assert.AreEqual(result, true);
        }

        public void Upgrade_Membership()
        {
            //Arrange
            int upgrade = 4;
            IPaymentRule payrule = PayMethod.PaymentGetWay(upgrade);
            //Act
            bool result = payrule.PaymentGetWay();
            //Assert
            Assert.AreEqual(result, true);
        }

        public void Free_VideoSlip()
        {
            //Arrange
            int videoPkg = 5;
            IPaymentRule payrule = PayMethod.PaymentGetWay(videoPkg);
            //Act
            bool result = payrule.PaymentGetWay();
            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
