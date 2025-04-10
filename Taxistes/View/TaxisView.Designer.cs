namespace Taxistes.View
{
    partial class TaxisView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxisView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taxistesDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filtreTextBox = new System.Windows.Forms.TextBox();
            this.rbNom = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.buttonCar = new System.Windows.Forms.Button();
            this.labelNomU = new System.Windows.Forms.Label();
            this.labelCogU = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonFperfil = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonFcarnet = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.taxistesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conductors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(239, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "registrats";
            // 
            // taxistesDataGridView
            // 
            this.taxistesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taxistesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.taxistesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.taxistesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxistesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxistesDataGridView.Location = new System.Drawing.Point(13, 138);
            this.taxistesDataGridView.Name = "taxistesDataGridView";
            this.taxistesDataGridView.ReadOnly = true;
            this.taxistesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taxistesDataGridView.Size = new System.Drawing.Size(950, 367);
            this.taxistesDataGridView.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(622, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Filtra per 🔎";
            // 
            // filtreTextBox
            // 
            this.filtreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtreTextBox.Location = new System.Drawing.Point(754, 99);
            this.filtreTextBox.Name = "filtreTextBox";
            this.filtreTextBox.Size = new System.Drawing.Size(209, 20);
            this.filtreTextBox.TabIndex = 17;
            // 
            // rbNom
            // 
            this.rbNom.AutoSize = true;
            this.rbNom.Location = new System.Drawing.Point(138, 106);
            this.rbNom.Name = "rbNom";
            this.rbNom.Size = new System.Drawing.Size(14, 13);
            this.rbNom.TabIndex = 16;
            this.rbNom.TabStop = true;
            this.rbNom.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Checked = true;
            this.rbDNI.Location = new System.Drawing.Point(70, 106);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(14, 13);
            this.rbDNI.TabIndex = 15;
            this.rbDNI.TabStop = true;
            this.rbDNI.UseVisualStyleBackColor = true;
            this.rbDNI.CheckedChanged += new System.EventHandler(this.rbDNI_CheckedChanged);
            // 
            // buttonCar
            // 
            this.buttonCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.buttonCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCar.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.buttonCar.Location = new System.Drawing.Point(310, 532);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(175, 40);
            this.buttonCar.TabIndex = 19;
            this.buttonCar.Text = "Veure cotxe(s)";
            this.buttonCar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCar.UseVisualStyleBackColor = false;
            // 
            // labelNomU
            // 
            this.labelNomU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNomU.AutoSize = true;
            this.labelNomU.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.labelNomU.Location = new System.Drawing.Point(10, 518);
            this.labelNomU.Name = "labelNomU";
            this.labelNomU.Size = new System.Drawing.Size(111, 34);
            this.labelNomU.TabIndex = 20;
            this.labelNomU.Text = "Usuari";
            // 
            // labelCogU
            // 
            this.labelCogU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCogU.AutoSize = true;
            this.labelCogU.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCogU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.labelCogU.Location = new System.Drawing.Point(30, 553);
            this.labelCogU.Name = "labelCogU";
            this.labelCogU.Size = new System.Drawing.Size(114, 34);
            this.labelCogU.TabIndex = 23;
            this.labelCogU.Text = "Gomez";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(268, 532);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // buttonFperfil
            // 
            this.buttonFperfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFperfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.buttonFperfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFperfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFperfil.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFperfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.buttonFperfil.Location = new System.Drawing.Point(558, 532);
            this.buttonFperfil.Name = "buttonFperfil";
            this.buttonFperfil.Size = new System.Drawing.Size(163, 40);
            this.buttonFperfil.TabIndex = 25;
            this.buttonFperfil.Text = "Foto perfil";
            this.buttonFperfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFperfil.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(758, 532);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // buttonFcarnet
            // 
            this.buttonFcarnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFcarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.buttonFcarnet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFcarnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFcarnet.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFcarnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.buttonFcarnet.Location = new System.Drawing.Point(800, 532);
            this.buttonFcarnet.Name = "buttonFcarnet";
            this.buttonFcarnet.Size = new System.Drawing.Size(163, 40);
            this.buttonFcarnet.TabIndex = 27;
            this.buttonFcarnet.Text = "Foto carnet";
            this.buttonFcarnet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFcarnet.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(517, 532);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // TaxisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonFcarnet);
            this.Controls.Add(this.buttonFperfil);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelCogU);
            this.Controls.Add(this.labelNomU);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filtreTextBox);
            this.Controls.Add(this.rbNom);
            this.Controls.Add(this.rbDNI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.taxistesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaxisView";
            this.Size = new System.Drawing.Size(1100, 605);
            ((System.ComponentModel.ISupportInitialize)(this.taxistesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView taxistesDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox filtreTextBox;
        public System.Windows.Forms.RadioButton rbNom;
        public System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.Button buttonCar;
        public System.Windows.Forms.Label labelNomU;
        public System.Windows.Forms.Label labelCogU;
        public System.Windows.Forms.Button buttonFperfil;
        public System.Windows.Forms.Button buttonFcarnet;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
