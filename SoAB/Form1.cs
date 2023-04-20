using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoAB
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            UCLN ob = new UCLN(int.Parse(txtSoa.Text), int.Parse(txtSob.Text));
            ob.Ghi_File(txtFilename.Text);
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            UCLN ob = new UCLN();
            string kq = ob.Doc_File(txtFilename.Text);
            MessageBox.Show(kq);
        }
    }
}
