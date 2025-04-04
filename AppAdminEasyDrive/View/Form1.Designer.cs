﻿using System;
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
            this.panelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panelCabecera.Controls.Add(this.btnDashboard);
            this.panelCabecera.Controls.Add(this.btnConductors);
            this.panelCabecera.Controls.Add(this.btnUsuaris);
            this.panelCabecera.Controls.Add(this.btnCoches);
            this.panelCabecera.Controls.Add(this.btnZones);
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1012, 168);
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
            this.btnConductors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(151)))), ((int)(((byte)(240)))));
            this.btnConductors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConductors.FlatAppearance.BorderSize = 0;
            this.btnConductors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductors.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductors.Location = new System.Drawing.Point(443, 12);
            this.btnConductors.Name = "btnConductors";
            this.btnConductors.Size = new System.Drawing.Size(255, 58);
            this.btnConductors.TabIndex = 0;
            this.btnConductors.Text = "Conductors";
            this.btnConductors.UseVisualStyleBackColor = false;
            // 
            // btnUsuaris
            // 
            this.btnUsuaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(151)))), ((int)(((byte)(240)))));
            this.btnUsuaris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuaris.FlatAppearance.BorderSize = 0;
            this.btnUsuaris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuaris.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnUsuaris.Location = new System.Drawing.Point(728, 12);
            this.btnUsuaris.Name = "btnUsuaris";
            this.btnUsuaris.Size = new System.Drawing.Size(255, 58);
            this.btnUsuaris.TabIndex = 1;
            this.btnUsuaris.Text = "Usuaris";
            this.btnUsuaris.UseVisualStyleBackColor = false;
            // 
            // btnCoches
            // 
            this.btnCoches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(151)))), ((int)(((byte)(240)))));
            this.btnCoches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoches.FlatAppearance.BorderSize = 0;
            this.btnCoches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoches.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCoches.Location = new System.Drawing.Point(443, 93);
            this.btnCoches.Name = "btnCoches";
            this.btnCoches.Size = new System.Drawing.Size(255, 58);
            this.btnCoches.TabIndex = 2;
            this.btnCoches.Text = "Cotxes";
            this.btnCoches.UseVisualStyleBackColor = false;
            // 
            // btnZones
            // 
            this.btnZones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(151)))), ((int)(((byte)(240)))));
            this.btnZones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZones.FlatAppearance.BorderSize = 0;
            this.btnZones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZones.Font = new System.Drawing.Font("DejaVu Sans Condensed", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnZones.Location = new System.Drawing.Point(728, 93);
            this.btnZones.Name = "btnZones";
            this.btnZones.Size = new System.Drawing.Size(255, 58);
            this.btnZones.TabIndex = 3;
            this.btnZones.Text = "Zones";
            this.btnZones.UseVisualStyleBackColor = false;
            // 
            // panelContenido
            // 
            this.panelContenido.Location = new System.Drawing.Point(0, 157);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1012, 605);
            this.panelContenido.TabIndex = 1;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1012, 761);
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
        public Button btnConductors;
        public Button btnUsuaris;
        public Button btnCoches;
        public Button btnDashboard;
        public Button btnZones;
    }
}