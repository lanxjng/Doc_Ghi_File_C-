using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace NhiPhan
{
    class SNT
    {
        public int n { get; set; }

        public SNT(){}
        public SNT(int n)
        {
            this.n = n; 
        }
        public bool KTNT(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public void Ghi_Text(string filename)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename);
                for (int i =1; i < this.n; i++)
                {
                    if (KTNT(i)) sw.WriteLine(i);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public void Ghi_File(string filename)
        {
            BinaryWriter bw = null;
            int dem = 0;
            try
            {
                bw = new BinaryWriter(new FileStream(filename, FileMode.Create));
                for (int i = 1; i < this.n; i++)
                {
                    if (KTNT(i)) dem++;
                }
                bw.Write(dem);
                for (int i = 1; i < this.n; i++)
                    if (KTNT(i)) bw.Write(i);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            finally { bw.Close(); }
        }
        public string Doc_File(string filename)
        {
            BinaryReader br = null;
            string kq = "";
            try
            {
                int i;
                br = new BinaryReader(new FileStream(filename, FileMode.Open));
                int dem = br.ReadInt32();
                for (i = 0; i < dem; i++)
                    kq = kq + br.ReadInt32() + " ";
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message);
            }
            finally { br.Close(); }
            return kq;
        }

    }
}
