using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace SCM_Coding_Business_Rules_Engine.BusinessComponent
{
    public class MembershipUpgradtionPay : IPaymentRule
    {
        public bool PaymentGetWay()
        {
            return MembershipUpgradetion();
        }

        public bool MembershipUpgradetion()
        {
            MessageBox.Show("Membership upgraded successfully");
            return this.OwnerEmailNotification();
        }

        private bool OwnerEmailNotification()
        {
            MessageBox.Show("Membership upgradetion email sent to the Owner");
            return true;
        }
    }
}