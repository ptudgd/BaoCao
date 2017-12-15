using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Add(new HomeControl());
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.SlidePanel.Height = btnMain.Height;
            this.SlidePanel.Top = btnMain.Top;
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Add(new HomeControl());
            
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            this.SlidePanel.Height = btnHangHoa.Height;
            this.SlidePanel.Top = btnHangHoa.Top;
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Add(new HangHoaControl());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.SlidePanel.Height = btnNhanVien.Height;
            this.SlidePanel.Top = btnNhanVien.Top;
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Add(new NhanVienTabList());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.SlidePanel.Height = btnKhachHang.Height;
            this.SlidePanel.Top = btnKhachHang.Top;
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Add(new KhachHangControl());
        }

        private void btnThuChi_Click(object sender, EventArgs e)
        {
            this.SlidePanel.Height = btnThuChi.Height;
            this.SlidePanel.Top = btnThuChi.Top;
            this.PanelRight.Controls.Clear();
            this.PanelRight.Controls.Add(new ThuChiTabList());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
