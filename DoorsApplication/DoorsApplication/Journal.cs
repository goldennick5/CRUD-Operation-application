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
using System.Configuration;

namespace DoorsApplication
{
    public partial class Journal : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VMHQDL8\SQLEXPRESS;Initial Catalog=doors;Integrated Security=True");
        void GetData()
        {
            string array = "select ORDER_CODE, FK_PRODUCT, FK_CUSTOMER, FK_WORKER, DATE_PLACEMENT, DATE_EXECUTION from Journal";
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(array, conn);
            DataTable datatb = new DataTable();
            adap.Fill(datatb);
            dgvJournal.DataSource = datatb;
            conn.Close();
        }
        public Journal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void Journal_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void Submit_but_Click(object sender, EventArgs e)
        {
            string array = "insert into Journal(FK_PRODUCT, FK_CUSTOMER, FK_WORKER, DATE_PLACEMENT, DATE_EXECUTION) values(@FK_PRODUCT, @FK_CUSTOMER, @FK_WORKER, @DATE_PLACEMENT, @DATE_EXECUTION)";

            SqlCommand com = new SqlCommand(array, conn);

            com.Parameters.AddWithValue("@ORDER_CODE", Jr_order.Text);
            com.Parameters.AddWithValue("@FK_PRODUCT", Jr_product.Text);
            com.Parameters.AddWithValue("@FK_CUSTOMER", Jr_customer.Text);
            com.Parameters.AddWithValue("@FK_WORKER", Jr_worker.Text);
            com.Parameters.AddWithValue("@DATE_PLACEMENT", Jr_come.Value);
            com.Parameters.AddWithValue("@DATE_EXECUTION", Jr_out.Value);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetData();
            MessageBox.Show("Успешно создано!");
        }

        private void dgvJournal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Jr_order.Text = dgvJournal.CurrentRow.Cells[0].Value.ToString();
            Jr_product.Text = dgvJournal.CurrentRow.Cells[1].Value.ToString();
            Jr_customer.Text = dgvJournal.CurrentRow.Cells[2].Value.ToString();
            Jr_worker.Text = dgvJournal.CurrentRow.Cells[3].Value.ToString();
            Jr_come.Text = dgvJournal.CurrentRow.Cells[4].Value.ToString();
            Jr_out.Text = dgvJournal.CurrentRow.Cells[5].Value.ToString();
        }

        private void Journal_change_Click(object sender, EventArgs e)
        {
            string array = "update Journal set FK_PRODUCT = @FK_PRODUCT, " + "FK_CUSTOMER = @FK_CUSTOMER, " +
                "FK_WORKER = @FK_WORKER, " + "DATE_PLACEMENT = @DATE_PLACEMENT, " +
                 "DATE_EXECUTION = @DATE_EXECUTION where ORDER_CODE = @ORDER_CODE";

            SqlCommand com = new SqlCommand(array, conn);
            com.Parameters.AddWithValue("@ORDER_CODE", Jr_order.Text);
            com.Parameters.AddWithValue("@FK_PRODUCT", Jr_product.Text);
            com.Parameters.AddWithValue("@FK_CUSTOMER", Jr_customer.Text);
            com.Parameters.AddWithValue("@FK_WORKER", Jr_worker.Text);
            com.Parameters.AddWithValue("@DATE_PLACEMENT", Jr_come.Value);
            com.Parameters.AddWithValue("@DATE_EXECUTION", Jr_out.Value);

            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetData();

            MessageBox.Show("Таблица успешна обновлена!");
        }

        private void Journal_delete_Click(object sender, EventArgs e)
        {
            string array = "delete from Journal where ORDER_CODE=@ORDER_CODE";
            SqlCommand com = new SqlCommand(array, conn);
            com.Parameters.AddWithValue("ORDER_CODE", Jr_order.Text);
            conn.Open();
            com.ExecuteNonQuery();
            conn.Close();
            GetData();
            MessageBox.Show("Строка успешно удалена!");
        }

        private void Journal_search_Click(object sender, EventArgs e)
        {
            if (Jr_order.Text == "")
            {
                GetData();
            }
            else
            {
                string array = "select ORDER_CODE, FK_PRODUCT, FK_CUSTOMER, FK_WORKER, DATE_PLACEMENT, DATE_EXECUTION from Journal where ORDER_CODE='" + Jr_order.Text + "'";
                conn.Open();
                SqlDataAdapter adap = new SqlDataAdapter(array, conn);
                DataTable datatb = new DataTable();
                adap.Fill(datatb);
                dgvJournal.DataSource = datatb;
                conn.Close();
            }
        }

        private void Products_back_Click(object sender, EventArgs e)
        {
            Hide();
            MainSite mainsite = new MainSite();
            mainsite.Show();
        }
    }
}
