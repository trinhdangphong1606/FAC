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
    public partial class FrmTuDienPhanPhoiDistributionBoardDB : Form
    {
        public FrmTuDienPhanPhoiDistributionBoardDB()
        {
            InitializeComponent();
        }



        //--------------- Lỗi hệ thống tủ điện phân phối ---------------------


        private void BtnBusbarATS1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch ATS 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch ATS 1 bị hư ";
        }

        private void Btn1ACBATS1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 1 ACB của ATS 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 1 ACB của ATS 1 bị hư ";

        }

        private void Btn2ACBATS1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 2 ACB của ATS 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 2 ACB của ATS 1 bị hư ";

        }

        private void BtnBusbarATS2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch ATS 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch ATS 2 bị hư ";

        }

        private void Btn1ACBATS2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 1 ACB của ATS 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 1 ACB của ATS 2 bị hư ";

        }

        private void Btn2ACBATS2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : 2 ACB của ATS 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : 2 ACB của ATS 2 bị hư ";

        }

        private void BtnBusbarMSB1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của MSB 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của MSB 1 bị hư ";

        }

        private void BtnChillerMSB1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : MCCB DB-Chiller của MSB 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : MCCB DB-Chiller của MSB 1 bị hư ";

        }

        private void BtnCrahMSB1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : MCCB DB-CRAH của MSB 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : MCCB DB-CRAH của MSB 1 bị hư ";

        }

        private void BtnMCCBUPSMSB1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB - UPS của MSB 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB - UPS của MSB 1 bị hư ";

        }

        private void BtnACBChillerMSB1_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : ACB-Chiller MSB 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : ACB-Chiller MSB 1 bị hư ";

        }

        private void BtnMCCBAHUMSB_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB DB-AHU của MSB 1 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB DB-AHU của MSB 1 bị hư ";

        }

        private void BtnBusbarMSB2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của MSB 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của MSB 2 bị hư ";

        }

        private void BtnACBCrahMSB2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : ACB-DB CRAC Dxx của MSB 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : ACB-DB CRAC Dxx của MSB 2 bị hư ";

        }

        private void BtnUPSMSB2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB UPS 04 or UPS 05 của MSB 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB UPS 04 or UPS 05 của MSB 2 bị hư ";

        }

        private void BtnCrachMSB2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB CRAC R6,7,8,9 của MSB 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB CRAC R6,7,8,9 của MSB 2 bị hư ";

        }

        private void BtnMayLanhMSB2_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB máy lạnh Daikin 01, 02 của MSB 2 bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB máy lạnh Daikin 01, 02 của MSB 2 bị hư ";

        }

        private void BtnBusbarChiller_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của DB Chiller bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của DB Chiller bị hư ";

        }

        private void BtnMCCAAllChiller_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : MCCB tổng của DB-Chiller bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : MCCB tổng của DB-Chiller bị hư ";

        }

        private void BtnDayDanChiller_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Dây dẫn ngắn mạch của DB-Chiller bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Dây dẫn ngắn mạch của DB-Chiller bị hư ";

        }

        private void BtnMCCBChiller_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB thiết bị của DB-Chiller bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB thiết bị của DB-Chiller bị hư ";

        }

        private void BtnBusbarCrah_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của DB-CRAH bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Busbar ngắn mạch của DB-CRAH bị hư ";

        }

        private void BtnMCCAAllCrah_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : MCCB tổng của DB-CRAH bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : MCCB tổng của DB-CRAH bị hư ";

        }

        private void BtnDayDanCrah_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Dây dẫn ngắn mạch của DB-CRAH bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Dây dẫn ngắn mạch của DB-CRAH bị hư ";

        }

        private void BtnMCCBCrah_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : MCCB thiết bị của DB-CRAH bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : MCCB thiết bị của DB-CRAH bị hư ";

        }

        private void BtnAHU_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 3 : DB AHU của tủ điện phân phối bị hư ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 3 : DB AHU của tủ điện phân phối bị hư ";

        }

        private void BtnChayTrongPhong_Click(object sender, EventArgs e)
        {
            LbNoiDungMail.Text = "Hiện tại đang có Incident Level 1 : Tủ điện trong phòng đang bị cháy ";
            LBCacheNoiDung.Text = "Hiện tại đang có Incident Level 1 : Tủ điện trong phòng đang bị cháy ";

        }
        //--------------- End Lỗi hệ thống Tủ điện ----------------
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
    
