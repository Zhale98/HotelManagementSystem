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
    public partial class CheckInForm1 : Form
    {
        public CheckInForm1()
        {
            InitializeComponent();
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm newForm = new HomeForm();
            newForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CheckInForm1_Load(object sender, EventArgs e)
        {}
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

        }
    }

