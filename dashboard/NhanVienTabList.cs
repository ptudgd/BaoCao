using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class NhanVienTabList : UserControl
    {
        public NhanVienTabList()
        {
            InitializeComponent();
            this.SlidePanelLeft.Show();
            this.SlidePanelRight.Hide();
            this.PanelPhieuBanHang.Hide();
            this.PanelStaff.Controls.Add(new NhanVienControl());
        }

        private void btnInfoStaff_Click(object sender, EventArgs e)
        {
            
            this.SlidePanelLeft.Show();
            this.SlidePanelRight.Hide();
            this.PanelPhieuBanHang.Hide();
            this.PanelStaff.Controls.Clear();
            this.PanelStaff.Controls.Add(new NhanVienControl());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            this.SlidePanelLeft.Hide();
            this.SlidePanelRight.Show();
            this.PanelPhieuBanHang.Hide();
            this.PanelStaff.Controls.Clear();
            this.PanelStaff.Controls.Add(new DanhSachBanHang());
        }

        private void SlidePanelStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SlidePanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SlidePanelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhieuBanHang_Click(object sender, EventArgs e)
        {
            
            this.SlidePanelLeft.Hide();
            this.SlidePanelRight.Hide();
            this.PanelPhieuBanHang.Show();
            this.PanelStaff.Controls.Clear();
            this.PanelStaff.Controls.Add(new PhieuBanHang());
        }
    }
}
