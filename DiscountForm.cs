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
    public partial class tblDiscountForm : Form
    {
        public tblDiscountForm()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm newForm = new HomeForm();
            newForm.ShowDialog();
        }

        private void discount_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.discount_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.guestDataSet);

        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'guestDataSet.Discount_Table' table. You can move, or remove it, as needed.
            this.discount_TableTableAdapter.Fill(this.guestDataSet.Discount_Table);

        }

        private void discount_TableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
