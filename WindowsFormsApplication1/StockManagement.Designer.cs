namespace QualityVehicleForms
{
    partial class StockManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagement));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvCars = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtSearchStock = new System.Windows.Forms.ToolStripTextBox();
            this.cbSearchCategory = new System.Windows.Forms.ToolStripComboBox();
            this.cbSearchType = new System.Windows.Forms.ToolStripComboBox();
            this.btnShowAllStock = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddCar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemoveCar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddModel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemoveModel = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlAddcar = new System.Windows.Forms.Panel();
            this.btnUploadCarPic = new System.Windows.Forms.Button();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.dtmRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.dtmWof = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbBodyStyle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEngineNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlDefaultStock = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlAddModel = new System.Windows.Forms.Panel();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRentCharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFuelCapacity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassengerCapacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYearOfManufacture = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlAddcar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.pnlDefaultStock.SuspendLayout();
            this.pnlAddModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 159);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.OldLace;
            this.splitContainer1.Panel2.Controls.Add(this.pnlAddcar);
            this.splitContainer1.Panel2.Controls.Add(this.pnlDefaultStock);
            this.splitContainer1.Panel2.Controls.Add(this.pnlAddModel);
            this.splitContainer1.Size = new System.Drawing.Size(989, 499);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.tvCars);
            this.panel2.Controls.Add(this.toolStrip2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 499);
            this.panel2.TabIndex = 1;
            // 
            // tvCars
            // 
            this.tvCars.BackColor = System.Drawing.Color.Goldenrod;
            this.tvCars.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvCars.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvCars.LineColor = System.Drawing.Color.White;
            this.tvCars.Location = new System.Drawing.Point(0, 53);
            this.tvCars.Name = "tvCars";
            this.tvCars.Size = new System.Drawing.Size(441, 421);
            this.tvCars.TabIndex = 0;
            this.tvCars.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCars_AfterSelect);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearchStock,
            this.cbSearchCategory,
            this.cbSearchType,
            this.btnShowAllStock});
            this.toolStrip2.Location = new System.Drawing.Point(0, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(441, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtSearchStock
            // 
            this.txtSearchStock.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtSearchStock.Name = "txtSearchStock";
            this.txtSearchStock.Size = new System.Drawing.Size(80, 25);
            this.txtSearchStock.TextChanged += new System.EventHandler(this.txtSearchStock_TextChanged);
            // 
            // cbSearchCategory
            // 
            this.cbSearchCategory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCategory.Items.AddRange(new object[] {
            "Brand",
            "Category"});
            this.cbSearchCategory.Name = "cbSearchCategory";
            this.cbSearchCategory.Size = new System.Drawing.Size(100, 25);
            this.cbSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbSearchCategory_SelectedIndexChanged);
            // 
            // cbSearchType
            // 
            this.cbSearchType.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Items.AddRange(new object[] {
            "Brand",
            "Category"});
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(75, 25);
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // btnShowAllStock
            // 
            this.btnShowAllStock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAllStock.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllStock.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllStock.Image")));
            this.btnShowAllStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAllStock.Name = "btnShowAllStock";
            this.btnShowAllStock.Size = new System.Drawing.Size(59, 22);
            this.btnShowAllStock.Text = "Show All";
            this.btnShowAllStock.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnShowAllStock.Click += new System.EventHandler(this.btnShowAllStock_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Cars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCar,
            this.toolStripSeparator1,
            this.btnRemoveCar,
            this.toolStripSeparator4,
            this.btnAddModel,
            this.toolStripSeparator2,
            this.btnRemoveModel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 474);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddCar
            // 
            this.btnAddCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddCar.Enabled = false;
            this.btnAddCar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCar.Image")));
            this.btnAddCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(54, 22);
            this.btnAddCar.Text = "+Car ";
            this.btnAddCar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveCar.Enabled = false;
            this.btnRemoveCar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCar.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveCar.Image")));
            this.btnRemoveCar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(50, 22);
            this.btnRemoveCar.Text = "-Car ";
            this.btnRemoveCar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAddModel
            // 
            this.btnAddModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddModel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddModel.Image = ((System.Drawing.Image)(resources.GetObject("btnAddModel.Image")));
            this.btnAddModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(65, 22);
            this.btnAddModel.Text = "+Model";
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRemoveModel
            // 
            this.btnRemoveModel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRemoveModel.Enabled = false;
            this.btnRemoveModel.Font = new System.Drawing.Font("Lucida Sans", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveModel.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveModel.Image")));
            this.btnRemoveModel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveModel.Name = "btnRemoveModel";
            this.btnRemoveModel.Size = new System.Drawing.Size(61, 22);
            this.btnRemoveModel.Text = "-Model";
            this.btnRemoveModel.Click += new System.EventHandler(this.btnRemoveModel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(441, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // pnlAddcar
            // 
            this.pnlAddcar.BackColor = System.Drawing.Color.Thistle;
            this.pnlAddcar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddcar.BackgroundImage")));
            this.pnlAddcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddcar.Controls.Add(this.btnUploadCarPic);
            this.pnlAddcar.Controls.Add(this.pbCar);
            this.pnlAddcar.Controls.Add(this.btnSaveCar);
            this.pnlAddcar.Controls.Add(this.dtmRegistrationDate);
            this.pnlAddcar.Controls.Add(this.dtmWof);
            this.pnlAddcar.Controls.Add(this.label15);
            this.pnlAddcar.Controls.Add(this.label14);
            this.pnlAddcar.Controls.Add(this.cbStatus);
            this.pnlAddcar.Controls.Add(this.cbBodyStyle);
            this.pnlAddcar.Controls.Add(this.label10);
            this.pnlAddcar.Controls.Add(this.txtColor);
            this.pnlAddcar.Controls.Add(this.label11);
            this.pnlAddcar.Controls.Add(this.txtEngineNumber);
            this.pnlAddcar.Controls.Add(this.label12);
            this.pnlAddcar.Controls.Add(this.label13);
            this.pnlAddcar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddcar.Location = new System.Drawing.Point(0, 287);
            this.pnlAddcar.Name = "pnlAddcar";
            this.pnlAddcar.Size = new System.Drawing.Size(544, 212);
            this.pnlAddcar.TabIndex = 1;
            // 
            // btnUploadCarPic
            // 
            this.btnUploadCarPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUploadCarPic.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadCarPic.Location = new System.Drawing.Point(450, 143);
            this.btnUploadCarPic.Name = "btnUploadCarPic";
            this.btnUploadCarPic.Size = new System.Drawing.Size(53, 31);
            this.btnUploadCarPic.TabIndex = 32;
            this.btnUploadCarPic.Text = "Upload";
            this.btnUploadCarPic.UseVisualStyleBackColor = false;
            this.btnUploadCarPic.Click += new System.EventHandler(this.btnUploadCarPic_Click);
            // 
            // pbCar
            // 
            this.pbCar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCar.Location = new System.Drawing.Point(398, 40);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(105, 83);
            this.pbCar.TabIndex = 31;
            this.pbCar.TabStop = false;
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveCar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCar.Location = new System.Drawing.Point(222, 181);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCar.TabIndex = 29;
            this.btnSaveCar.Text = "Save";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // dtmRegistrationDate
            // 
            this.dtmRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmRegistrationDate.Location = new System.Drawing.Point(197, 40);
            this.dtmRegistrationDate.Name = "dtmRegistrationDate";
            this.dtmRegistrationDate.Size = new System.Drawing.Size(100, 20);
            this.dtmRegistrationDate.TabIndex = 30;
            // 
            // dtmWof
            // 
            this.dtmWof.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmWof.Location = new System.Drawing.Point(197, 10);
            this.dtmWof.Name = "dtmWof";
            this.dtmWof.Size = new System.Drawing.Size(100, 20);
            this.dtmWof.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 19);
            this.label15.TabIndex = 28;
            this.label15.Text = "Body Style";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(197, 145);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(100, 21);
            this.cbStatus.TabIndex = 26;
            // 
            // cbBodyStyle
            // 
            this.cbBodyStyle.FormattingEnabled = true;
            this.cbBodyStyle.Location = new System.Drawing.Point(197, 118);
            this.cbBodyStyle.Name = "cbBodyStyle";
            this.cbBodyStyle.Size = new System.Drawing.Size(100, 21);
            this.cbBodyStyle.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Wof Due Date";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(197, 93);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Color";
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Location = new System.Drawing.Point(197, 67);
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEngineNumber.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "Engine Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "Registration Due Date";
            // 
            // pnlDefaultStock
            // 
            this.pnlDefaultStock.BackColor = System.Drawing.Color.Firebrick;
            this.pnlDefaultStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDefaultStock.BackgroundImage")));
            this.pnlDefaultStock.Controls.Add(this.textBox1);
            this.pnlDefaultStock.Location = new System.Drawing.Point(0, 0);
            this.pnlDefaultStock.Name = "pnlDefaultStock";
            this.pnlDefaultStock.Size = new System.Drawing.Size(544, 605);
            this.pnlDefaultStock.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(0, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "           Please select an item/button";
            // 
            // pnlAddModel
            // 
            this.pnlAddModel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlAddModel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAddModel.BackgroundImage")));
            this.pnlAddModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAddModel.Controls.Add(this.txtModel);
            this.pnlAddModel.Controls.Add(this.label9);
            this.pnlAddModel.Controls.Add(this.txtRentCharge);
            this.pnlAddModel.Controls.Add(this.label8);
            this.pnlAddModel.Controls.Add(this.txtFuelCapacity);
            this.pnlAddModel.Controls.Add(this.label7);
            this.pnlAddModel.Controls.Add(this.txtEngineSize);
            this.pnlAddModel.Controls.Add(this.label6);
            this.pnlAddModel.Controls.Add(this.txtPassengerCapacity);
            this.pnlAddModel.Controls.Add(this.label5);
            this.pnlAddModel.Controls.Add(this.txtSeat);
            this.pnlAddModel.Controls.Add(this.label4);
            this.pnlAddModel.Controls.Add(this.txtYearOfManufacture);
            this.pnlAddModel.Controls.Add(this.label3);
            this.pnlAddModel.Controls.Add(this.txtBrand);
            this.pnlAddModel.Controls.Add(this.btnSaveModel);
            this.pnlAddModel.Controls.Add(this.label2);
            this.pnlAddModel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddModel.Location = new System.Drawing.Point(0, 0);
            this.pnlAddModel.Name = "pnlAddModel";
            this.pnlAddModel.Size = new System.Drawing.Size(544, 287);
            this.pnlAddModel.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(197, 17);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Model";
            // 
            // txtRentCharge
            // 
            this.txtRentCharge.Location = new System.Drawing.Point(197, 208);
            this.txtRentCharge.Name = "txtRentCharge";
            this.txtRentCharge.Size = new System.Drawing.Size(100, 20);
            this.txtRentCharge.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Rent charge(per day)";
            // 
            // txtFuelCapacity
            // 
            this.txtFuelCapacity.Location = new System.Drawing.Point(197, 179);
            this.txtFuelCapacity.Name = "txtFuelCapacity";
            this.txtFuelCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtFuelCapacity.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fuel capacity";
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(197, 153);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(100, 20);
            this.txtEngineSize.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Engine Size";
            // 
            // txtPassengerCapacity
            // 
            this.txtPassengerCapacity.Location = new System.Drawing.Point(197, 127);
            this.txtPassengerCapacity.Name = "txtPassengerCapacity";
            this.txtPassengerCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerCapacity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Passenger Capacity";
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(197, 101);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 20);
            this.txtSeat.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seat";
            // 
            // txtYearOfManufacture
            // 
            this.txtYearOfManufacture.Location = new System.Drawing.Point(197, 71);
            this.txtYearOfManufacture.Name = "txtYearOfManufacture";
            this.txtYearOfManufacture.Size = new System.Drawing.Size(100, 20);
            this.txtYearOfManufacture.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year of Manufacture";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(197, 45);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 2;
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSaveModel.Location = new System.Drawing.Point(222, 242);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(75, 23);
            this.btnSaveModel.TabIndex = 1;
            this.btnSaveModel.Text = "Save";
            this.btnSaveModel.UseVisualStyleBackColor = false;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Brand";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 159);
            this.panel1.TabIndex = 2;
            // 
            // StockManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(989, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StockManagement";
            this.Text = "Stock Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StockManagement_FormClosed);
            this.Load += new System.EventHandler(this.StockManagement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlAddcar.ResumeLayout(false);
            this.pnlAddcar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.pnlDefaultStock.ResumeLayout(false);
            this.pnlDefaultStock.PerformLayout();
            this.pnlAddModel.ResumeLayout(false);
            this.pnlAddModel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvCars;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox txtSearchStock;
        private System.Windows.Forms.ToolStripComboBox cbSearchType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRemoveCar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRemoveModel;
        private System.Windows.Forms.Panel pnlAddModel;
        private System.Windows.Forms.TextBox txtRentCharge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFuelCapacity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassengerCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYearOfManufacture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Button btnSaveModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton btnAddCar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnAddModel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnlDefaultStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlAddcar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbBodyStyle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEngineNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.DateTimePicker dtmWof;
        private System.Windows.Forms.DateTimePicker dtmRegistrationDate;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Button btnUploadCarPic;
        private System.Windows.Forms.ToolStripComboBox cbSearchCategory;
        private System.Windows.Forms.ToolStripButton btnShowAllStock;
    }
}