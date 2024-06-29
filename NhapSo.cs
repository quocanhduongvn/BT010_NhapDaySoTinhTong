using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography;

namespace BT010_NapDaySoTinhTong
{
    internal class NhapSo
    {
        public static DialogResult NhapSoVaTinhTong(string title, string promptext, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button btnOK = new Button();
            Button btnCancel = new Button();

            //
            form.Text = title;
            label.Text = promptext;
            textBox.Text = value;
            //
            btnOK.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;




            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }
    }
}
