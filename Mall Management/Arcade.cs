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
    public partial class Arcade : Form
    {
        public Arcade()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand cmd;
            Random r = new Random();
            int x = r.Next(1000, 9999);
            string sql1 = "select count(*) from arcade where memid='" + x + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql1, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                x = r.Next(1000, 9999);
            }
            string sql = "insert into arcade values('"+x+"',0)";
            cmd = new OleDbCommand(sql, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your Membership ID is : "+x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "select count(*) from arcade where memid='" + textBox3.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            if (dt.Rows[0][0].ToString() != "1")
            {
                MessageBox.Show("You are not registered yet");
            }
            else
            {
                string sql1 = "select credit from arcade where memid='" + textBox3.Text + "'";
                dataadapter = new OleDbDataAdapter(sql1, connection);
                dt = new DataTable();
                dataadapter.Fill(dt);
                textBox2.Text = dt.Rows[0][0].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "select count(*) from arcade where memid='" + textBox3.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            if (dt.Rows[0][0].ToString() != "1")
            {
                MessageBox.Show("You are not registered yet");
            }
            else
            {
                string sql1 = "select credit from arcade where memid='" + textBox3.Text + "'";
                dataadapter = new OleDbDataAdapter(sql1, connection);
                dt = new DataTable();
                dataadapter.Fill(dt);
                textBox2.Text = dt.Rows[0][0].ToString();
                if (textBox1.Text=="")
                {
                    textBox1.Text = "0";
                }
                double ans = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
                sql = "update arcade set credit=" + ans + " where memid='" + textBox3.Text + "'";
                dataadapter = new OleDbDataAdapter(sql, connection);
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                textBox2.Text = ans.ToString();
                textBox1.Text = "0";
            }
        }

        private void Arcade_Load(object sender, EventArgs e)
        {

        }
    }
}
