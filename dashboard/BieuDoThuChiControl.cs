using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuChiChart;

namespace dashboard
{
    public partial class BieuDoThuChiControl : UserControl
    {
        public BieuDoThuChiControl()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                this.BieuDoThuChi.Series["Thu"].Points.Clear();
                this.BieuDoThuChi.Series["Chi"].Points.Clear();
                using (var cmd = new ThuChiChartListRepository())
                {
                    cmd.Ngay = this.datepicker.Value.ToShortDateString();
                    var data = cmd.Execute();
                    foreach (var item in data)
                    {
                        this.BieuDoThuChi.Series["Thu"].Points.AddY(item.Thu);
                        this.BieuDoThuChi.Series["Chi"].Points.AddY(item.Chi);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
