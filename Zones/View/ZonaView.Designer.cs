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
            ((System.ComponentModel.ISupportInitialize)(this.zonesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(151)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(105, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "disponibles";
            // 
            // zonesDataGridView
            // 
            this.zonesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zonesDataGridView.Location = new System.Drawing.Point(13, 124);
            this.zonesDataGridView.Name = "zonesDataGridView";
            this.zonesDataGridView.ReadOnly = true;
            this.zonesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.zonesDataGridView.Size = new System.Drawing.Size(975, 257);
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
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Filtra per";
            // 
            // registerUsers
            // 
            this.registerUsers.AutoSize = true;
            this.registerUsers.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsers.Location = new System.Drawing.Point(791, 410);
            this.registerUsers.Name = "registerUsers";
            this.registerUsers.Size = new System.Drawing.Size(163, 19);
            this.registerUsers.TabIndex = 12;
            this.registerUsers.Text = "Usuaris registrats:";
            // 
            // registerConductors
            // 
            this.registerConductors.AutoSize = true;
            this.registerConductors.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerConductors.Location = new System.Drawing.Point(585, 410);
            this.registerConductors.Name = "registerConductors";
            this.registerConductors.Size = new System.Drawing.Size(168, 19);
            this.registerConductors.TabIndex = 13;
            this.registerConductors.Text = "Taxistes registrats:";
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("DejaVu Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(13, 410);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(402, 51);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Habilita el mode d\'edició ✎";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // ZonaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(1012, 551);
            ((System.ComponentModel.ISupportInitialize)(this.zonesDataGridView)).EndInit();
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
    }
}
