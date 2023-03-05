using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Login
{
    public partial class AddEmp : Form
    {
        String id;
        public AddEmp(String i)
        {
            InitializeComponent();
            id = i;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString());
            return sb.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand cmd,cmd1;
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || textBox4.Text.Equals("") || textBox5.Text.Equals(""))
                MessageBox.Show("Enter all details please");
            else
            {
                string sqlch = "select * from emp where empid='" + textBox1.Text + "'";
                OleDbDataAdapter dataadapterch = new OleDbDataAdapter(sqlch, connection);
                DataTable dtch = new DataTable();
                dataadapterch.Fill(dtch);
                if (dtch.Rows.Count != 0)
                    MessageBox.Show("This employee already exists. Choose another one.");
                else
                {
                    string sql_search = "select type from inter where shopid='" + id + "'";
                    OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);
                    DataTable dt = new DataTable();
                    dataadapter.Fill(dt);
                    string tt = dt.Rows[0][0].ToString();
                    String x = CalculateMD5Hash(textBox5.Text);
                    string sql = "insert into emp values('" + textBox1.Text + "','" + textBox2.Text + "','" + id + "','" + textBox3.Text + "' ,'" + textBox4.Text + "')";
                    string sql1 = "insert into emplogin values('" + textBox1.Text + "','" + x + "','" + tt + "')";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    cmd1 = new OleDbCommand(sql1, connection);
                    cmd1.ExecuteNonQuery();
                    this.Hide();
                }
            }
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminview newform = new Adminview();
            this.Hide();
            newform.ShowDialog();
        }
    }
}
