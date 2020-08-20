using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace SCM_Coding_Business_Rules_Engine.BusinessComponent
{
    public class VideoPay:IPaymentRule
    {
        public bool PaymentGetWay()
        {
            return VideoPackagingSlipGeneration();
        }

        public bool VideoPackagingSlipGeneration()
        {
            MessageBox.Show("Video packaging slip of shipping is generated");
            return this.FreeVideotoPackagingSlip();
        }

        private bool FreeVideotoPackagingSlip()
        {
            MessageBox.Show("Packaging slip First Aid video is creatd");
            return true;
        }
    }
}