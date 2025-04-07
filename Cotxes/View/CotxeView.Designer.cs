﻿namespace Cotxes.View
{
    partial class CotxeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CotxeView));
            this.label1 = new System.Windows.Forms.Label();
            this.cotxesDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filtreTextBox = new System.Windows.Forms.TextBox();
            this.rbMarca = new System.Windows.Forms.RadioButton();
            this.rbMatricula = new System.Windows.Forms.RadioButton();
            this.downloadButton = new System.Windows.Forms.Button();
            this.taxistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cotxesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(64, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cotxes";
            // 
            // cotxesDataGridView
            // 
            this.cotxesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.cotxesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cotxesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cotxesDataGridView.Location = new System.Drawing.Point(13, 125);
            this.cotxesDataGridView.Name = "cotxesDataGridView";
            this.cotxesDataGridView.ReadOnly = true;
            this.cotxesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cotxesDataGridView.Size = new System.Drawing.Size(975, 367);
            this.cotxesDataGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(171, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "registrats";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(381, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Filtra per 🔎";
            // 
            // filtreTextBox
            // 
            this.filtreTextBox.Location = new System.Drawing.Point(513, 99);
            this.filtreTextBox.Name = "filtreTextBox";
            this.filtreTextBox.Size = new System.Drawing.Size(209, 20);
            this.filtreTextBox.TabIndex = 21;
            // 
            // rbMarca
            // 
            this.rbMarca.AutoSize = true;
            this.rbMarca.Location = new System.Drawing.Point(167, 102);
            this.rbMarca.Name = "rbMarca";
            this.rbMarca.Size = new System.Drawing.Size(14, 13);
            this.rbMarca.TabIndex = 20;
            this.rbMarca.TabStop = true;
            this.rbMarca.UseVisualStyleBackColor = true;
            // 
            // rbMatricula
            // 
            this.rbMatricula.AutoSize = true;
            this.rbMatricula.Checked = true;
            this.rbMatricula.Location = new System.Drawing.Point(69, 102);
            this.rbMatricula.Name = "rbMatricula";
            this.rbMatricula.Size = new System.Drawing.Size(14, 13);
            this.rbMatricula.TabIndex = 19;
            this.rbMatricula.TabStop = true;
            this.rbMatricula.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("DejaVu Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.downloadButton.Location = new System.Drawing.Point(13, 514);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(402, 51);
            this.downloadButton.TabIndex = 23;
            this.downloadButton.Text = "Descarrega fitxa tècnica 📥";
            this.downloadButton.UseVisualStyleBackColor = false;
            // 
            // taxistButton
            // 
            this.taxistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taxistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxistButton.Font = new System.Drawing.Font("DejaVu Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxistButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.taxistButton.Location = new System.Drawing.Point(586, 514);
            this.taxistButton.Name = "taxistButton";
            this.taxistButton.Size = new System.Drawing.Size(402, 51);
            this.taxistButton.TabIndex = 24;
            this.taxistButton.Text = "Veure conductor 🚕";
            this.taxistButton.UseVisualStyleBackColor = true;
            // 
            // CotxeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.taxistButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filtreTextBox);
            this.Controls.Add(this.rbMarca);
            this.Controls.Add(this.rbMatricula);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cotxesDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "CotxeView";
            this.Size = new System.Drawing.Size(1100, 605);
            ((System.ComponentModel.ISupportInitialize)(this.cotxesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView cotxesDataGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox filtreTextBox;
        public System.Windows.Forms.RadioButton rbMarca;
        public System.Windows.Forms.RadioButton rbMatricula;
        public System.Windows.Forms.Button downloadButton;
        public System.Windows.Forms.Button taxistButton;
    }
}
