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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLevel1Flow frm1 = new FrmLevel1Flow();
            frm1.MdiParent = this;
            frm1.Show();

            FrmLevel1Action frm2 = new FrmLevel1Action();
            frm2.MdiParent = this;
            frm2.Show();
        }
        private void LevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLevel2Flow frm1 = new FrmLevel2Flow();
            frm1.MdiParent = this;
            frm1.Show();

            FrmLevel2Action frm2 = new FrmLevel2Action();
            frm2.MdiParent = this;
            frm2.Show();
        }
        private void Level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLevel3Flow frm1 = new FrmLevel3Flow();
            frm1.MdiParent = this;
            frm1.Show();

            FrmLevel3Action frm2 = new FrmLevel3Action();
            frm2.MdiParent = this;
            frm2.Show();
        }
        private void KeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiaiThichTuNgu frm1 = new FrmGiaiThichTuNgu();
            frm1.MdiParent = this;
            frm1.Show();
        }
        private void giảiThíchTừNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiaiThichTuNgu frm1 = new FrmGiaiThichTuNgu();
            frm1.MdiParent = this;
            frm1.Show();
        }
        private void ĐịnhNghĩaLevelKhẩuLệnhThôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDefineLevelAndSMSPhone frm1 = new FrmDefineLevelAndSMSPhone();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void MáyPhátĐiệnGensetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMayPhatDienGenSet frm1 = new FrmMayPhatDienGenSet();
            frm1.MdiParent = this;
            frm1.Show();
            FrmMayPhatDienGenSetChuThich frm2 = new FrmMayPhatDienGenSetChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void MáyLạnhTrungTâmChillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMayLanhTrungTamChiller frm1 = new FrmMayLanhTrungTamChiller();
            frm1.MdiParent = this;
            frm1.Show();
            FrmMayLanhTrungTamChillerChuThich frm2 = new FrmMayLanhTrungTamChillerChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void tủĐiệnPhânPhốiDistributionBoardDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTuDienPhanPhoiDistributionBoardDB frm1 = new FrmTuDienPhanPhoiDistributionBoardDB();
            frm1.MdiParent = this;
            frm1.Show();
            FrmTuDienPhanPhoiDistributionBoardDBChuThich frm2 = new FrmTuDienPhanPhoiDistributionBoardDBChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void hệThốngLưuĐiệnOldFarmMGEUPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLuuDienOldFarmMGEUPS frm1 = new FrmLuuDienOldFarmMGEUPS();
            frm1.MdiParent = this;
            frm1.Show();
            FrmLuuDienOldFarmMGEUPSChuThich frm2 = new FrmLuuDienOldFarmMGEUPSChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void hệThốngLưuĐiệnNewFarmVertiUPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLuuDienNewFarmVertiUPS frm1 = new FrmLuuDienNewFarmVertiUPS();
            frm1.MdiParent = this;
            frm1.Show();
            FrmLuuDienNewFarmVertiUPSChuThich frm2 = new FrmLuuDienNewFarmVertiUPSChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }
        private void trạmBiếnÁpTransformerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTramBienApTransformer frm1 = new FrmTramBienApTransformer();
            frm1.MdiParent = this;
            frm1.Show();
            FrmTramBienApTransformerChuThich frm2 = new FrmTramBienApTransformerChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }
            private void máyLạnhChínhXácHệNướcGasCRAHCRACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMayLanhChinhXacNuocGasCrahCrac frm1 = new FrmMayLanhChinhXacNuocGasCrahCrac();
            frm1.MdiParent = this;
            frm1.Show();
            FrmMayLanhChinhXacNuocGasCrahCracChuThich frm2 = new FrmMayLanhChinhXacNuocGasCrahCracChuThich();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void thôngTinLiênLạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinLienLac frm2 = new FrmThongTinLienLac();
            frm2.MdiParent = this;
            frm2.Show();
        }

        
    }
}
