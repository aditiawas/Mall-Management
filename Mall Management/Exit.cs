using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace Login
{
    public partial class Exit : Form
    {
        String type;
        public Exit(String t)
        {
            InitializeComponent();
            type = t;
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=0;
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            DateTime ob2 = DateTime.Now;
            string sql1 = "select tentry from " + type + " where vehno='" + textBox1.Text + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql1, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Enter valid vehicle number that is present in the lot");
            else
            {
                DateTime ob3 = Convert.ToDateTime(dt.Rows[0][0]);
                TimeSpan ob = ob2 - ob3;
                TimeSpan comp1 = new TimeSpan(0, 2, 0, 0);
                TimeSpan comp2 = new TimeSpan(0, 5, 0, 0);
                if (ob < comp1)
                {
                    MessageBox.Show("20Rs");
                    x = 20;
                }
                else if (ob < comp2)
                {
                    MessageBox.Show("50Rs");
                    x = 50;
                }
                else
                {
                    MessageBox.Show("75Rs");
                    x = 75;
                }


                string sql2 = "insert into parkhistory values ('" + ob3.ToString() + "','" + ob2.ToString() + "','" + textBox1.Text + "','" + type + "','" + DateTime.Today.ToString().Substring(0,9) + "')";
                OleDbCommand cmd2 = new OleDbCommand(sql2, connection);
                cmd2.ExecuteNonQuery();
                string sql = "update " + type + " set occu='N', vehno='', tentry='' where vehno='" + textBox1.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql, connection);
                cmd.ExecuteNonQuery();
                string sql3 = "update shop set rev=rev+"+x+" where name='Parking'";
                OleDbCommand cmd3 = new OleDbCommand(sql3, connection);
                cmd3.ExecuteNonQuery();
                Exit newform = new Exit(type);
                this.Hide();
                newform.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Parkingview newform = new Parkingview();
            this.Hide();
            newform.ShowDialog();
        }
    }
    }

