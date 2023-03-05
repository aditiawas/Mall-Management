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
    public partial class Shopkeeper : Form
    {
        String id;
        public Shopkeeper(String i)
        {
            InitializeComponent();
            id = i;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmp newform = new AddEmp(id);
            newform.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DelEmp newform = new DelEmp(id);
            newform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                MessageBox.Show("Enter the revenue please");
            else
            {
                Rev newform = new Rev(textBox1.Text, id);
                newform.ShowDialog();
            }
        }

        private void Shopkeeper_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "select * from emp where dept='" + id + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "emp");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "emp";
            dataGridView1.Refresh();
            connection.Close();



            if(id.Equals("80"))
            {
                button4.Hide();
                textBox1.Hide();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "select * from emp where dept='" + id + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "emp");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "emp";
            dataGridView1.Refresh();
            connection.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
