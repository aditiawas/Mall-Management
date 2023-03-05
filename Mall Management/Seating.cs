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
    public partial class Seating : Form
    {
        String re,ti;
        public Seating(String s, String t)
        {
            InitializeComponent();
            re = s;
            ti = t;
        }

        private void Seating_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string se;
            se = "A1";
            if(firstgo(se,connection))
            {
                checkBox1.BackColor = Color.FromName("Gray");
                checkBox1.Enabled = false;
            }
            se = "A2";
            if (firstgo(se, connection))
            {
                checkBox2.BackColor = Color.FromName("Gray");
                checkBox2.Enabled = false;
            }
            se = "A3";
            if (firstgo(se, connection))
            {
                checkBox3.BackColor = Color.FromName("Gray");
                checkBox3.Enabled = false;
            }
            se = "A4";
            if (firstgo(se, connection))
            {
                checkBox4.BackColor = Color.FromName("Gray");
                checkBox4.Enabled = false;
            }
            se = "B1";
            if (firstgo(se, connection))
            {
                checkBox5.BackColor = Color.FromName("Gray");
                checkBox5.Enabled = false;
            }
            se = "B2";
            if (firstgo(se, connection))
            {
                checkBox6.BackColor = Color.FromName("Gray");
                checkBox6.Enabled = false;
            }
            se = "B3";
            if (firstgo(se, connection))
            {
                checkBox7.BackColor = Color.FromName("Gray");
                checkBox7.Enabled = false;
            }
            se = "B4";
            if (firstgo(se, connection))
            {
                checkBox8.BackColor = Color.FromName("Gray");
                checkBox8.Enabled = false;
            }
            se = "C1";
            if (firstgo(se, connection))
            {
                checkBox9.BackColor = Color.FromName("Gray");
                checkBox9.Enabled = false;
            }
            se = "C2";
            if (firstgo(se, connection))
            {
                checkBox10.BackColor = Color.FromName("Gray");
                checkBox10.Enabled = false;
            }
            se = "C3";
            if (firstgo(se, connection))
            {
                checkBox11.BackColor = Color.FromName("Gray");
                checkBox11.Enabled = false;
            }
            se = "C4";
            if (firstgo(se, connection))
            {
                checkBox12.BackColor = Color.FromName("Gray");
                checkBox12.Enabled = false;
            }
            se = "D1";
            if (firstgo(se, connection))
            {
                checkBox13.BackColor = Color.FromName("Gray");
                checkBox13.Enabled = false;
            }
            se = "D2";
            if (firstgo(se, connection))
            {
                checkBox14.BackColor = Color.FromName("Gray");
                checkBox14.Enabled = false;
            }
            se = "D3";
            if (firstgo(se, connection))
            {
                checkBox15.BackColor = Color.FromName("Gray");
                checkBox15.Enabled = false;
            }
            se = "D4";
            if (firstgo(se, connection))
            {
                checkBox16.BackColor = Color.FromName("Gray");
                checkBox16.Enabled = false;
            }
        }
        private Boolean firstgo (String seat, OleDbConnection connection)
        {
            String sql = "select "+ti+" from " + re + " where seatno='" + seat + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            return (dt.Rows[0][0].ToString() == "Y");
        }
        private void oncheck(String seat,int sign)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql_search = "select price from " + re +" where seatno='" + seat + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            int x = Convert.ToInt32(dt.Rows[0][0].ToString());
            int newcost = Convert.ToInt32(textBox1.Text) + (sign*x);
            textBox1.Text = newcost.ToString();
            connection.Close();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox1.Checked)
            {
                sign = -1;
            }
            oncheck("A1",sign);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox2.Checked)
            {
                sign = -1;
            }
            oncheck("A2",sign);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox3.Checked)
            {
                sign = -1;
            }
            oncheck("A3",sign);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox4.Checked)
            {
                sign = -1;
            }
            oncheck("A4",sign);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox5.Checked)
            {
                sign = -1;
            }
            oncheck("B1",sign);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox6.Checked)
            {
                sign = -1;
            }
            oncheck("B2",sign);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox7.Checked)
            {
                sign = -1;
            }
            oncheck("B3",sign);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox8.Checked)
            {
                sign = -1;
            }
            oncheck("B4",sign);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox9.Checked)
            {
                sign = -1;
            }
            oncheck("C1",sign);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox10.Checked)
            {
                sign = -1;
            }
            oncheck("C2",sign);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox11.Checked)
            {
                sign = -1;
            }
            oncheck("C3",sign);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox12.Checked)
            {
                sign = -1;
            }
            oncheck("C4",sign);
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox13.Checked)
            {
                sign = -1;
            }
            oncheck("D1",sign);
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox14.Checked)
            {
                sign = -1;
            }
            oncheck("D2",sign);
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox15.Checked)
            {
                sign = -1;
            }
            oncheck("D3",sign);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            int sign = 1;
            if (!checkBox16.Checked)
            {
                sign = -1;
            }
            oncheck("D4",sign);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string se,sql;
            OleDbCommand cmd;
            if (checkBox1.Checked)
            {
                se = "A1";
                sql = "update " + re +" set "+ti+" = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox2.Checked)
            {
                se = "A2";
                sql = "update " + re +" set "+ti+" = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox3.Checked)
            {
                se = "A3";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox4.Checked)
            {
                se = "A4";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox5.Checked)
            {
                se = "B1";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox6.Checked)
            {
                se = "B2";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox7.Checked)
            {
                se = "B3";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox8.Checked)
            {
                se = "B4";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox9.Checked)
            {
                se = "C1";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox10.Checked)
            {
                se = "C2";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox11.Checked)
            {
                se = "C3";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox12.Checked)
            {
                se = "C4";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox13.Checked)
            {
                se = "D1";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox14.Checked)
            {
                se = "D2";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox15.Checked)
            {
                se = "D3";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (checkBox16.Checked)
            {
                se = "D4";
                sql = "update " + re + " set " + ti + " = 'Y' where seatno='" + se + "'";
                cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            if (textBox1.Text == "0")
                MessageBox.Show("No seats chosen");
            else
                MessageBox.Show("Your bill is: " + textBox1.Text + "₹");
            connection.Close();
            Movie newform = new Movie();
            this.Hide();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Book newform = new Book();
            this.Hide();
            newform.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
    }
}
