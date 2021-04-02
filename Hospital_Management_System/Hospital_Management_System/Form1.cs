using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void Click_Doctor(object sender, EventArgs e)
        {
            D1 ob = new D1();
            ob.Show();
            this.Hide();
        }

        private void Click_Patient(object sender, EventArgs e)
        {
            P1 ob = new P1();
            ob.Show();
            this.Hide();
        }

        private void Click_Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Click_About(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
            this.Hide();
        }

        private void Click_cont(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry you can't contact us !!!!");
        }
    }
}
