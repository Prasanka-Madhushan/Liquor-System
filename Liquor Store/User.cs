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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Prasanka\OneDrive\Documents\LiquorStoreDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UserDGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl VALUES('" + UnameTb.Text + "','" + FullnameTb.Text + "','" + PwdTb.Text + "','" + TeleTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added !");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(TeleTb.Text=="")
            {
                MessageBox.Show("Enter the Users Mobile Number");
            }
            else
            {
                Con.Open();
                string MyQuery = "DELETE FROM UserTbl WHERE Uphone='"+TeleTb.Text+"';";
                SqlCommand cmd = new SqlCommand(MyQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Deleted !");
                Con.Close();
                populate();
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            FullnameTb.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            PwdTb.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            TeleTb.Text = UserDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl set Uname='" + UnameTb.Text + "',Ufullname='" + FullnameTb.Text + "',Upassword='" + PwdTb.Text + "' WHERE Uphone='" + TeleTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated !");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }
    }
}
