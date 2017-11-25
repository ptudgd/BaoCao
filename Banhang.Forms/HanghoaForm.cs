using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Banhang.Repository.HanghoaHandler;
using Banhang.Domain.HanghoaHandler;
using Banhang.Business;

namespace Banhang.Forms
{
    public partial class HanghoaForm : Form
    {
        List<NhomHanghoa> _ListNhomHanghoa
        {
            get
            {
                return this.nhomHanghoaBindingSource.DataSource as List<NhomHanghoa>;
            }
            set
            {
                this.nhomHanghoaBindingSource.DataSource = value;
                this.bindingSource1.DataSource = value;
            }
        }

        public HanghoaForm()
        {
            InitializeComponent();
        }

        private void LoaDataButton_Click(object sender, EventArgs e)
        {
            using (var cmd = new NhomHanghoaListRepository())
            {
                this._ListNhomHanghoa = cmd.Execute();
            }
            //this.NhomHanghoaComboBox.Items.AddRange(this._ListNhomHanghoa.ToArray());
        }

        private void nhomHanghoaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            var cur = this.nhomHanghoaBindingSource.Current as NhomHanghoa;
            if(cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId))
            {
                using (var cmd = new HanghoaListRepository())
                {
                    cmd.NhomHanghoaId = cur.NhomHanghoaId;
                    this.hanghoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void HanghoaForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /// Save one row.
            //var cur = this.nhomHanghoaBindingSource.Current as NhomHanghoa;
            //if (cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId))
            //{
            //    using (var cmd = new NhomHanghoaSaveBusiness())
            //    {
            //        cmd.item = cur;
            //        cmd.Execute();
            //    }

            //    using(var cmd = new NhomHanghoaListRepository())
            //    {
            //        this.nhomHanghoaBindingSource.DataSource = cmd.Execute();
            //    }
            //}

            /// Save multiple rows.

            var listCur = this.nhomHanghoaBindingSource.DataSource as List<NhomHanghoa>;
            if (listCur != null)
            {
                using (var cmd = new NhomHanghoaSaveBusiness())
                {
                    foreach (var item in listCur)
                    {
                        cmd.item = item;
                        cmd.Execute();
                    }
                }
                
                using(var cmd = new NhomHanghoaListRepository())
                {
                    this.nhomHanghoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var cur = this.nhomHanghoaBindingSource.Current as NhomHanghoa;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId))
            {
                using (var cmd = new NhomHanghoaDeleteRepository())
                {
                    cmd.NhomHanghoaId = cur.NhomHanghoaId;
                    cmd.Execute();
                }

                using (var cmd = new NhomHanghoaListRepository())
                {
                    this.nhomHanghoaBindingSource.DataSource = cmd.Execute();
                }
            }
        }

        private void HanghoaSaveButton_Click(object sender, EventArgs e)
        {
            var cur = this.nhomHanghoaBindingSource.Current as NhomHanghoa;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.NhomHanghoaId))
            {
                var listCur = this.hanghoaBindingSource.DataSource as List<Hanghoa>;
                if (listCur != null)
                {
                    using (var cmd = new HanghoaSaveBusiness())
                    {
                        foreach (var item in listCur)
                        {
                            //item.NhomHanghoaId = cur.NhomHanghoaId;
                            cmd.item = item;
                            cmd.Execute();
                        }
                    }

                    using (var cmd = new HanghoaListRepository())
                    {
                        cmd.NhomHanghoaId = cur.NhomHanghoaId;
                        this.hanghoaBindingSource.DataSource = cmd.Execute();
                    }
                }
            }
        }

        private void HanghoaDeleteButton_Click(object sender, EventArgs e)
        {
            var cur = this.hanghoaBindingSource.Current as Hanghoa;
            if (cur != null && !string.IsNullOrWhiteSpace(cur.HanghoaId))
            {
                using (var cmd = new HanghoaDeleteRepository())
                {
                    cmd.HanghoaId = cur.HanghoaId;
                    cmd.Execute();
                }
                using (var cmd = new HanghoaListRepository())
                {
                    var curNhom = this.nhomHanghoaBindingSource.Current as NhomHanghoa;
                    if (curNhom != null && !string.IsNullOrWhiteSpace(curNhom.NhomHanghoaId))
                    {
                        cmd.NhomHanghoaId = curNhom.NhomHanghoaId;
                        this.hanghoaBindingSource.DataSource = cmd.Execute();
                    }
                }
            }
        }
    }
}
