
namespace PharmacyFormApp
{
    partial class AddMedicineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rcDescription = new System.Windows.Forms.RichTextBox();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.cbChecked = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.dtProduction = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtExpire = new System.Windows.Forms.DateTimePicker();
            this.ckTagList = new System.Windows.Forms.CheckedListBox();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Name";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMedicineName.Location = new System.Drawing.Point(12, 48);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(256, 27);
            this.txtMedicineName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // nmPrice
            // 
            this.nmPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nmPrice.DecimalPlaces = 2;
            this.nmPrice.Location = new System.Drawing.Point(14, 139);
            this.nmPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(149, 27);
            this.nmPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nmQuantity.Location = new System.Drawing.Point(13, 231);
            this.nmQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(149, 27);
            this.nmQuantity.TabIndex = 2;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // rcDescription
            // 
            this.rcDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rcDescription.Location = new System.Drawing.Point(12, 382);
            this.rcDescription.Name = "rcDescription";
            this.rcDescription.Size = new System.Drawing.Size(257, 129);
            this.rcDescription.TabIndex = 3;
            this.rcDescription.Text = "";
            // 
            // btnMedicine
            // 
            this.btnMedicine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMedicine.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedicine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMedicine.Location = new System.Drawing.Point(12, 544);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(279, 58);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "Add Medicine";
            this.btnMedicine.UseVisualStyleBackColor = false;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // cbChecked
            // 
            this.cbChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbChecked.AutoSize = true;
            this.cbChecked.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbChecked.ForeColor = System.Drawing.Color.White;
            this.cbChecked.Location = new System.Drawing.Point(175, 137);
            this.cbChecked.Name = "cbChecked";
            this.cbChecked.Size = new System.Drawing.Size(134, 32);
            this.cbChecked.TabIndex = 5;
            this.cbChecked.Text = "Is Receipt?";
            this.cbChecked.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(378, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Firms";
            // 
            // cmbFirms
            // 
            this.cmbFirms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(378, 47);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(252, 28);
            this.cmbFirms.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(777, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tags";
            // 
            // cmbTags
            // 
            this.cmbTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(777, 51);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(252, 28);
            this.cmbTags.TabIndex = 6;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            this.cmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbTags_KeyUp);
            // 
            // dtProduction
            // 
            this.dtProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtProduction.Location = new System.Drawing.Point(378, 132);
            this.dtProduction.Name = "dtProduction";
            this.dtProduction.Size = new System.Drawing.Size(250, 27);
            this.dtProduction.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(378, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Production Date";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(378, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Expire Date";
            // 
            // dtExpire
            // 
            this.dtExpire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtExpire.Location = new System.Drawing.Point(378, 222);
            this.dtExpire.Name = "dtExpire";
            this.dtExpire.Size = new System.Drawing.Size(250, 27);
            this.dtExpire.TabIndex = 7;
            // 
            // ckTagList
            // 
            this.ckTagList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckTagList.FormattingEnabled = true;
            this.ckTagList.Location = new System.Drawing.Point(777, 114);
            this.ckTagList.MultiColumn = true;
            this.ckTagList.Name = "ckTagList";
            this.ckTagList.Size = new System.Drawing.Size(252, 136);
            this.ckTagList.TabIndex = 8;
            this.ckTagList.SelectedIndexChanged += new System.EventHandler(this.ckTagList_SelectedIndexChanged);
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Location = new System.Drawing.Point(342, 287);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.RowHeadersWidth = 51;
            this.dtgMedicine.RowTemplate.Height = 29;
            this.dtgMedicine.Size = new System.Drawing.Size(690, 355);
            this.dtgMedicine.TabIndex = 9;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(5, 617);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(58, 25);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1044, 646);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.ckTagList);
            this.Controls.Add(this.dtExpire);
            this.Controls.Add(this.dtProduction);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.cbChecked);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.rcDescription);
            this.Controls.Add(this.nmQuantity);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AddMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddMedicineForm";
            this.Load += new System.EventHandler(this.AddMedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rcDescription;
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.CheckBox cbChecked;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFirms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.DateTimePicker dtProduction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtExpire;
        private System.Windows.Forms.CheckedListBox ckTagList;
        private System.Windows.Forms.DataGridView dtgMedicine;
        private System.Windows.Forms.Label lblError;
    }
}