using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace SCM_Coding_Business_Rules_Engine.BusinessComponent
{
    public class MembershipActivationPay : IPaymentRule
    {
        public bool PaymentGetWay()
        {
            return MembershipActivation();
        }

        public bool MembershipActivation()
        {
            MessageBox.Show("Membership activated successfully");
            return this.OwnerEmailNotification();
        }

        private bool OwnerEmailNotification()
        {
            MessageBox.Show("Membership Activation email sent to the Owner");
            return true;
        }

    }
}