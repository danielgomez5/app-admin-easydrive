namespace Zones.View
{
    partial class ZonaView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZonaView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zonesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.rbCA = new System.Windows.Forms.RadioButton();
            this.rbCiutat = new System.Windows.Forms.RadioButton();
            this.rbProvincia = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.registerUsers = new System.Windows.Forms.Label();
            this.registerConductors = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.zonesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(167, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "disponibles";
            // 
            // zonesDataGridView
            // 
            this.zonesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zonesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.zonesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.zonesDataGridView.Location = new System.Drawing.Point(13, 124);
            this.zonesDataGridView.Name = "zonesDataGridView";
            this.zonesDataGridView.ReadOnly = true;
            this.zonesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zonesDataGridView.Size = new System.Drawing.Size(815, 257);
            this.zonesDataGridView.TabIndex = 5;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(445, 84);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // rbCA
            // 
            this.rbCA.AutoSize = true;
            this.rbCA.Checked = true;
            this.rbCA.Location = new System.Drawing.Point(188, 91);
            this.rbCA.Name = "rbCA";
            this.rbCA.Size = new System.Drawing.Size(14, 13);
            this.rbCA.TabIndex = 8;
            this.rbCA.TabStop = true;
            this.rbCA.UseVisualStyleBackColor = true;
            // 
            // rbCiutat
            // 
            this.rbCiutat.AutoSize = true;
            this.rbCiutat.Location = new System.Drawing.Point(294, 89);
            this.rbCiutat.Name = "rbCiutat";
            this.rbCiutat.Size = new System.Drawing.Size(14, 13);
            this.rbCiutat.TabIndex = 9;
            this.rbCiutat.TabStop = true;
            this.rbCiutat.UseVisualStyleBackColor = true;
            // 
            // rbProvincia
            // 
            this.rbProvincia.AutoSize = true;
            this.rbProvincia.Location = new System.Drawing.Point(401, 89);
            this.rbProvincia.Name = "rbProvincia";
            this.rbProvincia.Size = new System.Drawing.Size(14, 13);
            this.rbProvincia.TabIndex = 10;
            this.rbProvincia.TabStop = true;
            this.rbProvincia.UseVisualStyleBackColor = true;
            this.rbProvincia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filtra per 🔎";
            // 
            // registerUsers
            // 
            this.registerUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerUsers.AutoSize = true;
            this.registerUsers.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.registerUsers.Location = new System.Drawing.Point(847, 359);
            this.registerUsers.Name = "registerUsers";
            this.registerUsers.Size = new System.Drawing.Size(189, 22);
            this.registerUsers.TabIndex = 12;
            this.registerUsers.Text = "Usuaris registrats:";
            // 
            // registerConductors
            // 
            this.registerConductors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerConductors.AutoSize = true;
            this.registerConductors.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerConductors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.registerConductors.Location = new System.Drawing.Point(847, 326);
            this.registerConductors.Name = "registerConductors";
            this.registerConductors.Size = new System.Drawing.Size(196, 22);
            this.registerConductors.TabIndex = 13;
            this.registerConductors.Text = "Taxistes registrats:";
            this.registerConductors.Click += new System.EventHandler(this.registerConductors_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("DejaVu Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.editButton.Location = new System.Drawing.Point(13, 410);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(402, 51);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Habilita el mode d\'edició ✎";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(840, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 60);
            this.panel1.TabIndex = 16;
            // 
            // ZonaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.registerConductors);
            this.Controls.Add(this.registerUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbProvincia);
            this.Controls.Add(this.rbCiutat);
            this.Controls.Add(this.rbCA);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.zonesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZonaView";
            this.Size = new System.Drawing.Size(1100, 605);
            this.Load += new System.EventHandler(this.ZonaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zonesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView zonesDataGridView;
        public System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton rbCA;
        public System.Windows.Forms.RadioButton rbCiutat;
        public System.Windows.Forms.RadioButton rbProvincia;
        public System.Windows.Forms.Label registerUsers;
        public System.Windows.Forms.Label registerConductors;
        public System.Windows.Forms.Button editButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
