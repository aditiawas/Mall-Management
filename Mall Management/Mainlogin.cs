using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Login
{
    public partial class Mainlogin : Form
    {
        public Mainlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean isExist = false;
            String Password = "";
            string sql = "select * from adlogin where empid='" + textBox1.Text + "'";
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand oledbcmd = new OleDbCommand(sql, connection);
            OleDbDataReader sdr = oledbcmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(1);
                isExist = true;
            }
            connection.Close();
            String x = CalculateMD5Hash(textBox2.Text);
            if (isExist)
            {
                if (Password.Equals(x))
                {
                    MessageBox.Show("Hello Admin");
                    Adminview newform = new Adminview();
                    this.Hide();
                    newform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong credentials");
                }
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
            /*
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
             
            string sql_search = "select count(*) from adlogin where empid='" + textBox1.Text + "' and pass='"+textBox2.Text+"'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);

            DataTable dt = new DataTable();
            dataadapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Hello Admin");
                Adminview newform = new Adminview();
                this.Hide();
                newform.ShowDialog();
            }
            else
                MessageBox.Show("Wrong credentials");
            connection.Close();
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Boolean isExist = false;
            String Password="";
            string sql = "select * from shoplogin where shopid='" + textBox1.Text+"'";
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            OleDbCommand oledbcmd = new OleDbCommand(sql, connection);
            OleDbDataReader sdr = oledbcmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(1);
                isExist = true;
            }
            connection.Close();
            String x = CalculateMD5Hash(textBox2.Text);
            if (isExist)
            {
                if (Password.Equals(x))
                {
                    MessageBox.Show("You have been logged in");
                    Shopkeeper newform = new Shopkeeper(textBox1.Text);
                    this.Hide();
                    newform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong credentials");
                }
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }
                /*


                  string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
                  OleDbConnection connection = new OleDbConnection(connetionString);
                  connection.Open();

                  string sql_search = "select count(*) from shoplogin where shopid='" + textBox1.Text + "' and pass='" + textBox2.Text + "'";
                  OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);

                  DataTable dt = new DataTable();
                  dataadapter.Fill(dt);

                  if (dt.Rows[0][0].ToString() == "1")
                  {
                      MessageBox.Show("You have been logged in");
                      Shopkeeper newform = new Shopkeeper(textBox1.Text);
                      this.Hide();
                      newform.ShowDialog();
                  }
                  else
                      MessageBox.Show("Wrong credentials");
                  connection.Close();
                  */
            

        private void button2_Click(object sender, EventArgs e)
        {


           
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            String x = CalculateMD5Hash(textBox2.Text);
            string sql_search = "select count(*) from emplogin where empid='" + textBox1.Text + "' and pass='" + x + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                string sql1 = "select name from emp where empid = '" + textBox1.Text + "'";
                OleDbDataAdapter dataadapter2 = new OleDbDataAdapter(sql1, connection);
                DataTable dt2 = new DataTable();
                dataadapter2.Fill(dt2);
                MessageBox.Show("Hello "+ dt2.Rows[0][0].ToString());
                string sql="Select type from emplogin where empid = '" + textBox1.Text + "' and pass = '" + x + "'";
                OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sql, connection);
                DataTable dt1 = new DataTable();
                dataadapter1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "Movie")
                {
                   Movie newform = new Movie();
                    this.Hide();
                    newform.ShowDialog();
                }
                if (dt1.Rows[0][0].ToString() == "Parking")
                {
                    Parkingview newform = new Parkingview();
                    this.Hide();
                    newform.ShowDialog();
                }
                if (dt1.Rows[0][0].ToString() == "Food")
                {
                    FoodCourt newform = new FoodCourt();
                    this.Hide();
                    newform.ShowDialog();
                }
                if (dt1.Rows[0][0].ToString() == "Arcade")
                {
                    Arcade newform = new Arcade();
                    this.Hide();
                    newform.ShowDialog();
                }      
            }
            else
                MessageBox.Show("Wrong credentials");
            connection.Close();
        }

       
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    
}
 