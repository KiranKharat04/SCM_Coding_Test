using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace SCM_Coding_Business_Rules_Engine.BusinessComponent
{
    public class PhysicalProductPay: IPaymentRule
    {
        public bool PaymentGetWay()
        {
            return DuplicatePackagingSlipGeneration();
        }

        public bool DuplicatePackagingSlipGeneration()
        {
            MessageBox.Show("Shipping Packaging slip is created successfully");
            return AgentCommision();
        }

        private bool AgentCommision()
        {
            MessageBox.Show("Agent Commssion Payment done successfully");
            return true;
        }
    }
}