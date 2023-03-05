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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "select audino,moviename from audi,movie where movid=movieid";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "audi");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "audi";
            dataGridView1.Refresh();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Seating newform = new Seating("audi1", "t12");
                this.Hide();
                newform.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                Seating newform = new Seating("audi1", "t3");
                this.Hide();
                newform.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                Seating newform = new Seating("audi1", "t6");
                this.Hide();
                newform.ShowDialog();
            }
            else if (radioButton4.Checked)
            {
                Seating newform = new Seating("audi1", "t9");
                this.Hide();
                newform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a time slot first");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Seating newform = new Seating("audi2", "t12");
                this.Hide();
                newform.ShowDialog();
            }
            else if (radioButton2.Checked)
            {
                Seating newform = new Seating("audi2", "t3");
                this.Hide();
                newform.ShowDialog();
            }
            else if (radioButton3.Checked)
            {
                Seating newform = new Seating("audi2", "t6");
                this.Hide();
                newform.ShowDialog();
            }
            else if (radioButton4.Checked)
            {
                Seating newform = new Seating("audi2", "t9");
                this.Hide();
                newform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a time slot first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movie newform = new Movie();
            this.Hide();
            newform.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
