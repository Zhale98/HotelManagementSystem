using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlTypes;
namespace HotelManagmentSystem
{
  
    public partial class LoginForms : Form
    {
       
    
        public LoginForms()
        {
            InitializeComponent();
            
        }

        private void LoginForms_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            this.Hide();
            HomeForm newForm = new HomeForm();
            newForm.ShowDialog();
    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    if (textBox2Username.Text == "admin" & textBox3.Text == "admin")
            {
                this.Hide();
                LoginForms newForm = new LoginForms();
                newForm.StartPosition = FormStartPosition.CenterScreen;
                newForm.ShowDialog();
            }
            else MessageBox.Show("Wrong username or password.");
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {

        }

        }
    }

