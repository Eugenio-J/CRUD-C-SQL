
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUDOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand($"insert into student01 values('{txtid.Text.ToString()}','{txtname.Text}','{txtaddress.Text}','{txtsalary.Text}')");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cleardata();
            displaydata();
        }

        private void cleardata()
        {
            txtid.Clear();
            txtname.Clear();
            txtaddress.Clear();
            txtsalary.Clear();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update student01 set name='" + txtname.Text + "',Address='" + txtaddress.Text + "',salary='" + txtsalary.Text.ToString() + "' where id='" + txtid.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            displaydata();
            cleardata();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student01";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string query = $"delete student01 where id='{txtid.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = query;
            cleardata();
            displaydata();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CrudDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from student01 where id='{txtsearch.Text}'";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtname.Text = dt.ToString();
            txtaddress.Text = dt.ToString();
            txtsalary.Text = dt.ToString();
            dataGridView1.DataSource = dt;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}