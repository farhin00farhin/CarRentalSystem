namespace QualityVehicleForms
{
    partial class WelcomeEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeEmployee));
            this.lblHello = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageRentals = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbEmployee = new System.Windows.Forms.PictureBox();
            this.btnEditProfileEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.BackColor = System.Drawing.Color.Transparent;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHello.Location = new System.Drawing.Point(12, 185);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(76, 29);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do today?";
            // 
            // btnManageStock
            // 
            this.btnManageStock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageStock.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManageStock.Location = new System.Drawing.Point(149, 352);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(133, 75);
            this.btnManageStock.TabIndex = 2;
            this.btnManageStock.Text = "Manage Stock";
            this.btnManageStock.UseVisualStyleBackColor = false;
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);
            // 
            // btnManageCustomers
            // 
            this.btnManageCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageCustomers.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManageCustomers.Location = new System.Drawing.Point(345, 352);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(163, 75);
            this.btnManageCustomers.TabIndex = 3;
            this.btnManageCustomers.Text = "Manage Customers and Employees";
            this.btnManageCustomers.UseVisualStyleBackColor = false;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            // btnManageRentals
            // 
            this.btnManageRentals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageRentals.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRentals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnManageRentals.Location = new System.Drawing.Point(573, 352);
            this.btnManageRentals.Name = "btnManageRentals";
            this.btnManageRentals.Size = new System.Drawing.Size(136, 75);
            this.btnManageRentals.TabIndex = 4;
            this.btnManageRentals.Text = "Manage Rentals";
            this.btnManageRentals.UseVisualStyleBackColor = false;
            this.btnManageRentals.Click += new System.EventHandler(this.btnManageRentals_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(821, 182);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackColor = System.Drawing.Color.White;
            this.pbEmployee.Image = ((System.Drawing.Image)(resources.GetObject("pbEmployee.Image")));
            this.pbEmployee.InitialImage = null;
            this.pbEmployee.Location = new System.Drawing.Point(359, 127);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.Size = new System.Drawing.Size(140, 95);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEmployee.TabIndex = 6;
            this.pbEmployee.TabStop = false;
            // 
            // btnEditProfileEmployee
            // 
            this.btnEditProfileEmployee.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEditProfileEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfileEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditProfileEmployee.Location = new System.Drawing.Point(359, 199);
            this.btnEditProfileEmployee.Name = "btnEditProfileEmployee";
            this.btnEditProfileEmployee.Size = new System.Drawing.Size(140, 23);
            this.btnEditProfileEmployee.TabIndex = 7;
            this.btnEditProfileEmployee.Text = "Edit";
            this.btnEditProfileEmployee.UseVisualStyleBackColor = false;
            this.btnEditProfileEmployee.Click += new System.EventHandler(this.btnEditProfileEmployee_Click);
            // 
            // WelcomeEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 524);
            this.Controls.Add(this.btnEditProfileEmployee);
            this.Controls.Add(this.pbEmployee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManageRentals);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WelcomeEmployee";
            this.Text = "Welcome - Quality Vehicle Cars";
            this.Activated += new System.EventHandler(this.WelcomeStaff_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeStaff_FormClosed);
            this.Load += new System.EventHandler(this.WelcomeStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageRentals;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbEmployee;
        private System.Windows.Forms.Button btnEditProfileEmployee;
    }
}