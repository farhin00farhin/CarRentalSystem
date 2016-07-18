namespace QualityVehicleForms
{
    partial class Receive
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
            this.dgvRentalRecords = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRentalRecords
            // 
            this.dgvRentalRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dgvRentalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentalRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvRentalRecords.Name = "dgvRentalRecords";
            this.dgvRentalRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentalRecords.Size = new System.Drawing.Size(686, 385);
            this.dgvRentalRecords.TabIndex = 10;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReturn.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(0, 311);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(686, 74);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 385);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvRentalRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Receive";
            this.Text = "Receive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Receive_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRentalRecords;
        private System.Windows.Forms.Button btnReturn;
    }
}