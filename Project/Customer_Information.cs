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
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Customer_Information : Form
    {

        public Customer_Information()
        {
            InitializeComponent();
        }

        public static int Stand_id;
        public int no_of_seats;
        public static void Get_Stand_id(Stand s)
        {
            Stand_id = s.Stand_id;
        }

        public bool IsValidEmail(string source) //for Email validation
        {

            bool i = new EmailAddressAttribute().IsValid(source);

            return i;
        }

        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{12})$").Success;
        }
        public int validation()
        {

            int flag = 0;
            if (txtName.Text == "")
            {
                ErrorProviderName.SetError(txtName, "Name can not be Empty");
                flag = 1;
            }
            if (!IsPhoneNumber(txt_Mobile.Text))
            {
                ErrorProviderName.SetError(txt_Mobile, "Enter number in +91 format");
                flag = 1;
            }


            if (!IsValidEmail(txt_Email.Text))
            {

                ErrorProviderName.SetError(txt_Email, "Enter a valid Email Id");
                flag = 1;
            }

            if (Seats.SelectedIndex == 0)
            {
                ErrorProviderName.SetError(Seats, "please choose number of seats");
                flag = 1;
            }
            if (txt_Id.Text == "")
            {
                ErrorProviderName.SetError(txt_Id, "ID proof can not be Empty");
                flag = 1;
            }

            return flag;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (validation() == 0)
            {
                ErrorProviderName.Clear();



                string connectionstring = "Data Source = NIK\\SQLEXPRESS ; Initial Catalog = stadium ; Integrated Security = SSPI ";
                SqlConnection connection = new SqlConnection(connectionstring);

                //data insertion in database
                StringBuilder strinsert = new StringBuilder();
                strinsert.AppendFormat("insert into customer values ('{0}','{1}','{2}',{3},'{4}')", txtName.Text, txt_Mobile.Text, txt_Email.Text, int.Parse(Seats.SelectedItem.ToString()), txt_Id.Text);
                SqlCommand cmd = new SqlCommand(strinsert.ToString(), connection);
                connection.Open();

                int RowAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("Seats booked successfully succesfully" + RowAffected.ToString());
                //updating no of seats
                //first selecting no of seats and then updating new no of seats


                StringBuilder strselect = new StringBuilder();
                strselect.AppendFormat("select no_of_seats from stand where stand_id = {0}", Stand_id);

                SqlCommand cmdselect = new SqlCommand(strselect.ToString(), connection);
                SqlDataReader reader = cmdselect.ExecuteReader();

                while (reader.Read())
                {
                    no_of_seats = int.Parse(reader["no_of_seats"].ToString());
                }
                //checking whether desired number of seats available
                if (no_of_seats < int.Parse(Seats.SelectedItem.ToString()))
                {
                    MessageBox.Show("Not enough enough seats available", "try another stand", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                connection.Close();

                connection.Open();

                StringBuilder strupdate = new StringBuilder();
                int var = no_of_seats - int.Parse(Seats.SelectedItem.ToString());
                txtName.Text = (no_of_seats).ToString();

                strupdate.AppendFormat("update stand set no_of_seats ={0} where stand_id = {1}", var, Stand_id);
                SqlCommand cmdupdate = new SqlCommand(strupdate.ToString(), connection);


                int ra = cmdupdate.ExecuteNonQuery();
                MessageBox.Show("stand updated" + ra.ToString());
            }
            else
            {
                MessageBox.Show("Enter Valid Data", " oops Something Went Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customer_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
