using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT010_NapDaySoTinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbDaySo.Enabled =false;
            tbTong.Enabled =false;
            tbTongChan.Enabled =false;
            tbTongLe.Enabled =false;
            //hello
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbDaySo.ResetText();
            tbTong.ResetText();
            tbTongChan.ResetText();
            tbTongLe.ResetText();
            tbInput.ResetText();
        }
        public string inputFromForm;
        private void btnNhapSo_Click(object sender, EventArgs e)
        {
           FormNhapDaySo nhapDaySo = new FormNhapDaySo();
            if(nhapDaySo.ShowDialog() == DialogResult.OK)
            {
                tbInput.Text = nhapDaySo.DulieuNhap;
                if (!XuLyDayNhap.IsChuoiSo(tbInput.Text))
                {
                    MessageBox.Show("Hãy nhập Dãy Số Nguyên!");
                    tbInput.ResetText();
                }
                else
                {
                    tbDaySo.Text = tbInput.Text;
                    string s = tbDaySo.Text;
                    tbTong.Text = XuLyDayNhap.SumString(s).ToString();
                    var resuilt = XuLyDayNhap.CalculateEvenAndOddSumString(s);
                    tbTongChan.Text = resuilt.evenSum.ToString();
                    tbTongLe.Text = resuilt.oddSum.ToString();
                }
            }
            
            /*
            
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tbInput.Text = "1 2 3 4 5 6 7 8 9";
        }
    }
}
