using Banhang.Domain.HanghoaHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banhang.Forms
{
    public partial class HoadonForm : Form
    {
        public string HoadonId { get; set; }
        public HoadonForm(string hoadonId = null)
        {
            InitializeComponent();
            this.HoadonId = hoadonId;
        }

        private void BanhangForm_Load(object sender, EventArgs e)
        {
            using (var cmd = new Banhang.Repository.HanghoaHandler.HanghoaListRepository())
            {
                hanghoaBindingSource.DataSource = cmd.Execute();
            }

            //trường hợp tạo mới
            if (string.IsNullOrWhiteSpace(this.HoadonId))
            {
                hoadonBindingSource.DataSource = new Hoadon
                {
                    HoadonId = this.HoadonId = string.Format("HD{0}", DateTime.Now.ToString("yyyyMMddHHmmssfff")),
                    NgayHoadon = DateTime.Now.Date
                };
                this.Text = string.Format("{0} - Tạo mới", this.HoadonId);
                this.cTHoadonBindingSource.DataSource = new List<CTHoadon>();
            }
            else
            {
                this.Text = string.Format("{0} - Chỉnh sửa",this.HoadonId);
                using (var cmd = new Banhang.Repository.HanghoaHandler.HoadonViewRepository())
                {
                    cmd.HoadonId = this.HoadonId;
                    this.hoadonBindingSource.DataSource = cmd.Execute();
                }
                using (var cmd = new Banhang.Repository.HanghoaHandler.CTHoadonListRepository())
                {
                    cmd.HoadonId = this.HoadonId;
                    this.cTHoadonBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void hanghoaDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var curHanghoa = hanghoaBindingSource.Current as Hanghoa;
            var curHoadon = hoadonBindingSource.Current as Hoadon;
            if (curHanghoa != null)
            {
                var listCT = cTHoadonBindingSource.DataSource as List<CTHoadon>;
                var findItem = listCT.Where(x => x.HanghoaId == curHanghoa.HanghoaId).FirstOrDefault();
                if (findItem != null)
                {
                    findItem.Soluong++;
                }
                else
                {

                    listCT.Add(new CTHoadon
                    {
                        HoadonId = curHoadon.HoadonId,
                        CTHoadonId = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                        HanghoaId = curHanghoa.HanghoaId,
                        TenHanghoa = curHanghoa.TenHanghoa,
                        Soluong = 1,
                        Dongia = curHanghoa.GiaBan
                    });
                }

                cTHoadonBindingSource.DataSource = typeof(CTHoadon);
                cTHoadonBindingSource.DataSource = listCT;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (var cmd = new Banhang.Business.HoadonSaveBusiness())
            {
                var hoadonCurrent = this.hoadonBindingSource.Current as Hoadon;
                cmd.item = hoadonCurrent;
                cmd.Execute();
            }
            using (var cmd = new Banhang.Business.CTHoadonSaveBusiness())
            {
                var listCTHoadon = this.cTHoadonBindingSource.DataSource as List<CTHoadon>;
                foreach (var item in listCTHoadon)
                {
                    cmd.item = item;
                    cmd.Execute();
                }
            }
            MessageBox.Show("Lưu xong");
        }
    }
}
