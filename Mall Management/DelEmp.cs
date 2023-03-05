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

namespace Login
{
    public partial class DelEmp : Form
    {
        string id;
        public DelEmp(String i)
        {
            InitializeComponent();
            id = i;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand cmd,cmd1;
            string sql1;
            if (textBox1.Text.Equals(""))
                MessageBox.Show("Enter the ID please");
            else
            {
                String sql2 = "select dept from emp where empid='" + textBox1.Text + "'";
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql2, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    if (dt.Rows[0][0].ToString() == id)
                    {
                        sql1 = "delete from emplogin where empid='" + textBox1.Text + "'";
                        cmd1 = new OleDbCommand(sql1, connection);
                        cmd1.ExecuteNonQuery();
                    }
                    string sql = "delete from emp where empid='" + textBox1.Text + "' and dept='" + id + "'";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee has been deleted");
                    this.Hide();
                }
                else
                    MessageBox.Show("This employee does not exist");
            }
        }

        private void DelEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
