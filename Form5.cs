using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Project;Integrated Security=True");
        private void btnInsert_Click(object sender, EventArgs e)
        {

            string s = "insert into mytable1 values('" + txtId.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtSalary.Text + "')";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted successfully");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string s = "update mytable1 set name='"+txtName.Text+"',address='"+txtAddress.Text+"',salary='"+txtSalary.Text+"'where id='"+txtId.Text+"'";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string s = "delete from mytable1 where id='" + txtId.Text + "'";
            SqlCommand cmd = new SqlCommand(s, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted successfully");
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = " ";
            txtName.Text = "";
            txtAddress.Text = "";
            txtSalary.Text = "";
        }
    }
}
