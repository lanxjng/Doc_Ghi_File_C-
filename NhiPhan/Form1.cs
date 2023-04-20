using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhiPhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSoNguyen_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SNT ob = new SNT(int.Parse(txtSoNguyen.Text));
            ob.Ghi_File(txtFile.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SNT ob = new SNT();
            string kq = ob.Doc_File(txtFile.Text);
            MessageBox.Show(kq);
        }
    }
}
