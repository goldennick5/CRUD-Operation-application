using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoorsApplication
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VMHQDL8\SQLEXPRESS;Initial Catalog=doors;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from users where USERNAME=@username and USERPASS=@USERPASS", con);
            cmd.Parameters.AddWithValue("@username", txtName.Text);
            cmd.Parameters.AddWithValue("@userpass", txtPass.Text);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Hide();
                MainSite mainsite = new MainSite();
                mainsite.Show();
            }
            else
            {
                MessageBox.Show("Ошибка авторизации, попробуйте снова!");
            }
            con.Close();
        }
    }
}
