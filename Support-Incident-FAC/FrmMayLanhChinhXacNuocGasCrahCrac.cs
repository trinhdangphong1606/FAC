using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Support_Incident_FAC
{
    public partial class FrmMayLanhChinhXacNuocGasCrahCrac : Form
    {
        public FrmMayLanhChinhXacNuocGasCrahCrac()
        {
            InitializeComponent();
        }
        //--------------- Lỗi hệ thống máy lạnh ---------------------
        private void Btn1CrahL_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 4 : 1 Crah dãy L bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 4 : 1 Crah dãy L bị hư ";
        }

        private void Btn2CrahL_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 2 Crah dãy L bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 2 Crah dãy L bị hư ";
        }
        private void Btn3CrahL_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 2 : 3 Crab dãy L bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 2 : 3 Crab dãy L bị hư ";

        }

        private void Btn4CrahL_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : 4÷7 Crab dãy L bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : 4÷7 Crab dãy L bị hư ";

        }

        private void Btn1CrahR_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 4 : 1 Crah dãy R bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 4 : 1 Crah dãy R bị hư ";

        }

        private void Btn2CrahR_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 2 Crah dãy R bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 2 Crah dãy R bị hư ";

        }

        private void Btnlv13CrahR_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 2 : 3÷5 Crah dãy R : hư 2x30kW và 1x150kW ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 2 : 3÷5 Crah dãy R : hư 2x30kW và 1x150kW ";

        }

        private void Btnlv23CrahR_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : 3÷5 Crah dãy R : hư 2x150kW trở lên ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : 3÷5 Crah dãy R : hư 2x150kW trở lên ";

        }

        private void Btn1CracD_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 1 Crac Dx bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 1 Crac Dx bị hư ";

        }

        private void Btn2CracD_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 2 : 2 Crac Dx bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 2 : 2 Crac Dx bị hư ";

        }

        private void Btn3CracD_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : 3÷4 Crac Dx bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : 3÷4 Crac Dx bị hư ";

        }

        //--------------- End Lỗi hệ thống máy lạnh ----------------
        // ----------------------Title --------------------------------

        // Location
        private void BtnVNDTDC_Click(object sender, EventArgs e)
        {
            LbLocation.Text = "[VNDT-DC]";
        }
        private void BtnQTSCDC_Click(object sender, EventArgs e)
        {
            LbLocation.Text = "[QTSC-DC]";
        }
        private void BtnDRSite_Click(object sender, EventArgs e)
        {
            LbLocation.Text = "[DR-Site]";
        }
        // Section
        private void BtnOldFarm_Click(object sender, EventArgs e)
        {
            LbSection.Text = "[Old-Farm]";
        }
        private void BtnNewFarm_Click(object sender, EventArgs e)
        {
            LbSection.Text = "[New-Farm]";
        }
        private void BtnAllFarm_Click(object sender, EventArgs e)
        {
            LbSection.Text = "[All-Farm]";
        }
        // Level
        private void BtnL1_Click(object sender, EventArgs e)
        {
            LbLvel.Text = "Level 1";
        }
        private void BtnL2_Click(object sender, EventArgs e)
        {
            LbLvel.Text = "Level 2";
        }
        private void BtnL3_Click(object sender, EventArgs e)
        {
            LbLvel.Text = "Level 3";
        }
        // Recover or not
        private void BtnRecovered_Click(object sender, EventArgs e)
        {
            if (LbRecovered.Text == " is Recovered")
            {
                LbRecovered.Text = " is Recovered";
            }
            else
            {
                LbRecovered.Text = " is Recovered";
                LbNoiDungMail.Text = LbNoiDungMail.Text + " đã được xử lý";
            }

        }
        private void BtnNotRecorved_Click(object sender, EventArgs e)
        {
            LbRecovered.Text = "";
            LbNoiDungMail.Text = LBCacheNoiDung.Text;
        }
        // System
        private void BtnBuilding_Click(object sender, EventArgs e)
        {
            LbSystem.Text = "[Building]";
        }
        private void BtnPower_Click(object sender, EventArgs e)
        {
            LbSystem.Text = "[Power]";
        }
        private void BtnCooling_Click(object sender, EventArgs e)
        {
            LbSystem.Text = "[Cooling]";
        }
        private void BtnFire_Click(object sender, EventArgs e)
        {
            LbSystem.Text = "[Fire]";
        }
        private void BtnFlood_Click(object sender, EventArgs e)
        {
            LbSystem.Text = "[Flood]";
        }
        // Who
        private void BtnSE_Click(object sender, EventArgs e)
        {
            LbWho.Text = "[SE]";
        }
        private void BtnSale_Click(object sender, EventArgs e)
        {
            LbWho.Text = "[Sale]";
        }
        private void BtnSMT_Click(object sender, EventArgs e)
        {
            LbWho.Text = "[SMT]";
        }
        // Action
        private void BtnReadyOnline_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[Ready online Pls!]";
        }

        private void BtnShutDownKeySV_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[Shut down key servers Pls!]";
        }

        private void BtnShutdownAllSV_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[Shut down All servers Pls!]";
        }

        private void BtnPowerOnKeySV_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[Power on key servers Pls!]";
        }

        private void BtnPowerOnAllSV_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[Power on All servers Pls!]";
        }

        private void BtnKeySVWillBeShutDown_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[Key servers will be shut down soon !]";
        }

        private void BtnAllSVWillBeShutDown_Click(object sender, EventArgs e)
        {
            LbAction.Text = "[All servers will be shut down soon !]";
        }
        // ---------------- End Title --------------------------------
        //---------------Button update and clear title-------------------------------

        private void BtnUpdateTitle_Click(object sender, EventArgs e)
        {
            TxtTitleMail.Text = LbLocation.Text + " " + LbSection.Text + " Incident " + LbLvel.Text + " on " + LbSystem.Text + " " + LbWho.Text + " " + LbAction.Text + " " + LbRecovered.Text;
            TxtNoiDungMail.Text = LbNoiDungMail.Text + "  " + LbWho.Text + "  " + LbAction.Text;
        }

        private void BtnClearNoidung_Click(object sender, EventArgs e)
        {
            TxtTitleMail.Text = "";
            TxtNoiDungMail.Text = "";
            LbNoiDungMail.Text = "Nội dung";
            LbLocation.Text = "Site Location";
            LbSection.Text = "Site Section";
            LbLvel.Text = "Inc.Level";
            LbRecovered.Text = "";
            LbSystem.Text = "System";
            LbAction.Text = "Action/Infomation";
        }
        //--------------- End Button get title-------------------------------

    }
}
