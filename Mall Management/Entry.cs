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
    public partial class Entry : Form
    {
        String type;
        public Entry(String t)
        {
            InitializeComponent();
            type = t;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Entry_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string se;
            se = "A1";
            if (firstgo(se, connection))
            {
                radioButton1.BackColor = Color.FromName("Gray");
                radioButton1.Enabled = false;
            }
            se = "A2";
            if (firstgo(se, connection))
            {
                radioButton2.BackColor = Color.FromName("Gray");
                radioButton2.Enabled = false;
            }
            se = "A3";
            if (firstgo(se, connection))
            {
                radioButton3.BackColor = Color.FromName("Gray");
                radioButton3.Enabled = false;
            }
            se = "A4";
            if (firstgo(se, connection))
            {
                radioButton4.BackColor = Color.FromName("Gray");
                radioButton4.Enabled = false;
            }
            se = "A5";
            if (firstgo(se, connection))
            {
                radioButton5.BackColor = Color.FromName("Gray");
                radioButton5.Enabled = false;
            }
            se = "A6";
            if (firstgo(se, connection))
            {
                radioButton6.BackColor = Color.FromName("Gray");
                radioButton6.Enabled = false;
            }
            se = "A7";
            if (firstgo(se, connection))
            {
                radioButton7.BackColor = Color.FromName("Gray");
                radioButton7.Enabled = false;
            }
            se = "A8";
            if (firstgo(se, connection))
            {
                radioButton8.BackColor = Color.FromName("Gray");
                radioButton8.Enabled = false;
            }
            se = "B1";
            if (firstgo(se, connection))
            {
                radioButton9.BackColor = Color.FromName("Gray");
                radioButton9.Enabled = false;
            }
            se = "B2";
            if (firstgo(se, connection))
            {
                radioButton10.BackColor = Color.FromName("Gray");
                radioButton10.Enabled = false;
            }
            se = "B3";
            if (firstgo(se, connection))
            {
                radioButton11.BackColor = Color.FromName("Gray");
                radioButton11.Enabled = false;
            }
            se = "B4";
            if (firstgo(se, connection))
            {
                radioButton12.BackColor = Color.FromName("Gray");
                radioButton12.Enabled = false;
            }
            se = "B5";
            if (firstgo(se, connection))
            {
                radioButton13.BackColor = Color.FromName("Gray");
                radioButton13.Enabled = false;
            }
            se = "B6";
            if (firstgo(se, connection))
            {
                radioButton14.BackColor = Color.FromName("Gray");
                radioButton14.Enabled = false;
            }
            se = "B7";
            if (firstgo(se, connection))
            {
                radioButton15.BackColor = Color.FromName("Gray");
                radioButton15.Enabled = false;
            }
            se = "B8";
            if (firstgo(se, connection))
            {
                radioButton16.BackColor = Color.FromName("Gray");
                radioButton16.Enabled = false;
            }
            se = "C1";
            if (firstgo(se, connection))
            {
                radioButton17.BackColor = Color.FromName("Gray");
                radioButton17.Enabled = false;
            }
            se = "C2";
            if (firstgo(se, connection))
            {
                radioButton18.BackColor = Color.FromName("Gray");
                radioButton18.Enabled = false;
            }
            se = "C3";
            if (firstgo(se, connection))
            {
                radioButton19.BackColor = Color.FromName("Gray");
                radioButton19.Enabled = false;
            }
            se = "C4";
            if (firstgo(se, connection))
            {
                radioButton20.BackColor = Color.FromName("Gray");
                radioButton20.Enabled = false;
            }
            se = "C5";
            if (firstgo(se, connection))
            {
                radioButton21.BackColor = Color.FromName("Gray");
                radioButton21.Enabled = false;
            }
            se = "C6";
            if (firstgo(se, connection))
            {
                radioButton22.BackColor = Color.FromName("Gray");
                radioButton22.Enabled = false;
            }
            se = "C7";
            if (firstgo(se, connection))
            {
                radioButton23.BackColor = Color.FromName("Gray");
                radioButton23.Enabled = false;
            }
            se = "C8";
            if (firstgo(se, connection))
            {
                radioButton24.BackColor = Color.FromName("Gray");
                radioButton24.Enabled = false;
            }
            se = "D1";
            if (firstgo(se, connection))
            {
                radioButton25.BackColor = Color.FromName("Gray");
                radioButton25.Enabled = false;
            }
            se = "D2";
            if (firstgo(se, connection))
            {
                radioButton26.BackColor = Color.FromName("Gray");
                radioButton26.Enabled = false;
            }
            se = "D3";
            if (firstgo(se, connection))
            {
                radioButton27.BackColor = Color.FromName("Gray");
                radioButton27.Enabled = false;
            }
            se = "D4";
            if (firstgo(se, connection))
            {
                radioButton28.BackColor = Color.FromName("Gray");
                radioButton28.Enabled = false;
            }
            se = "D5";
            if (firstgo(se, connection))
            {
                radioButton29.BackColor = Color.FromName("Gray");
                radioButton29.Enabled = false;
            }
            se = "D6";
            if (firstgo(se, connection))
            {
                radioButton30.BackColor = Color.FromName("Gray");
                radioButton30.Enabled = false;
            }
            se = "D7";
            if (firstgo(se, connection))
            {
                radioButton31.BackColor = Color.FromName("Gray");
                radioButton31.Enabled = false;
            }
            se = "D8";
            if (firstgo(se, connection))
            {
                radioButton32.BackColor = Color.FromName("Gray");
                radioButton32.Enabled = false;
            }
        }
        private Boolean firstgo(String seat, OleDbConnection connection)
        {
           String sql = "select occu from " + type + " where spotid='" + seat + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            return (dt.Rows[0][0].ToString() == "Y");
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string se="X", sql;
            OleDbCommand cmd;
            if (radioButton1.Checked)
                se = "A1";
            if (radioButton2.Checked)
                se = "A2";
            if (radioButton3.Checked)
                se = "A3";
            if (radioButton4.Checked)
                se = "A4";
            if (radioButton5.Checked)
                se = "A5";
            if (radioButton6.Checked)
                se = "A6";
            if (radioButton7.Checked)
                se = "A7";
            if (radioButton8.Checked)
                se = "A8";
             if (radioButton9.Checked)
                se = "B1";
            if (radioButton10.Checked)
                se = "B2";
            if (radioButton11.Checked)
                se = "B3";
            if (radioButton12.Checked)
                se = "B4";
            if (radioButton13.Checked)
                se = "B5";
            if (radioButton14.Checked)
                se = "B6";
            if (radioButton15.Checked)
                se = "B7";
            if (radioButton16.Checked)
                se = "B8";
            if (radioButton17.Checked)
                se = "C1";
            if (radioButton18.Checked)
                se = "C2";
            if (radioButton19.Checked)
                se = "C3";
            if (radioButton20.Checked)
                se = "C4";
            if (radioButton21.Checked)
                se = "C5";
            if (radioButton22.Checked)
                se = "C6";
            if (radioButton23.Checked)
                se = "C7";
            if (radioButton24.Checked)
                se = "C8";
            if (radioButton25.Checked)
                se = "D1";
            if (radioButton26.Checked)
                se = "D2";
            if (radioButton27.Checked)
                se = "D3";
            if (radioButton28.Checked)
                se = "D4";
            if (radioButton29.Checked)
                se = "D5";
            if (radioButton30.Checked)
                se = "D6";
            if (radioButton31.Checked)
                se = "D7";
            if (radioButton32.Checked)
                se = "D8";
            if (se == "X")
                MessageBox.Show("Select a parking space");
            if (textBox1.Text.Equals(""))
                MessageBox.Show("Enter the vehicle number first");
            else
            {
                sql="select * from "+ type + " where vehno='"+textBox1.Text+"'";
                OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                dataadapter.Fill(dt);
                if (dt.Rows.Count != 0)
                    MessageBox.Show("It is already in the lot. Cannot assign another spot");
                else
                {
                    DateTime ob = DateTime.Now;
                    sql = "update " + type + " set occu='Y', vehno='" + textBox1.Text + "', tentry='" + ob.ToString() + "' where spotid='" + se + "'";
                    cmd = new OleDbCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Please proceed to the assigned spotid");
                    Entry newform = new Entry(type);
                    this.Hide();
                    newform.ShowDialog();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parkingview newform = new Parkingview();
            this.Hide();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
