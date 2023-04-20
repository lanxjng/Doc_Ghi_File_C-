using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace SoAB
{
    class UCLN
    {
        public int a { get; set; }
        public int b { get; set; }
        int n;

        public UCLN() { }
        public UCLN( int a, int b)
        {
            this.a = a;
            this.b = b;
                
        }
        public bool TimUoc(int a, int b)
        {
            int Ucln = 1;
            int j = (a < b) ? a : b;
            for (int i = 1; i <= j; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Ucln = i;
                }
            }
                return true;
            
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
                    if (TimUoc(a,b)) dem++;
                }
                bw.Write(dem);
                for (int i = 1; i < this.n; i++)
                    if (TimUoc(a,b)) bw.Write(i);
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
