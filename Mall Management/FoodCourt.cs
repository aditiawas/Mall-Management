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
    public partial class FoodCourt : Form
    {
        public FoodCourt()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbDataAdapter dataadapter;
            double pay = 0;
            String sql;
            if (checkBox1.Checked)
            {
                sql = "select price from food where itemid=1";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox2.Checked)
            {
                sql = "select price from food where itemid=2";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox3.Checked)
            {
                sql = "select price from food where itemid=3";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox4.Checked)
            {
                sql = "select price from food where itemid=4";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox5.Checked)
            {
                sql = "select price from food where itemid=5";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox6.Checked)
            {
                sql = "select price from food where itemid=6";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox7.Checked)
            {
                sql = "select price from food where itemid=7";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox8.Checked)
            {
                sql = "select price from food where itemid=8";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox9.Checked)
            {
                sql = "select price from food where itemid=9";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox10.Checked)
            {
                sql = "select price from food where itemid=10";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox11.Checked)
            {
                sql = "select price from food where itemid=11";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (checkBox12.Checked)
            {
                sql = "select price from food where itemid=12";
                dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                pay = pay + Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            if (pay == 0)
                MessageBox.Show("Select some food items to buy.");
            else
                MessageBox.Show("Your bill is: "  +pay+ "₹");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FoodCourt_Load(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
