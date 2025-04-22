namespace AppAdminEasyDrive.View
{
    partial class FormAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pass2TextBox = new System.Windows.Forms.TextBox();
            this.changePassButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benvingut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(176, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrador!";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(18, 124);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(320, 26);
            this.passTextBox.TabIndex = 5;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(14, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nova contrasenya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(386, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Repeteix la contrasenya";
            // 
            // pass2TextBox
            // 
            this.pass2TextBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass2TextBox.Location = new System.Drawing.Point(390, 124);
            this.pass2TextBox.Name = "pass2TextBox";
            this.pass2TextBox.Size = new System.Drawing.Size(320, 26);
            this.pass2TextBox.TabIndex = 9;
            this.pass2TextBox.UseSystemPasswordChar = true;
            // 
            // changePassButton
            // 
            this.changePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.changePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassButton.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.changePassButton.Location = new System.Drawing.Point(519, 186);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(191, 50);
            this.changePassButton.TabIndex = 10;
            this.changePassButton.Text = "Caniva la contrasenya";
            this.changePassButton.UseVisualStyleBackColor = false;
            this.changePassButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.logoutButton.Location = new System.Drawing.Point(18, 186);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(191, 50);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Tanca la sessió ↩️";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 270);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.pass2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAccount";
            this.Text = "El meu compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox passTextBox;
        public System.Windows.Forms.TextBox pass2TextBox;
        public System.Windows.Forms.Button changePassButton;
        public System.Windows.Forms.Button logoutButton;
    }
}