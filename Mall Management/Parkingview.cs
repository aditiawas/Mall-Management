using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Parkingview : Form
    {
        public Parkingview()
        {
            InitializeComponent();
        }

        private void Parkingview_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t;
            if (radioButton1.Checked)
                t = "carpark";
            else
                t = "bikepark";

           Entry newform = new Entry(t);
            this.Hide();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t;
            if (radioButton1.Checked)
                t = "carpark";
            else
                t = "bikepark";
            Exit newform = new Exit(t);
            this.Hide();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mainlogin newform = new Mainlogin();
            this.Hide();
            newform.ShowDialog();
        }
    }
}
