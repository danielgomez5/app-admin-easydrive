using System;
using System.Windows.Forms;

namespace AppAdminEasyDrive
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnConductors = new System.Windows.Forms.Button();
            this.btnUsuaris = new System.Windows.Forms.Button();
            this.btnCoches = new System.Windows.Forms.Button();
            this.btnZones = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(91)))), ((int)(((byte)(113)))));
            this.panelCabecera.Controls.Add(this.btnDashboard);
            this.panelCabecera.Controls.Add(this.btnConductors);
            this.panelCabecera.Controls.Add(this.btnUsuaris);
            this.panelCabecera.Controls.Add(this.btnCoches);
            this.panelCabecera.Controls.Add(this.btnZones);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1084, 168);
            this.panelCabecera.TabIndex = 0;
            this.panelCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCabecera_Paint);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.BackgroundImage")));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(363, 139);
            this.btnDashboard.TabIndex = 4;
            // 
            // btnConductors
            // 
            this.btnConductors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConductors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.btnConductors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConductors.FlatAppearance.BorderSize = 0;
            this.btnConductors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductors.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnConductors.Location = new System.Drawing.Point(526, 12);
            this.btnConductors.Name = "btnConductors";
            this.btnConductors.Size = new System.Drawing.Size(255, 58);
            this.btnConductors.TabIndex = 0;
            this.btnConductors.Text = "Conductors";
            this.btnConductors.UseVisualStyleBackColor = false;
            // 
            // btnUsuaris
            // 
            this.btnUsuaris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.btnUsuaris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuaris.FlatAppearance.BorderSize = 0;
            this.btnUsuaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuaris.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUsuaris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnUsuaris.Location = new System.Drawing.Point(811, 12);
            this.btnUsuaris.Name = "btnUsuaris";
            this.btnUsuaris.Size = new System.Drawing.Size(255, 58);
            this.btnUsuaris.TabIndex = 1;
            this.btnUsuaris.Text = "Usuaris";
            this.btnUsuaris.UseVisualStyleBackColor = false;
            // 
            // btnCoches
            // 
            this.btnCoches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.btnCoches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoches.FlatAppearance.BorderSize = 0;
            this.btnCoches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoches.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCoches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnCoches.Location = new System.Drawing.Point(526, 93);
            this.btnCoches.Name = "btnCoches";
            this.btnCoches.Size = new System.Drawing.Size(255, 58);
            this.btnCoches.TabIndex = 2;
            this.btnCoches.Text = "Cotxes";
            this.btnCoches.UseVisualStyleBackColor = false;
            // 
            // btnZones
            // 
            this.btnZones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(222)))), ((int)(((byte)(248)))));
            this.btnZones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZones.FlatAppearance.BorderSize = 0;
            this.btnZones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZones.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnZones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.btnZones.Location = new System.Drawing.Point(811, 93);
            this.btnZones.Name = "btnZones";
            this.btnZones.Size = new System.Drawing.Size(255, 58);
            this.btnZones.TabIndex = 3;
            this.btnZones.Text = "Zones";
            this.btnZones.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 0);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(0, 168, 0, 0);
            this.panelContenido.Size = new System.Drawing.Size(1084, 761);
            this.panelContenido.TabIndex = 1;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.panelContenido);
            this.Name = "Form1";
            this.Text = "App Admin Easy Drive";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCabecera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        public Panel panelCabecera;
        public Panel panelContenido;
        public Button btnUsuaris;
        public Button btnCoches;
        public Button btnDashboard;
        public Button btnZones;
        public Button btnConductors;
    }
}