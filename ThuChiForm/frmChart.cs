using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuChi.Repository;
using ThuChiChart;
using System.Windows.Forms.DataVisualization.Charting;

namespace ThuChiForm
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var cmd = new ThuChiListRepository())
            {
                this.ChartThuChi.Series["Thu"].Points.Clear();
                this.ChartThuChi.Series["Chi"].Points.Clear();
                cmd.datetimepicker1 = this.dateTimePicker1.Value.ToShortDateString();
                cmd.datetimepicker2 = this.dateTimePicker2.Value.ToShortDateString();
                var data = cmd.Execute();
                if(this.cbbDangBieuDo.SelectedIndex.ToString() == "0")
                {
                    this.ChartThuChi.Series["Thu"].ChartType = SeriesChartType.Line;
                    this.ChartThuChi.Series["Chi"].ChartType = SeriesChartType.Line;
                }
                else
                {
                    this.ChartThuChi.Series["Thu"].ChartType = SeriesChartType.Column;
                    this.ChartThuChi.Series["Chi"].ChartType = SeriesChartType.Column;
                }
                if (data.Count == 1)
                {
                    this.ChartThuChi.Series["Thu"].ChartType = SeriesChartType.Column;
                    this.ChartThuChi.Series["Chi"].ChartType = SeriesChartType.Column;
                    this.cbbDangBieuDo.SelectedIndex = 1;
                }
                if (this.cbbXemTheo.SelectedIndex.ToString() == "0")
                {                    
                    foreach (var item in data)
                    {
                        this.ChartThuChi.Series["Thu"].Points.AddXY(item.Ngay.ToShortDateString(), item.Thu);
                        this.ChartThuChi.Series["Chi"].Points.AddY(item.Chi.ToString());
                    }
                    
                }
                else if(this.cbbXemTheo.SelectedIndex.ToString() == "1")
                {
                    var thu = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    var chi = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    foreach (var item in data)
                    {
                        switch (item.Ngay.Month)
                        {
                            case 1:
                                thu[0] += item.Thu;
                                chi[0] += item.Chi;
                                break;
                            case 2:
                                thu[1] += item.Thu;
                                chi[1] += item.Chi;
                                break;
                            case 3:
                                thu[2] += item.Thu;
                                chi[2] += item.Chi;
                                break;
                            case 4:
                                thu[3] += item.Thu;
                                chi[3] += item.Chi;
                                break;
                            case 5:
                                thu[4] += item.Thu;
                                chi[4] += item.Chi;
                                break;
                            case 6:
                                thu[5] += item.Thu;
                                chi[5] += item.Chi;
                                break;
                            case 7:
                                thu[6] += item.Thu;
                                chi[6] += item.Chi;
                                break;
                            case 8:
                                thu[7] += item.Thu;
                                chi[7] += item.Chi;
                                break;
                            case 9:
                                thu[8] += item.Thu;
                                chi[8] += item.Chi;
                                break;
                            case 10:
                                thu[9] += item.Thu;
                                chi[9] += item.Chi;
                                break;
                            case 11:
                                thu[10] += item.Thu;
                                chi[10] += item.Chi;
                                break;
                            case 12:
                                thu[11] += item.Thu;
                                chi[11] += item.Chi;
                                break;
                        }
                    }
                    int dem1 = 1;
                    int dem2 = 1;
                    foreach (var item in thu)
                    {
                        this.ChartThuChi.Series["Thu"].Points.AddXY("Tháng " + dem1.ToString(), item.ToString());

                        dem1++;
                    }
                    
                    foreach (var item in chi)
                    {
                        
                         this.ChartThuChi.Series["Chi"].Points.AddXY("Tháng " + dem2.ToString(),item.ToString());
                        
                        
                    }
                }
                
            }
        }

        private void frmChart_Load(object sender, EventArgs e)
        {
            this.cbbDangBieuDo.Items.Insert(0, "Biểu đồ đường");
            this.cbbDangBieuDo.Items.Insert(1, "Biểu đồ cột");
            this.cbbDangBieuDo.SelectedIndex = 0;

            this.cbbXemTheo.Items.Insert(0, "Xem theo ngày");
            this.cbbXemTheo.Items.Insert(1, "Xem theo tháng");
            this.cbbXemTheo.Items.Insert(2, "Xem theo năm");
            this.cbbXemTheo.SelectedIndex = 0;
            
        }
    }
}
