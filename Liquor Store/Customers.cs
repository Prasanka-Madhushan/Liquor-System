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

namespace Liquor_Store
{
    public partial class CustomerTbl : Form
    {
        public CustomerTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prasanka\OneDrive\Documents\LiquorStoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomerDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl VALUES('" + CustomerID.Text + "','" + CustomerName.Text + "','" + CustomerPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added !");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
    }
}
