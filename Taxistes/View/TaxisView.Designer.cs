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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taxistesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.taxistesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 26);
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
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(151)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(181, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "registrats";
            // 
            // taxistesDataGridView
            // 
            this.taxistesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxistesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxistesDataGridView.Location = new System.Drawing.Point(13, 73);
            this.taxistesDataGridView.Name = "taxistesDataGridView";
            this.taxistesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.taxistesDataGridView.Size = new System.Drawing.Size(975, 367);
            this.taxistesDataGridView.TabIndex = 5;
            // 
            // TaxisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taxistesDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaxisView";
            this.Size = new System.Drawing.Size(1012, 482);
            ((System.ComponentModel.ISupportInitialize)(this.taxistesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView taxistesDataGridView;
    }
}
