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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Click_back(object sender, EventArgs e)
        {

            Welcome_Page ob = new Welcome_Page();
            ob.Show();
            this.Hide();
        }
    }
}
