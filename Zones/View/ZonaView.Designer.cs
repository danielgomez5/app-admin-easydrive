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
            this.label3 = new System.Windows.Forms.Label();
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
            this.zonesDataGridView.Location = new System.Drawing.Point(13, 77);
            this.zonesDataGridView.Name = "zonesDataGridView";
            this.zonesDataGridView.Size = new System.Drawing.Size(975, 257);
            this.zonesDataGridView.TabIndex = 5;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(766, 41);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(222, 20);
            this.searchTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cerca";
            // 
            // ZonaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.zonesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ZonaView";
            this.Size = new System.Drawing.Size(1012, 482);
            ((System.ComponentModel.ISupportInitialize)(this.zonesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView zonesDataGridView;
        public System.Windows.Forms.TextBox searchTextBox;
    }
}
