using SCM_Coding_Business_Rules_Engine.BusinessComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCM_Coding_Business_Rules_Engine.FactoryPayPattern
{
    /// <summary>
    /// Using Factory method as OCP Principle in main method and more methods will be added here for extension
    /// </summary>
    public class PayMethod
    {
        public static IPaymentRule PaymentGetWay(int prodType)
        {
            IPaymentRule  paymentRule;
            
            if (prodType == PayType.PhysicalProduct.GetHashCode())
            {
                paymentRule = new PhysicalProductPay();
            }
            else if (prodType == PayType.Book.GetHashCode())
            { paymentRule = new BookPay(); }
            else if (prodType == PayType.Book.GetHashCode())
            { paymentRule = new BookPay(); }
            else if (prodType == PayType.MembershipActivation.GetHashCode())
            { paymentRule = new MembershipActivationPay(); }
            else if (prodType == PayType.MembershipUpgrade.GetHashCode())
            { paymentRule = new MembershipUpgradtionPay(); }
            else if (prodType == PayType.VideoPackage.GetHashCode())
            { paymentRule = new VideoPay(); }
            else
            { paymentRule = null; }

            return paymentRule;
        }
    }


    public enum PayType
    {
        PhysicalProduct = 1,
        Book = 2,
        MembershipActivation = 3,
        MembershipUpgrade = 4,
        VideoPackage = 5
    }
}