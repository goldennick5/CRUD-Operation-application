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
    public partial class MainSite : Form
    {
        SqlConnection DataBase = new SqlConnection();
        public MainSite()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainSite_Load(object sender, EventArgs e)
        {

        }

        private void Products_Click(object sender, EventArgs e)
        {
            Hide();
            Products prod = new Products();
            prod.Show();
        }

        private void Workers_Click(object sender, EventArgs e)
        {
            Hide();
            Workers work = new Workers();
            work.Show();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            Hide();
            Customers cust = new Customers();
            cust.Show();  
        }

        private void Journal_but_Click(object sender, EventArgs e)
        {
            Hide();
            Journal jour = new Journal();
            jour.Show();
        }
    }
}
