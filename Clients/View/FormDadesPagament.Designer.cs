namespace Zones.View
{
    partial class FormDadesPagament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDadesPagament));
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsuari = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTarjTextBox = new System.Windows.Forms.TextBox();
            this.titTextBox = new System.Windows.Forms.TextBox();
            this.dataExpiracio = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dniNumLabel = new System.Windows.Forms.Label();
            this.dniLetLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dades de pagament de ";
            // 
            // labelUsuari
            // 
            this.labelUsuari.AutoSize = true;
            this.labelUsuari.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.labelUsuari.Location = new System.Drawing.Point(365, 22);
            this.labelUsuari.Name = "labelUsuari";
            this.labelUsuari.Size = new System.Drawing.Size(109, 34);
            this.labelUsuari.TabIndex = 2;
            this.labelUsuari.Text = "usuari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de tarjeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(323, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(14, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data d\'expiració";
            // 
            // numTarjTextBox
            // 
            this.numTarjTextBox.Enabled = false;
            this.numTarjTextBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTarjTextBox.Location = new System.Drawing.Point(18, 155);
            this.numTarjTextBox.Multiline = true;
            this.numTarjTextBox.Name = "numTarjTextBox";
            this.numTarjTextBox.Size = new System.Drawing.Size(237, 34);
            this.numTarjTextBox.TabIndex = 6;
            // 
            // titTextBox
            // 
            this.titTextBox.Enabled = false;
            this.titTextBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titTextBox.Location = new System.Drawing.Point(327, 155);
            this.titTextBox.Multiline = true;
            this.titTextBox.Name = "titTextBox";
            this.titTextBox.Size = new System.Drawing.Size(219, 34);
            this.titTextBox.TabIndex = 7;
            // 
            // dataExpiracio
            // 
            this.dataExpiracio.CustomFormat = "dd/MM/yyyy";
            this.dataExpiracio.Enabled = false;
            this.dataExpiracio.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataExpiracio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataExpiracio.Location = new System.Drawing.Point(18, 250);
            this.dataExpiracio.Name = "dataExpiracio";
            this.dataExpiracio.Size = new System.Drawing.Size(162, 26);
            this.dataExpiracio.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.button1.Location = new System.Drawing.Point(362, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Modifica les dades";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "DNI:";
            // 
            // dniNumLabel
            // 
            this.dniNumLabel.AutoSize = true;
            this.dniNumLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniNumLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.dniNumLabel.Location = new System.Drawing.Point(59, 64);
            this.dniNumLabel.Name = "dniNumLabel";
            this.dniNumLabel.Size = new System.Drawing.Size(98, 22);
            this.dniNumLabel.TabIndex = 11;
            this.dniNumLabel.Text = "54251028";
            // 
            // dniLetLabel
            // 
            this.dniLetLabel.AutoSize = true;
            this.dniLetLabel.BackColor = System.Drawing.Color.Transparent;
            this.dniLetLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniLetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.dniLetLabel.Location = new System.Drawing.Point(150, 64);
            this.dniLetLabel.Name = "dniLetLabel";
            this.dniLetLabel.Size = new System.Drawing.Size(23, 22);
            this.dniLetLabel.TabIndex = 12;
            this.dniLetLabel.Text = "N";
            // 
            // FormDadesPagament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 322);
            this.Controls.Add(this.dniLetLabel);
            this.Controls.Add(this.dniNumLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataExpiracio);
            this.Controls.Add(this.titTextBox);
            this.Controls.Add(this.numTarjTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUsuari);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDadesPagament";
            this.Text = "Dades de pagament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label labelUsuari;
        public System.Windows.Forms.TextBox numTarjTextBox;
        public System.Windows.Forms.TextBox titTextBox;
        public System.Windows.Forms.DateTimePicker dataExpiracio;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label dniNumLabel;
        public System.Windows.Forms.Label dniLetLabel;
    }
}