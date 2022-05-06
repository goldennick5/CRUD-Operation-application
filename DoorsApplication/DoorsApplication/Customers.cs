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
    public partial class Customers : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VMHQDL8\SQLEXPRESS;Initial Catalog=doors;Integrated Security=True");
        SqlCommand com;
        SqlDataAdapter adap;

        void GetData()
        {
            string array = "select CUSTOMER_ID, CUSTOMER_SURNAME, CUSTOMER_NAME, CUSTOMER_PATRONOMIC, CUSTOMER_PHONE, CUSTOMER_EMAIL, CUSTOMER_ADDRESS, CUSTOMER_HOME, CUSTOMER_ENTRANCE, CUSTOMER_FLAT from Customers";
            conn.Open();
            adap = new SqlDataAdapter(array, conn);
            DataTable datatb = new DataTable();
            adap.Fill(datatb);
            dgvCustomers.DataSource = datatb;
            conn.Close();
        }

        public Customers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void dgvcustomers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Customer_id.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            Customer_surname.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            Customer_name.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            Customer_patro.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            Customer_number.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            Customer_email.Text = dgvCustomers.CurrentRow.Cells[5].Value.ToString();
            Customer_address.Text = dgvCustomers.CurrentRow.Cells[6].Value.ToString();
            Customer_home.Text = dgvCustomers.CurrentRow.Cells[7].Value.ToString();
            Customer_entrance.Text = dgvCustomers.CurrentRow.Cells[8].Value.ToString();
            Customer_flat.Text = dgvCustomers.CurrentRow.Cells[9].Value.ToString();
        }

        private void Customer_insert_Click(object sender, EventArgs e)
        {
            string array = "INSERT INTO Customers (CUSTOMER_SURNAME, CUSTOMER_NAME, CUSTOMER_PATRONOMIC, CUSTOMER_PHONE, CUSTOMER_EMAIL, CUSTOMER_ADDRESS, CUSTOMER_HOME, CUSTOMER_ENTRANCE, CUSTOMER_FLAT) VALUES(@CUSTOMER_SURNAME, @CUSTOMER_NAME, @CUSTOMER_PATRONOMIC, @CUSTOMER_PHONE, @CUSTOMER_EMAIL, @CUSTOMER_ADDRESS, @CUSTOMER_HOME,@CUSTOMER_ENTRANCE, @CUSTOMER_FLAT)";

            com = new SqlCommand(array, conn);

            com.Parameters.AddWithValue("@CUSTOMER_SURNAME", Customer_surname.Text);
            com.Parameters.AddWithValue("@CUSTOMER_NAME", Customer_name.Text);
            com.Parameters.AddWithValue("@CUSTOMER_PATRONOMIC", Customer_patro.Text);
            com.Parameters.AddWithValue("@CUSTOMER_PHONE", Customer_number.Text);
            com.Parameters.AddWithValue("@CUSTOMER_EMAIL", Customer_email.Text);
            com.Parameters.AddWithValue("@CUSTOMER_ADDRESS", Customer_address.Text);
            com.Parameters.AddWithValue("@CUSTOMER_HOME", Customer_home.Text);
            com.Parameters.AddWithValue("@CUSTOMER_ENTRANCE", Customer_entrance.Text);
            com.Parameters.AddWithValue("@CUSTOMER_FLAT", Customer_flat.Text);


            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetData();
            MessageBox.Show("Успешно создано!");
        }

        private void Customer_change_Click(object sender, EventArgs e)
        {
            string array = "update Customers set CUSTOMER_SURNAME = @CUSTOMER_SURNAME, " + "CUSTOMER_NAME = @CUSTOMER_NAME, " +
                "CUSTOMER_PATRONOMIC = @CUSTOMER_PATRONOMIC, " + "CUSTOMER_PHONE = @CUSTOMER_PHONE, " +
                "CUSTOMER_EMAIL = @CUSTOMER_EMAIL, " + "CUSTOMER_ADDRESS = @CUSTOMER_ADDRESS, " + "CUSTOMER_HOME = @CUSTOMER_HOME, " +
                "CUSTOMER_ENTRANCE = @CUSTOMER_ENTRANCE, " + "CUSTOMER_FLAT = @CUSTOMER_FLAT where CUSTOMER_ID = @CUSTOMER_ID";

            com = new SqlCommand(array, conn);
            com.Parameters.AddWithValue("@CUSTOMER_ID", Customer_id.Text);
            com.Parameters.AddWithValue("@CUSTOMER_SURNAME", Customer_surname.Text);
            com.Parameters.AddWithValue("@CUSTOMER_NAME", Customer_name.Text);
            com.Parameters.AddWithValue("@CUSTOMER_PATRONOMIC", Customer_patro.Text);
            com.Parameters.AddWithValue("@CUSTOMER_PHONE", Customer_number.Text);
            com.Parameters.AddWithValue("@CUSTOMER_EMAIL", Customer_email.Text);
            com.Parameters.AddWithValue("@CUSTOMER_ADDRESS", Customer_address.Text);
            com.Parameters.AddWithValue("@CUSTOMER_HOME", Customer_home.Text);
            com.Parameters.AddWithValue("@CUSTOMER_ENTRANCE", Customer_entrance.Text);
            com.Parameters.AddWithValue("@CUSTOMER_FLAT", Customer_flat.Text);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetData();

            MessageBox.Show("Таблица успешна обновлена!");
        }

        private void Customer_delete_Click(object sender, EventArgs e)
        {
            string array = "delete from Customers where CUSTOMER_ID=@CUSTOMER_ID";
            com = new SqlCommand(array, conn);
            com.Parameters.AddWithValue("CUSTOMER_ID", Customer_id.Text);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetData();
            MessageBox.Show("Строка успешно удалена!");
        }

        private void Customer_search_Click(object sender, EventArgs e)
        {
            if (Customer_id.Text == "")
            {
                GetData();
            }
            else
            {
                string array = "select CUSTOMER_ID, CUSTOMER_SURNAME, CUSTOMER_NAME, CUSTOMER_PATRONOMIC, CUSTOMER_PHONE, CUSTOMER_EMAIL, CUSTOMER_ADDRESS, CUSTOMER_HOME, CUSTOMER_ENTRANCE, CUSTOMER_FLAT from Customers where CUSTOMER_ID='" + Customer_id.Text + "'";
                conn.Open();
                adap = new SqlDataAdapter(array, conn);
                DataTable datatb = new DataTable();
                adap.Fill(datatb);
                dgvCustomers.DataSource = datatb;
                conn.Close();
            }
        }

        private void Customers_back_Click(object sender, EventArgs e)
        {
            Hide();
            MainSite mainsite_back = new MainSite();
            mainsite_back.Show();
        }
    }
}
