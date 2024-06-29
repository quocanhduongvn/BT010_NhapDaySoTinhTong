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
    public partial class FormNhapDaySo : Form
    {
        public FormNhapDaySo()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string DulieuNhap;
        private void btnOK_Click(object sender, EventArgs e)
        {
            DulieuNhap = tbInputForm.Text;
            DialogResult = DialogResult.OK;
           
        }
    }
}
