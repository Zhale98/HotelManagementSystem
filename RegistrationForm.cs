using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace HotelManagmentSystem
{
   
    public partial class tblRegistrationForm : Form
    {
        
        public tblRegistrationForm()
        {
            InitializeComponent();
            
            // TODO: This line of code loads data into the 'bDDataSet.Registration' table. You can move, or remove it, as needed.
            
        } 
        private void rectangleShape1_Click(object sender, EventArgs e)
        {
                            


        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm newForm = new HomeForm();
            newForm.ShowDialog();
        }

        private void mobileno_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            this.Validate();
            MessageBox.Show("Successfully registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'hotel_Managment_SystemDataSet.tblRegistration_Query' table. You can move, or remove it, as needed.
this.tblRegistration_QueryTableAdapter.Fill(this.hotel_Managment_SystemDataSet.tblRegistration_Query);
// TODO: This line of code loads data into the 'database2DataSet.tblRegistration' table. You can move, or remove it, as needed.
this.tblRegistrationTableAdapter.Fill(this.database2DataSet.tblRegistration);
            
            

        }

        private void registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDDataSet);

        }

        private void registrationBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        
        }
    }
}
