namespace HotelManagmentSystem
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registration = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleshape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.roomlist = new System.Windows.Forms.Button();
            this.guestlist = new System.Windows.Forms.Button();
            this.checkinlist = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.discount = new System.Windows.Forms.Button();
            this.room = new System.Windows.Forms.Button();
            this.guest = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.checkin = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkoutlist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.registration);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 49);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // registration
            // 
            this.registration.Image = ((System.Drawing.Image)(resources.GetObject("registration.Image")));
            this.registration.Location = new System.Drawing.Point(857, 3);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(37, 34);
            this.registration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registration.TabIndex = 7;
            this.registration.TabStop = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 391);
            this.panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Location = new System.Drawing.Point(347, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 35);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Management System";
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(900, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 34);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 6;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleshape2});
            this.shapeContainer1.Size = new System.Drawing.Size(938, 559);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleshape2
            // 
            this.rectangleshape2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rectangleshape2.Location = new System.Drawing.Point(-2, 50);
            this.rectangleshape2.Name = "rectangleshape2";
            this.rectangleshape2.Size = new System.Drawing.Size(219, 507);
            // 
            // roomlist
            // 
            this.roomlist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.roomlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomlist.Image = ((System.Drawing.Image)(resources.GetObject("roomlist.Image")));
            this.roomlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomlist.Location = new System.Drawing.Point(15, 393);
            this.roomlist.Name = "roomlist";
            this.roomlist.Size = new System.Drawing.Size(188, 42);
            this.roomlist.TabIndex = 13;
            this.roomlist.Text = "Room List";
            this.roomlist.UseVisualStyleBackColor = false;
            this.roomlist.Click += new System.EventHandler(this.button7_Click);
            // 
            // guestlist
            // 
            this.guestlist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guestlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guestlist.Image = ((System.Drawing.Image)(resources.GetObject("guestlist.Image")));
            this.guestlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guestlist.Location = new System.Drawing.Point(15, 297);
            this.guestlist.Name = "guestlist";
            this.guestlist.Size = new System.Drawing.Size(188, 42);
            this.guestlist.TabIndex = 12;
            this.guestlist.Text = "Guest List";
            this.guestlist.UseVisualStyleBackColor = false;
            this.guestlist.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkinlist
            // 
            this.checkinlist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkinlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkinlist.Image = ((System.Drawing.Image)(resources.GetObject("checkinlist.Image")));
            this.checkinlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkinlist.Location = new System.Drawing.Point(12, 113);
            this.checkinlist.Name = "checkinlist";
            this.checkinlist.Size = new System.Drawing.Size(188, 42);
            this.checkinlist.TabIndex = 11;
            this.checkinlist.Text = "Check In List";
            this.checkinlist.UseVisualStyleBackColor = false;
            this.checkinlist.Click += new System.EventHandler(this.button6_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(15, 489);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(188, 42);
            this.logout.TabIndex = 10;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = false;
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.discount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.discount.Image = ((System.Drawing.Image)(resources.GetObject("discount.Image")));
            this.discount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.discount.Location = new System.Drawing.Point(15, 441);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(188, 42);
            this.discount.TabIndex = 8;
            this.discount.Text = "Discount";
            this.discount.UseVisualStyleBackColor = false;
            this.discount.Click += new System.EventHandler(this.discount_Click);
            // 
            // room
            // 
            this.room.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room.Image = ((System.Drawing.Image)(resources.GetObject("room.Image")));
            this.room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.room.Location = new System.Drawing.Point(15, 345);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(188, 42);
            this.room.TabIndex = 7;
            this.room.Text = "Room";
            this.room.UseVisualStyleBackColor = false;
            this.room.Click += new System.EventHandler(this.button4_Click);
            // 
            // guest
            // 
            this.guest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guest.Image = ((System.Drawing.Image)(resources.GetObject("guest.Image")));
            this.guest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guest.Location = new System.Drawing.Point(15, 252);
            this.guest.Name = "guest";
            this.guest.Size = new System.Drawing.Size(188, 39);
            this.guest.TabIndex = 6;
            this.guest.Text = "Guest";
            this.guest.UseVisualStyleBackColor = false;
            this.guest.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkout
            // 
            this.checkout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkout.Image = ((System.Drawing.Image)(resources.GetObject("checkout.Image")));
            this.checkout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkout.Location = new System.Drawing.Point(15, 161);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(188, 40);
            this.checkout.TabIndex = 5;
            this.checkout.Text = "Check Out";
            this.checkout.UseVisualStyleBackColor = false;
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // checkin
            // 
            this.checkin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkin.Image = ((System.Drawing.Image)(resources.GetObject("checkin.Image")));
            this.checkin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkin.Location = new System.Drawing.Point(12, 67);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(188, 40);
            this.checkin.TabIndex = 4;
            this.checkin.Text = "Check In";
            this.checkin.UseVisualStyleBackColor = false;
            this.checkin.Click += new System.EventHandler(this.checkin_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(219, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 509);
            this.panel3.TabIndex = 3;
            // 
            // checkoutlist
            // 
            this.checkoutlist.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkoutlist.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkoutlist.Image = ((System.Drawing.Image)(resources.GetObject("checkoutlist.Image")));
            this.checkoutlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutlist.Location = new System.Drawing.Point(15, 207);
            this.checkoutlist.Name = "checkoutlist";
            this.checkoutlist.Size = new System.Drawing.Size(188, 39);
            this.checkoutlist.TabIndex = 14;
            this.checkoutlist.Text = "Check Out List";
            this.checkoutlist.UseVisualStyleBackColor = false;
            this.checkoutlist.Click += new System.EventHandler(this.checkoutlist_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 559);
            this.Controls.Add(this.checkoutlist);
            this.Controls.Add(this.roomlist);
            this.Controls.Add(this.guestlist);
            this.Controls.Add(this.checkinlist);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.room);
            this.Controls.Add(this.guest);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.Button guest;
        private System.Windows.Forms.Button room;
        private System.Windows.Forms.Button discount;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleshape2;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button checkinlist;
        private System.Windows.Forms.Button guestlist;
        private System.Windows.Forms.Button roomlist;
        private System.Windows.Forms.Button checkoutlist;
        private System.Windows.Forms.PictureBox registration;
    }
}