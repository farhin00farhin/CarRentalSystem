namespace QualityVehicleForms
{
    partial class Rent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rent));
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnOldCustomer = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAddCustomer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpLicenceExpiryDateCustomer = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirthCustomer = new System.Windows.Forms.DateTimePicker();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelephoneCustomer = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddressCustomer = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtLicenseNumberCustomer = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlExistingCustomers = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tvCustomer = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.tvCars = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRentDefault = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAddCustomer.SuspendLayout();
            this.pnlExistingCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnlRentDefault.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.PowderBlue;
            this.btnNewCustomer.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(105, 13);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(153, 68);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnOldCustomer
            // 
            this.btnOldCustomer.BackColor = System.Drawing.Color.PowderBlue;
            this.btnOldCustomer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOldCustomer.Location = new System.Drawing.Point(361, 13);
            this.btnOldCustomer.Name = "btnOldCustomer";
            this.btnOldCustomer.Size = new System.Drawing.Size(153, 69);
            this.btnOldCustomer.TabIndex = 1;
            this.btnOldCustomer.Text = "Old Customer";
            this.btnOldCustomer.UseVisualStyleBackColor = false;
            this.btnOldCustomer.Click += new System.EventHandler(this.btnOldCustomer_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlAddCustomer);
            this.splitContainer1.Panel1.Controls.Add(this.pnlExistingCustomers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(676, 390);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlAddCustomer
            // 
            this.pnlAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddCustomer.BackgroundImage")));
            this.pnlAddCustomer.Controls.Add(this.label1);
            this.pnlAddCustomer.Controls.Add(this.dtpLicenceExpiryDateCustomer);
            this.pnlAddCustomer.Controls.Add(this.dtpDateOfBirthCustomer);
            this.pnlAddCustomer.Controls.Add(this.txtNameCustomer);
            this.pnlAddCustomer.Controls.Add(this.label16);
            this.pnlAddCustomer.Controls.Add(this.txtTelephoneCustomer);
            this.pnlAddCustomer.Controls.Add(this.label18);
            this.pnlAddCustomer.Controls.Add(this.label19);
            this.pnlAddCustomer.Controls.Add(this.txtAddressCustomer);
            this.pnlAddCustomer.Controls.Add(this.label20);
            this.pnlAddCustomer.Controls.Add(this.label21);
            this.pnlAddCustomer.Controls.Add(this.txtLicenseNumberCustomer);
            this.pnlAddCustomer.Controls.Add(this.label22);
            this.pnlAddCustomer.Controls.Add(this.txtIdCustomer);
            this.pnlAddCustomer.Controls.Add(this.label23);
            this.pnlAddCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlAddCustomer.Name = "pnlAddCustomer";
            this.pnlAddCustomer.Size = new System.Drawing.Size(264, 390);
            this.pnlAddCustomer.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers";
            // 
            // dtpLicenceExpiryDateCustomer
            // 
            this.dtpLicenceExpiryDateCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLicenceExpiryDateCustomer.Location = new System.Drawing.Point(158, 160);
            this.dtpLicenceExpiryDateCustomer.Name = "dtpLicenceExpiryDateCustomer";
            this.dtpLicenceExpiryDateCustomer.Size = new System.Drawing.Size(100, 20);
            this.dtpLicenceExpiryDateCustomer.TabIndex = 60;
            // 
            // dtpDateOfBirthCustomer
            // 
            this.dtpDateOfBirthCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirthCustomer.Location = new System.Drawing.Point(158, 212);
            this.dtpDateOfBirthCustomer.Name = "dtpDateOfBirthCustomer";
            this.dtpDateOfBirthCustomer.Size = new System.Drawing.Size(100, 20);
            this.dtpDateOfBirthCustomer.TabIndex = 59;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(158, 82);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtNameCustomer.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(1, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 21);
            this.label16.TabIndex = 54;
            this.label16.Text = "Name";
            // 
            // txtTelephoneCustomer
            // 
            this.txtTelephoneCustomer.Location = new System.Drawing.Point(158, 238);
            this.txtTelephoneCustomer.Name = "txtTelephoneCustomer";
            this.txtTelephoneCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtTelephoneCustomer.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(4, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 21);
            this.label18.TabIndex = 50;
            this.label18.Text = "Telephone no";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(4, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 21);
            this.label19.TabIndex = 49;
            this.label19.Text = "Date of Birth";
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.Location = new System.Drawing.Point(158, 186);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtAddressCustomer.TabIndex = 48;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(4, 186);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 21);
            this.label20.TabIndex = 47;
            this.label20.Text = "Address";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(4, 160);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 21);
            this.label21.TabIndex = 45;
            this.label21.Text = "License expiry date";
            // 
            // txtLicenseNumberCustomer
            // 
            this.txtLicenseNumberCustomer.Location = new System.Drawing.Point(158, 134);
            this.txtLicenseNumberCustomer.Name = "txtLicenseNumberCustomer";
            this.txtLicenseNumberCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseNumberCustomer.TabIndex = 44;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Location = new System.Drawing.Point(2, 134);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 21);
            this.label22.TabIndex = 43;
            this.label22.Text = "License Number";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Location = new System.Drawing.Point(158, 108);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(100, 20);
            this.txtIdCustomer.TabIndex = 42;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Location = new System.Drawing.Point(2, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 21);
            this.label23.TabIndex = 40;
            this.label23.Text = "ID";
            // 
            // pnlExistingCustomers
            // 
            this.pnlExistingCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlExistingCustomers.Controls.Add(this.label6);
            this.pnlExistingCustomers.Controls.Add(this.tvCustomer);
            this.pnlExistingCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExistingCustomers.Location = new System.Drawing.Point(0, 0);
            this.pnlExistingCustomers.Name = "pnlExistingCustomers";
            this.pnlExistingCustomers.Size = new System.Drawing.Size(264, 390);
            this.pnlExistingCustomers.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "Customers";
            // 
            // tvCustomer
            // 
            this.tvCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tvCustomer.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvCustomer.HideSelection = false;
            this.tvCustomer.Location = new System.Drawing.Point(5, 54);
            this.tvCustomer.Name = "tvCustomer";
            this.tvCustomer.Size = new System.Drawing.Size(259, 324);
            this.tvCustomer.TabIndex = 1;
            this.tvCustomer.DoubleClick += new System.EventHandler(this.tvCustomer_DoubleClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.tvCars);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.dtpFrom);
            this.splitContainer2.Panel2.Controls.Add(this.dtpTo);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.btnRent);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(408, 390);
            this.splitContainer2.SplitterDistance = 223;
            this.splitContainer2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cars";
            // 
            // tvCars
            // 
            this.tvCars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tvCars.CheckBoxes = true;
            this.tvCars.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvCars.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvCars.HideSelection = false;
            this.tvCars.LineColor = System.Drawing.Color.Silver;
            this.tvCars.Location = new System.Drawing.Point(0, 54);
            this.tvCars.Name = "tvCars";
            this.tvCars.Size = new System.Drawing.Size(223, 336);
            this.tvCars.TabIndex = 1;
            this.tvCars.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvCars_BeforeSelect);
            this.tvCars.DoubleClick += new System.EventHandler(this.tvCars_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(63, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 62;
            this.label3.Text = "Dates";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(60, 74);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(96, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(60, 122);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(96, 20);
            this.dtpTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(17, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "From:";
            // 
            // btnRent
            // 
            this.btnRent.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.Location = new System.Drawing.Point(66, 316);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(103, 49);
            this.btnRent.TabIndex = 1;
            this.btnRent.Text = "Rent Out";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(17, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // pnlRentDefault
            // 
            this.pnlRentDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlRentDefault.BackgroundImage")));
            this.pnlRentDefault.Controls.Add(this.textBox1);
            this.pnlRentDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentDefault.Location = new System.Drawing.Point(0, 100);
            this.pnlRentDefault.Name = "pnlRentDefault";
            this.pnlRentDefault.Size = new System.Drawing.Size(676, 390);
            this.pnlRentDefault.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(-83, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "                                 Please select a type of customer\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnOldCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 100);
            this.panel2.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 490);
            this.Controls.Add(this.pnlRentDefault);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Rent";
            this.Text = "Rent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Rent_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAddCustomer.ResumeLayout(false);
            this.pnlAddCustomer.PerformLayout();
            this.pnlExistingCustomers.ResumeLayout(false);
            this.pnlExistingCustomers.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnlRentDefault.ResumeLayout(false);
            this.pnlRentDefault.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnOldCustomer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Panel pnlAddCustomer;
        private System.Windows.Forms.DateTimePicker dtpLicenceExpiryDateCustomer;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelephoneCustomer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAddressCustomer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtLicenseNumberCustomer;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvCars;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlExistingCustomers;
        private System.Windows.Forms.TreeView tvCustomer;
        private System.Windows.Forms.Panel pnlRentDefault;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}