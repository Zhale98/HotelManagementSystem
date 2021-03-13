namespace HotelManagmentSystem
{
    partial class GuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gender2 = new System.Windows.Forms.ComboBox();
            this.contactno = new System.Windows.Forms.TextBox();
            this.emailadress2 = new System.Windows.Forms.TextBox();
            this.address2 = new System.Windows.Forms.TextBox();
            this.lastname2 = new System.Windows.Forms.TextBox();
            this.middlename2 = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.Label();
            this.guestname = new System.Windows.Forms.Label();
            this.emailaddress = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.middlename = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.hotel_Managment_SystemDataSet = new HotelManagmentSystem.Hotel_Managment_SystemDataSet();
            this.tblGuestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblGuestTableAdapter = new HotelManagmentSystem.Hotel_Managment_SystemDataSetTableAdapters.tblGuestTableAdapter();
            this.tableAdapterManager = new HotelManagmentSystem.Hotel_Managment_SystemDataSetTableAdapters.TableAdapterManager();
            this.tblGuestBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tblGuestBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Managment_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGuestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGuestBindingNavigator)).BeginInit();
            this.tblGuestBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.gender2);
            this.panel2.Controls.Add(this.contactno);
            this.panel2.Controls.Add(this.emailadress2);
            this.panel2.Controls.Add(this.address2);
            this.panel2.Controls.Add(this.lastname2);
            this.panel2.Controls.Add(this.middlename2);
            this.panel2.Controls.Add(this.firstname);
            this.panel2.Controls.Add(this.adress);
            this.panel2.Controls.Add(this.guestname);
            this.panel2.Controls.Add(this.emailaddress);
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.lastname);
            this.panel2.Controls.Add(this.middlename);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.shapeContainer1);
            this.panel2.Location = new System.Drawing.Point(0, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 197);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(233, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 33);
            this.button1.TabIndex = 30;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gender2
            // 
            this.gender2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.gender2.FormattingEnabled = true;
            this.gender2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender2.Location = new System.Drawing.Point(454, 255);
            this.gender2.Name = "gender2";
            this.gender2.Size = new System.Drawing.Size(121, 25);
            this.gender2.TabIndex = 24;
            // 
            // contactno
            // 
            this.contactno.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactno.Location = new System.Drawing.Point(132, 258);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(186, 25);
            this.contactno.TabIndex = 19;
            this.contactno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailadress2
            // 
            this.emailadress2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailadress2.Location = new System.Drawing.Point(132, 218);
            this.emailadress2.Name = "emailadress2";
            this.emailadress2.Size = new System.Drawing.Size(186, 25);
            this.emailadress2.TabIndex = 20;
            // 
            // address2
            // 
            this.address2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address2.Location = new System.Drawing.Point(132, 176);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(569, 25);
            this.address2.TabIndex = 21;
            // 
            // lastname2
            // 
            this.lastname2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname2.Location = new System.Drawing.Point(132, 141);
            this.lastname2.Name = "lastname2";
            this.lastname2.Size = new System.Drawing.Size(186, 25);
            this.lastname2.TabIndex = 22;
            // 
            // middlename2
            // 
            this.middlename2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlename2.Location = new System.Drawing.Point(132, 103);
            this.middlename2.Name = "middlename2";
            this.middlename2.Size = new System.Drawing.Size(186, 25);
            this.middlename2.TabIndex = 23;
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstname.Location = new System.Drawing.Point(132, 64);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(186, 25);
            this.firstname.TabIndex = 19;
            this.firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress.Location = new System.Drawing.Point(59, 180);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(78, 19);
            this.adress.TabIndex = 5;
            this.adress.Text = "Address :-";
            // 
            // guestname
            // 
            this.guestname.AutoSize = true;
            this.guestname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestname.Location = new System.Drawing.Point(39, 65);
            this.guestname.Name = "guestname";
            this.guestname.Size = new System.Drawing.Size(98, 19);
            this.guestname.TabIndex = 5;
            this.guestname.Text = "First Name :-";
            // 
            // emailaddress
            // 
            this.emailaddress.AutoSize = true;
            this.emailaddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailaddress.Location = new System.Drawing.Point(18, 219);
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.Size = new System.Drawing.Size(119, 19);
            this.emailaddress.TabIndex = 6;
            this.emailaddress.Text = "Email Address :-";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.Location = new System.Drawing.Point(374, 258);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(73, 19);
            this.gender.TabIndex = 9;
            this.gender.Text = "Gender :-";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address.Location = new System.Drawing.Point(34, 258);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(103, 19);
            this.address.TabIndex = 8;
            this.address.Text = "Contact No. :-";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastname.Location = new System.Drawing.Point(40, 141);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(97, 19);
            this.lastname.TabIndex = 7;
            this.lastname.Text = "Last Name :-";
            // 
            // middlename
            // 
            this.middlename.AutoSize = true;
            this.middlename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlename.Location = new System.Drawing.Point(22, 104);
            this.middlename.Name = "middlename";
            this.middlename.Size = new System.Drawing.Size(115, 19);
            this.middlename.TabIndex = 6;
            this.middlename.Text = "Middle Name :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(22, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Guest";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guest";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3,
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(540, 197);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.CornerRadius = 5;
            this.rectangleShape3.Location = new System.Drawing.Point(6, 348);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(707, 51);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.CornerRadius = 10;
            this.rectangleShape2.Location = new System.Drawing.Point(13, 10);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(66, 30);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.CornerRadius = 5;
            this.rectangleShape1.Location = new System.Drawing.Point(-112, 166);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(596, 173);
            this.rectangleShape1.Click += new System.EventHandler(this.rectangleShape1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 36);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(9, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(30, 29);
            this.btnback.TabIndex = 30;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // hotel_Managment_SystemDataSet
            // 
            this.hotel_Managment_SystemDataSet.DataSetName = "Hotel_Managment_SystemDataSet";
            this.hotel_Managment_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblGuestBindingSource
            // 
            this.tblGuestBindingSource.DataMember = "tblGuest";
            this.tblGuestBindingSource.DataSource = this.hotel_Managment_SystemDataSet;
            // 
            // tblGuestTableAdapter
            // 
            this.tblGuestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblDiscountTableAdapter = null;
            this.tableAdapterManager.tblGuestTableAdapter = this.tblGuestTableAdapter;
            this.tableAdapterManager.tblRegistrationTableAdapter = null;
            this.tableAdapterManager.tblRoomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelManagmentSystem.Hotel_Managment_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblGuestBindingNavigator
            // 
            this.tblGuestBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblGuestBindingNavigator.BindingSource = this.tblGuestBindingSource;
            this.tblGuestBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblGuestBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblGuestBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblGuestBindingNavigatorSaveItem});
            this.tblGuestBindingNavigator.Location = new System.Drawing.Point(0, 36);
            this.tblGuestBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblGuestBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblGuestBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblGuestBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblGuestBindingNavigator.Name = "tblGuestBindingNavigator";
            this.tblGuestBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblGuestBindingNavigator.Size = new System.Drawing.Size(727, 25);
            this.tblGuestBindingNavigator.TabIndex = 4;
            this.tblGuestBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // tblGuestBindingNavigatorSaveItem
            // 
            this.tblGuestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblGuestBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblGuestBindingNavigatorSaveItem.Image")));
            this.tblGuestBindingNavigatorSaveItem.Name = "tblGuestBindingNavigatorSaveItem";
            this.tblGuestBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tblGuestBindingNavigatorSaveItem.Text = "Save Data";
            this.tblGuestBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblGuestBindingNavigatorSaveItem_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 469);
            this.Controls.Add(this.tblGuestBindingNavigator);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_Managment_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGuestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGuestBindingNavigator)).EndInit();
            this.tblGuestBindingNavigator.ResumeLayout(false);
            this.tblGuestBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label guestname;
        private System.Windows.Forms.Label emailaddress;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label middlename;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox contactno;
        private System.Windows.Forms.TextBox emailadress2;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.TextBox lastname2;
        private System.Windows.Forms.TextBox middlename2;
        private System.Windows.Forms.ComboBox gender2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnback;
        private Hotel_Managment_SystemDataSet hotel_Managment_SystemDataSet;
        private System.Windows.Forms.BindingSource tblGuestBindingSource;
        private Hotel_Managment_SystemDataSetTableAdapters.tblGuestTableAdapter tblGuestTableAdapter;
        private Hotel_Managment_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblGuestBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblGuestBindingNavigatorSaveItem;
    }
}