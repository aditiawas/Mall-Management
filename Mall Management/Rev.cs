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
    public partial class Rev : Form
    {
        int r;
        string id;
        public Rev(String rev,string i)
        {
            InitializeComponent();
            r = Convert.ToInt32(rev);
            id =i;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
        }

        private void Rev_Load(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql_search = "select * from shop where shopid='" + id + "'";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql_search, connection);
            DataTable dt = new DataTable();
            dataadapter.Fill(dt);
            textBox1.Text= dt.Rows[0][2].ToString();

            string sql = "select sum(salary) from emp where dept='"+id+"'";
            string sql1 = "update shop set rev='" + r + "' where shopid='" + id + "'";

            OleDbCommand cmd;
            cmd = new OleDbCommand(sql1, connection);
            cmd.ExecuteNonQuery();


            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sql, connection);
            DataTable dt1 = new DataTable();
            dataadapter1.Fill(dt1);
            textBox2.Text = dt1.Rows[0][0].ToString();

            int a =  Convert.ToInt32(dt.Rows[0][2]);
            int b = Convert.ToInt32(dt1.Rows[0][0]);
            a = r - a - b;

            textBox3.Text = a.ToString();



            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
