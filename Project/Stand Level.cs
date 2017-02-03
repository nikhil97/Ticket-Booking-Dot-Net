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

namespace Project
{
    public partial class Stand_Level : Form
    {
        public Stand_Level()
        {
            InitializeComponent();
        }
        public int Stand_Id;
        public string Stand_Name;
        public int Seat_Left;
        public void When_form_Load(Stand S)
        {
            Stand_Id = S.Stand_id;
            Stand_Name = S.name;

        }


        private void Stand_Level_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source  = NIK\\SQLEXPRESS ;Initial Catalog = Stadium ;Integrated Security = SSPI";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select no_of_seats from stand where stand_id = '" + Stand_Id + "'", connection);
            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SeatsLeft.Text = reader["no_of_seats"].ToString();
            }
            StandName.Text = Stand_Name;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Information ci = new Customer_Information();

            this.Hide();
            ci.Show();

        }

        private void Stand_Level_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicketBooking1 t = new TicketBooking1();
            this.Hide();
            t.Show();
        }

    }
}
