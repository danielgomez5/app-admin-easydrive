﻿namespace AppAdminEasyDrive.View
{
    partial class LoginView
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
            this.label1 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(350, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inici de sessió";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F);
            this.mailTextBox.Location = new System.Drawing.Point(260, 233);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(557, 32);
            this.mailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(256, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Correu electrònic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(86)))), ((int)(((byte)(143)))));
            this.label3.Location = new System.Drawing.Point(256, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contrasenya";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F);
            this.passTextBox.Location = new System.Drawing.Point(260, 354);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(557, 32);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.buttonEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.buttonEntrar.Location = new System.Drawing.Point(570, 442);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(247, 63);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entra ➡️";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1100, 605);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox mailTextBox;
        public System.Windows.Forms.TextBox passTextBox;
        public System.Windows.Forms.Button buttonEntrar;
    }
}
