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
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update newform = new Update();
            this.Hide();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book newform = new Book();
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
