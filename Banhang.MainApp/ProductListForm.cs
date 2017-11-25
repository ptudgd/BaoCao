using Banhang.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banhang.MainApp
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = new List<Product>();
            data.Add(new Product
            {
                Maso = "sp01",
                Ten = "Cocacola",
                Giaban = 15000,
                Nhom = "Nước uống"
            });

            data.Add(new Product
            {
                Maso = "sp02",
                Ten = "Mì gói",
                Giaban = 8000,
                Nhom = "Thức ăn"
            });
            this.productBindingSource.DataSource = data;
        }
    }
}
