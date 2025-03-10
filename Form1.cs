using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai19_fromđăngnhâp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnđăngnhap_Click(object sender, EventArgs e)
        {
            string u = "admin";
            string p = "123";
            if (txtuser.Text == u && txtpass.Text == p)
            {
                // hiện from chương trình chính
                Mainfrom mainfrom = new Mainfrom();
                this.Hide();
                mainfrom.ShowDialog();
                this.Close();

            }
            else
            {
                if (txtuser.TextLength == 0)
                {
                    // MessageBox.show("user không được để trống");
                    errorProviderUser.SetError(txtuser, "không được để trống");
                }
                else
                {
                    errorProviderUser.Clear();

                }
                if (txtpass.TextLength == 0)
                {
                    errorProviderpass.SetError(txtpass, "không được để trống");
                }
                else
                {
                    errorProviderpass.Clear();
                }
                // MessageBox.show("đăng nhập thất bại");
                lblInfor.Text = "sai tên mật khẩu";
                    }
                }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblInfor.Text = "";
        }
    }

        }
    

