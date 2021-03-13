using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace HotelManagmentSystem
{
    public partial class SplashScreenForm : Form
    {




        public SplashScreenForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
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
    

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginForms(object sender, MouseEventArgs e)
        {
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {





        }

        private void Click_Click(object sender, EventArgs e)
        {

          
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForms newForm = new LoginForms();
            newForm.ShowDialog();

        }
    }
}

