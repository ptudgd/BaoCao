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
    public partial class ThuChiTabList : UserControl
    {
        public ThuChiTabList()
        {
            InitializeComponent();
        }

        private void ThuChiTabList_Load(object sender, EventArgs e)
        {
            this.SlidePanelLeft.Show();
            this.SlidePanelRight.Hide();
            this.PanelThongKeThuChi.Controls.Clear();
            this.PanelThongKeThuChi.Controls.Add(new BangThongKeThuChiControl());
        }

        private void btnInfoStaff_Click(object sender, EventArgs e)
        {
            this.SlidePanelLeft.Show();
            this.SlidePanelRight.Hide();
            this.PanelThongKeThuChi.Controls.Clear();
            this.PanelThongKeThuChi.Controls.Add(new BangThongKeThuChiControl());
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.SlidePanelLeft.Hide();
            this.SlidePanelRight.Show();
            this.PanelThongKeThuChi.Controls.Clear();
            this.PanelThongKeThuChi.Controls.Add(new BieuDoThuChiControl());
        }
    }
}
