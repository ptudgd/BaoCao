using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace mainForm
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new HangHoaForm.frmHangHoa();
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new NhanVienForm.FrmNhanVien();
            
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new NhaCungCapForm.Form1();
            f.Show();
        }

        private void thuChuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ThuChiForm.frmThuChi();
            f.Show();
        }
    }
}
