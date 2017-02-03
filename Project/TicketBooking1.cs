using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class TicketBooking1 : Form
    {
        public TicketBooking1()
        {
            InitializeComponent();
        }
        private void TicketBooking1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Stand1_Click(object sender, EventArgs e)
        {
            Stand s = Stand.Initialising_Stand(0);
            DialogResult result = MessageBox.Show("Are You Sure", "Confirmatin", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Hide();
            if (result == DialogResult.OK)
            {
                Customer_Information.Get_Stand_id(s);

                Stand_Level sl = new Stand_Level();
                sl.When_form_Load(s);

                sl.Show();
            }
            else
            {
                this.Show();
            }


        }

        private void Stand5_Click(object sender, EventArgs e)
        {

        }

        private void Stand4_Click(object sender, EventArgs e)
        {

        }

    }
}
