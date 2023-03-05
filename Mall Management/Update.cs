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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Movie newform = new Movie();
            this.Hide();
            newform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List newform = new List();
            newform.ShowDialog();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand cmd;
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") || comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Enter all details please");
            }
            else
            {
                string sqlch = "select * from movie where movieid='" + textBox1.Text + "'";
                OleDbDataAdapter dataadapterch = new OleDbDataAdapter(sqlch, connection);
                DataTable dtch = new DataTable();
                dataadapterch.Fill(dtch);
                if (dtch.Rows.Count != 0)
                    MessageBox.Show("This movie id already exists. Choose another one.");
                else
                {
                    string sql = "insert into movie values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "' ,'" + textBox3.Text + "')";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand cmd;
            string sqlch = "select * from movie where movieid='" + textBox4.Text + "'";
            OleDbDataAdapter dataadapterch = new OleDbDataAdapter(sqlch, connection);
            DataTable dtch = new DataTable();
            dataadapterch.Fill(dtch);
            if (dtch.Rows.Count == 0)
                MessageBox.Show("This movie id does not exist. Check movie list.");
            else
            {
                string sql = "update audi set movid='" + textBox4.Text + "' where audino='Audi1'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Movie Updated");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand cmd;
            string sqlch = "select * from movie where movieid='" + textBox5.Text + "'";
            OleDbDataAdapter dataadapterch = new OleDbDataAdapter(sqlch, connection);
            DataTable dtch = new DataTable();
            dataadapterch.Fill(dtch);
            if (dtch.Rows.Count == 0)
                MessageBox.Show("This movie id does not exist. Check movie list.");
            else
            {
                string sql = "update audi set movid='" + textBox5.Text + "' where audino='Audi2'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Movie Updated");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
