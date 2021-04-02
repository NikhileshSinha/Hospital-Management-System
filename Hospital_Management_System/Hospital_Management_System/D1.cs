using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class D1 : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.HMSConnectionString);
        public D1()
        {
            InitializeComponent();
        }

        private void Click_Back(object sender, EventArgs e)
        {
            Welcome_Page ob = new Welcome_Page();
            ob.Show();
            this.Hide();
        }

        private void Click_Input(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Doctors_Password where UserNm = @un and Pswd = @psd", con);
            cmd.Parameters.AddWithValue("@un", t1.Text);
            cmd.Parameters.AddWithValue("@psd", t2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int i = cmd.ExecuteNonQuery();

            if (dt.Rows.Count > 0)
            {
                D2 ob = new D2();
                ob.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter Correct Password");
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
