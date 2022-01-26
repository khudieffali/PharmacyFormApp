
namespace PharmacyFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.dtgOrders = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.ckSellList = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "by Medicine";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(12, 276);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(227, 28);
            this.cmbMedicine.TabIndex = 1;
            this.cmbMedicine.SelectedIndexChanged += new System.EventHandler(this.cmbMedicine_SelectedIndexChanged);
            this.cmbMedicine.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbMedicine_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(287, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "by Tags";
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(287, 276);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(227, 28);
            this.cmbTags.TabIndex = 1;
            this.cmbTags.SelectedIndexChanged += new System.EventHandler(this.cmbTags_SelectedIndexChanged);
            this.cmbTags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbTags_KeyUp);
            // 
            // dtgOrders
            // 
            this.dtgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgOrders.Location = new System.Drawing.Point(0, 341);
            this.dtgOrders.Name = "dtgOrders";
            this.dtgOrders.RowHeadersWidth = 51;
            this.dtgOrders.RowTemplate.Height = 29;
            this.dtgOrders.Size = new System.Drawing.Size(1083, 280);
            this.dtgOrders.TabIndex = 2;
            this.dtgOrders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgOrders_RowHeaderMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicineToolStripMenuItem,
            this.firmsToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 36);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.medicineToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(113, 32);
            this.medicineToolStripMenuItem.Text = "Medicine";
            this.medicineToolStripMenuItem.Click += new System.EventHandler(this.medicineToolStripMenuItem_Click);
            // 
            // firmsToolStripMenuItem
            // 
            this.firmsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firmsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.firmsToolStripMenuItem.Name = "firmsToolStripMenuItem";
            this.firmsToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.firmsToolStripMenuItem.Text = "Firms";
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tagsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PharmacyFormApp.Properties.Resources.kisspng_pharmacy_medicine_health_care_scalable_vector_grap_pills_pill_png_icon_14_png_repo_free_png_icons_5cc02ec6697423_0161324315560987584319;
            this.pictureBox1.Location = new System.Drawing.Point(23, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSell);
            this.panel1.Controls.Add(this.ckSellList);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.nmQuantity);
            this.panel1.Controls.Add(this.txtMedicineName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(537, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 302);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // btnSell
            // 
            this.btnSell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSell.BackColor = System.Drawing.Color.Gold;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSell.Location = new System.Drawing.Point(391, 235);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(122, 46);
            this.btnSell.TabIndex = 9;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // ckSellList
            // 
            this.ckSellList.FormattingEnabled = true;
            this.ckSellList.Location = new System.Drawing.Point(285, 28);
            this.ckSellList.Name = "ckSellList";
            this.ckSellList.Size = new System.Drawing.Size(228, 202);
            this.ckSellList.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(13, 235);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nmQuantity
            // 
            this.nmQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nmQuantity.Location = new System.Drawing.Point(13, 169);
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
            this.nmQuantity.Size = new System.Drawing.Size(114, 27);
            this.nmQuantity.TabIndex = 6;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMedicineName.Enabled = false;
            this.txtMedicineName.Location = new System.Drawing.Point(13, 57);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(214, 27);
            this.txtMedicineName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Medicine Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1083, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgOrders);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.cmbMedicine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.DataGridView dtgOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.CheckedListBox ckSellList;
        private System.Windows.Forms.Button btnAdd;
    }
}

