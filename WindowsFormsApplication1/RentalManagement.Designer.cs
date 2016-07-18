namespace QualityVehicleForms
{
    partial class RentalManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalManagement));
            this.btnReceiveCar = new System.Windows.Forms.Button();
            this.btnRentOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRentalRecords = new System.Windows.Forms.DataGridView();
            this.pnlDateRange = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.tvCars = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbRentalSearch = new System.Windows.Forms.ToolStripComboBox();
            this.btnShowAllRentals = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).BeginInit();
            this.pnlDateRange.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceiveCar
            // 
            this.btnReceiveCar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReceiveCar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiveCar.Location = new System.Drawing.Point(12, 135);
            this.btnReceiveCar.Name = "btnReceiveCar";
            this.btnReceiveCar.Size = new System.Drawing.Size(117, 56);
            this.btnReceiveCar.TabIndex = 1;
            this.btnReceiveCar.Text = "Receive returned cars";
            this.btnReceiveCar.UseVisualStyleBackColor = false;
            this.btnReceiveCar.Click += new System.EventHandler(this.btnReceiveCar_Click);
            // 
            // btnRentOut
            // 
            this.btnRentOut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRentOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentOut.Location = new System.Drawing.Point(12, 234);
            this.btnRentOut.Name = "btnRentOut";
            this.btnRentOut.Size = new System.Drawing.Size(117, 56);
            this.btnRentOut.TabIndex = 0;
            this.btnRentOut.Text = "Rent out";
            this.btnRentOut.UseVisualStyleBackColor = false;
            this.btnRentOut.Click += new System.EventHandler(this.btnRentOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnReceiveCar);
            this.panel1.Controls.Add(this.btnRentOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 314);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 315);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.dgvRentalRecords);
            this.panel3.Controls.Add(this.pnlDateRange);
            this.panel3.Controls.Add(this.tvCars);
            this.panel3.Controls.Add(this.toolStrip2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 315);
            this.panel3.TabIndex = 2;
            // 
            // dgvRentalRecords
            // 
            this.dgvRentalRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalRecords.Location = new System.Drawing.Point(0, 50);
            this.dgvRentalRecords.Name = "dgvRentalRecords";
            this.dgvRentalRecords.Size = new System.Drawing.Size(644, 265);
            this.dgvRentalRecords.TabIndex = 9;
            this.dgvRentalRecords.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRentalRecords_CellFormatting);
            // 
            // pnlDateRange
            // 
            this.pnlDateRange.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDateRange.Controls.Add(this.label2);
            this.pnlDateRange.Controls.Add(this.dtpTo);
            this.pnlDateRange.Controls.Add(this.label3);
            this.pnlDateRange.Controls.Add(this.dtpFrom);
            this.pnlDateRange.Location = new System.Drawing.Point(268, 25);
            this.pnlDateRange.Name = "pnlDateRange";
            this.pnlDateRange.Size = new System.Drawing.Size(293, 25);
            this.pnlDateRange.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(180, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 20);
            this.dtpTo.TabIndex = 4;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(154, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(39, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(97, 20);
            this.dtpFrom.TabIndex = 3;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // tvCars
            // 
            this.tvCars.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tvCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvCars.Location = new System.Drawing.Point(0, 50);
            this.tvCars.Name = "tvCars";
            this.tvCars.Size = new System.Drawing.Size(644, 265);
            this.tvCars.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbRentalSearch,
            this.btnShowAllRentals});
            this.toolStrip2.Location = new System.Drawing.Point(0, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(644, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = "By";
            // 
            // cbRentalSearch
            // 
            this.cbRentalSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbRentalSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRentalSearch.Items.AddRange(new object[] {
            "Currently available for renting",
            "Currently rented out",
            "Overdue to return",
            "Rent dates"});
            this.cbRentalSearch.Name = "cbRentalSearch";
            this.cbRentalSearch.Size = new System.Drawing.Size(175, 25);
            this.cbRentalSearch.SelectedIndexChanged += new System.EventHandler(this.cbRentalSearch_SelectedIndexChanged);
            // 
            // btnShowAllRentals
            // 
            this.btnShowAllRentals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnShowAllRentals.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllRentals.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAllRentals.Image")));
            this.btnShowAllRentals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowAllRentals.Name = "btnShowAllRentals";
            this.btnShowAllRentals.Size = new System.Drawing.Size(59, 22);
            this.btnShowAllRentals.Text = "Show All";
            this.btnShowAllRentals.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnShowAllRentals.Click += new System.EventHandler(this.btnShowAllRentals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Rental Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RentalManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(644, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RentalManagement";
            this.Text = "Rental Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RentalManagement_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).EndInit();
            this.pnlDateRange.ResumeLayout(false);
            this.pnlDateRange.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReceiveCar;
        private System.Windows.Forms.Button btnRentOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvRentalRecords;
        private System.Windows.Forms.Panel pnlDateRange;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TreeView tvCars;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbRentalSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnShowAllRentals;
    }
}