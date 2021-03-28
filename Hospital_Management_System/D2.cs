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
    public partial class D2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Nikhilesh Sinha\Documents\Visual Studio 2012\Projects\Hospital_Management_System\Hospital_Management_System\HMS.mdf;Integrated Security=True");
        public D2()
        {
            InitializeComponent();
            display();
            DateTime now = DateTime.Now;
            l4.Text = now.ToString("F"); 
        }

        private void Click_back(object sender, EventArgs e)
        {

            D1 ob = new D1();
            ob.Show();
            this.Hide();
        }

        public void display()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Patitent_info ";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            dg1.DataSource = dt1;
            con.Close();
        }

        private void Click_del(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "delete from Patitent_info where Patient_name = @nm";
            cmd.Parameters.AddWithValue("@nm", t1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Entities has been sucessfully deleted !!!! ");
            con.Close();
            display();
        }

        private void Click_ref(object sender, EventArgs e)
        {
            D2 obb = new D2();
            obb.Show();
            this.Hide();
        }
    }
}
