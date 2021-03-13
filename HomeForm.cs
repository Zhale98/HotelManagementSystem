using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagmentSystem
{
    public partial class HomeForm : Form
    {
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);

        }
        public HomeForm()
        {
            InitializeComponent();
        }
        private void checkin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckInForm1 newForm = new CheckInForm1();
            newForm.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckInListForm newForm = new CheckInListForm();
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestForm newForm = new GuestForm();
            newForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestListForm newForm = new GuestListForm();
            newForm.ShowDialog();
        }
 private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            tblRoomForm newForm = new tblRoomForm();
            newForm.ShowDialog();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomListForm newForm = new RoomListForm();
            newForm.ShowDialog();
        }
        private void checkout_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOutForm newForm = new CheckOutForm();
            newForm.ShowDialog();
        }
        private void checkoutlist_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckOutForm newForm = new CheckOutForm();
            newForm.ShowDialog();
        }
        private void discount_Click(object sender, EventArgs e)
        {
            this.Hide();
            tblDiscountForm newForm = new tblDiscountForm();
            newForm.ShowDialog();
        }
        private void registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            tblRegistrationForm newForm = new tblRegistrationForm();
            newForm.ShowDialog();
        }
      private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
