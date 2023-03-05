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
    public partial class Adminview : Form
    {
        public Adminview()
        {
            InitializeComponent();
        }

        private void Adminview_Load(object sender, EventArgs e)
        {

            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            string sql = "select * from shop";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "shop");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "shop";
            dataGridView1.Refresh();


            string sql1 = "select sum(rent) from shop";
            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sql1, connection);
            DataTable dt1 = new DataTable();
            dataadapter1.Fill(dt1);

            String sql2 = "select rev from shop where shopid='80'";
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter(sql2, connection);
            DataTable dt2 = new DataTable();
            dataadapter2.Fill(dt2);
            int ans = Convert.ToInt32(dt1.Rows[0][0])+ Convert.ToInt32(dt2.Rows[0][0]);
            textBox1.Text = ans.ToString();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = "Provider=OraOLEDB.Oracle;Data Source=orcl;User Id=system;Password=orcl;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            connection.Open();
            DateTime ob = DateTime.Now;
            ob=ob.AddMonths(-1);
            string a = ob.ToString().Substring(3,6);


            string sql = "select * from shop";
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dataadapter.Fill(ds, "shop");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "shop";
            dataGridView1.Refresh();
            string sql1 = "select sum(rent) from shop";
            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter(sql1, connection);
            DataTable dt1 = new DataTable();
            dataadapter1.Fill(dt1);

            string sql5 = "select rev from shop";
            OleDbDataAdapter dataadapter5 = new OleDbDataAdapter(sql5, connection);
            DataTable dt2 = new DataTable();
            dataadapter5.Fill(dt2);

            if (DateTime.Now.ToString().Substring(0,2).Equals("01"))
            {
                string sql4 = "insert into revhistory values('"+a+"','"+ (Convert.ToInt32(dt1.Rows[0][0]) + Convert.ToInt32(dt2.Rows[0][0])) + "','"+ dt2.Rows[0][0].ToString() + "','"+ dt2.Rows[2][0].ToString() + "','"+ dt2.Rows[1][0].ToString() + "','"+ dt2.Rows[3][0].ToString() + "')";
                OleDbCommand cmd4 = new OleDbCommand(sql4, connection);
                cmd4.ExecuteNonQuery();
                string sql3 = "update shop set rev=0";
                OleDbCommand cmd3 = new OleDbCommand(sql3, connection);
                cmd3.ExecuteNonQuery();
                Adminview newform = new Adminview();
                this.Hide();
                newform.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("This is not the first day of the month");
            }
        }
    }
}
