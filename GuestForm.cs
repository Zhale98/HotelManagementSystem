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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm newForm = new HomeForm();
            newForm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_Managment_SystemDataSet.tblGuest' table. You can move, or remove it, as needed.
            this.tblGuestTableAdapter.Fill(this.hotel_Managment_SystemDataSet.tblGuest);
        }
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

            private void tblGuestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
            {
                this.Validate();
                this.tblGuestBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hotel_Managment_SystemDataSet);

            }

        }
    }

