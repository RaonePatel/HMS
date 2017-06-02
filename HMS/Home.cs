using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Data.SqlClient;
using System.Threading;
namespace HMS
{
    public partial class Home : Form
    {
        
        Thread th;
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["HMS"].ToString());
       
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
            lbdate.Text = DateTime.Now.ToLongDateString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            LBHEAD.Location = new Point(LBHEAD.Location.X + 10, LBHEAD.Location.Y);
            if (LBHEAD.Location.X > this.Width)
            {
                LBHEAD.Location = new Point(0 - LBHEAD.Width, LBHEAD.Location.Y);
            }

            timer1.Start();
            lbtime.Text = DateTime.Now.ToLongTimeString();
        }

  
       
        private void opennewform(Object obj)
        {
            Application.Run(new Welcome());
        }

        private void rrdexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rrdlogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            String uname = "";
            String upass = "";
            conn.Open();
            String query = "select username,password from Admin where Username=@user and Password=@Pass";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("user", unameadmin.Text);
            cmd.Parameters.AddWithValue("Pass", passadmin.Text);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                uname = rdr["Username"].ToString().Replace(" ",String.Empty);
                upass = rdr["Password"].ToString().Replace(" ",String.Empty);
                
            }

            if (uname == unameadmin.Text && upass == passadmin.Text)
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            conn.Close();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
