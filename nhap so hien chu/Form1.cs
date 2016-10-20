using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nhap_so_hien_chu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string s = txtSo.Text;

            int so = Convert.ToInt16(s);

            switch (so)
            {
                case 1:
                    {
                        string x = "Mot";
                        txtChu.Text = x;
                        break;
                    }
                case 2:
                    {
                        string x = "Hai";
                        txtChu.Text = x;
                        break;
                    }
                case 3:
                    {
                        string x = "Ba";
                        txtChu.Text = x;
                        break;
                    }

                case 4:
                    {
                        string x = "Bon";
                        txtChu.Text = x;
                        break;
                    }
                case 5:
                    {
                        string x = "Nam";
                        txtChu.Text = x;
                        break;
                    }
                case 6:
                    {
                        string x = "Sau";
                        txtChu.Text = x;
                        break;
                    }
                case 7:
                    {
                        string x = "Bay";
                        txtChu.Text = x;
                        break;
                    }
                case 8:
                    {
                        string x = "Tam";
                        txtChu.Text = x;
                        break;
                    }
                case 9:
                    {
                        string x = "Chin";
                        txtChu.Text = x;
                        break;
                    }
            }
        }

        private void txtThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

