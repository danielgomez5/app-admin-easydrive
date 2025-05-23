﻿using ClassLibrary;
using Clients.Model;
using Clients.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zones.View;

namespace Clients.Controller
{
    public class ClientController
    {
        private ClientView view = new ClientView();
        private RepoClient rep = new RepoClient();
        public ClientController()
        {
            loadData();
            setListeners();
            
            
        }

        private void setListeners()
        {
            view.filtreTextBox.TextChanged += filtreUsuaris;
            view.rbDNI.CheckedChanged += filtreUsuaris;
            view.rbNom.CheckedChanged += filtreUsuaris;
            view.clientsDataGridView.SelectionChanged += loadNomUsuariLabel;
            view.buttonPayments.Click += obreDadesPagament;
            view.buttonHistory.Click += obreHistorialViatges;
            view.delButton.Click += eliminaUsuaris;
        }

        private void loadNomUsuariLabel(object sender, EventArgs e)
        {
            if (view.clientsDataGridView.SelectedRows.Count > 0 )
            {
                Usuari u = view.clientsDataGridView.SelectedRows[0].DataBoundItem as Usuari;
                view.labelUsuari.Text = $"{u.Nom} {u.Cognom}";
            }
        }

        private void filtreUsuaris(object sender, EventArgs e)
        {
            string filtre = view.filtreTextBox.Text;
            if (string.IsNullOrEmpty(filtre))
            {
                view.clientsDataGridView.DataSource = rep.GetAllClients();
                return;
            }

            int filtrePer = view.rbDNI.Checked ? 1 :
                            view.rbNom.Checked ? 2 : 0;

            view.clientsDataGridView.DataSource = rep.GetClientsByFiltre(filtre, filtrePer);
        }

        private void obreDadesPagament(object sender, EventArgs e)
        {
            if (view.clientsDataGridView.SelectedRows.Count > 0)
            {
                Usuari u = view.clientsDataGridView.SelectedRows[0].DataBoundItem as Usuari;

                DadesPagament d = rep.GetDadesPagament(u.Dni);

                if (d != null)
                {
                    FormDadesPagament f = new FormDadesPagament();
                    f.labelUsuari.Text = $"{u.Nom} {u.Cognom}";
                    f.numTarjTextBox.Text = d.NumeroTarjeta;
                    f.titTextBox.Text = d.Titular;
                    f.dataExpiracio.Value = d.DataExpiracio.Date;
                    f.dniNumLabel.Text = u.Dni.Substring(0, u.Dni.Length - 1);
                    f.dniLetLabel.Text = u.Dni.Substring(u.Dni.Length - 1);


                    f.Show();
                }
                else
                {
                    MessageBox.Show($"L'usuari amb DNI {u.Dni} no té dades de pagament associades", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void obreHistorialViatges(object sender, EventArgs e)
        {

            if (view.clientsDataGridView.SelectedRows.Count > 0)
            {
                Usuari u = view.clientsDataGridView.SelectedRows[0].DataBoundItem as Usuari;
                List<Viatge> viatges = rep.GetViatges(u.Dni);

                if (viatges != null && viatges.Any())
                {
                    FormHistorial f = new FormHistorial();
                    agregarTarjesHistorial(f, viatges);

                    f.labelUsuari.Text = $"{u.Nom} {u.Cognom}";

                    f.Show();
                }
                else
                {
                    MessageBox.Show($"L'usuari amb DNI {u.Dni} no té viatges registrats", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void agregarTarjesHistorial(FormHistorial f, List<Viatge> viatges)
        {
            FlowLayoutPanel panel = f.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (panel == null) return;

            panel.Controls.Clear();

            foreach (Viatge viatge in viatges)
            {
                Panel card = crearTarjaViatge(viatge);
                panel.Controls.Add(card);
            }
        }

        private Panel crearTarjaViatge(Viatge viatge)
        {
            Panel card = new Panel
            {
                Width = 900,
                Height = 320, // Más alto
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(231, 222, 248),
                Padding = new Padding(35),
                Margin = new Padding(10),
                AutoScroll = true // Por si acaso hay más contenido
            };

            Label lblRuta = new Label
            {
                Text = $"🚗 Viatge de {viatge.IdReservaNavigation?.Origen} a {viatge.IdReservaNavigation?.Desti}",
                Font = new Font("DejaVu Sans Condensed", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(97, 91, 113),
                AutoSize = true,
                MaximumSize = new Size(600, 0) // Máximo ancho antes de saltar de línea
            };

            Label lblFecha = new Label
            {
                Text = $"📅 Día: {viatge.IdReservaNavigation?.DataViatge?.ToString("dd/MM/yyyy")}",
                Font = new Font("DejaVu Sans Condensed", 16F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblDurada = new Label
            {
                Text = $"🕒 Duració: {viatge.Durada} minuts",
                Font = new Font("DejaVu Sans Condensed", 16F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblDistancia = new Label
            {
                Text = $"📍 Distància: {viatge.Distancia} km",
                Font = new Font("DejaVu Sans Condensed", 16F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblValoracio = new Label
            {
                Text = $"⭐ Puntuació: {(viatge.Valoracio != null ? viatge.Valoracio.ToString() : "-")}",
                Font = new Font("DejaVu Sans Condensed", 16F),
                AutoSize = true,
                ForeColor = Color.Goldenrod
            };

            PictureBox picConductor = new PictureBox
            {
                Width = 180,
                Height = 200,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblConductor = new Label
            {
                Text = $"🏁 Conductor:",
                Font = new Font("DejaVu Sans Condensed", 10F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            Label lblConductorNom = new Label
            {
                Text = $"{viatge.IdTaxistaNavigation.Nom} {viatge.IdTaxistaNavigation.Cognom}",
                Font = new Font("DejaVu Sans Condensed", 10F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            if (viatge.IdTaxistaNavigation?.FotoPerfil != null)
            {
                try
                {
                    picConductor.Load("http://localhost:7126/Photos/" + viatge.IdTaxistaNavigation.FotoPerfil);
                }
                catch
                {
                    // Imatge no disponible
                }
            }

            card.Controls.Add(lblRuta);
            card.Controls.Add(lblFecha);
            card.Controls.Add(lblDurada);
            card.Controls.Add(lblDistancia);
            card.Controls.Add(lblValoracio);
            card.Controls.Add(picConductor);
            card.Controls.Add(lblConductor);
            card.Controls.Add(lblConductorNom);

            int yPos = 10;
            foreach (Control c in card.Controls)
            {
                if (c != picConductor && c != lblConductor && c != lblConductorNom)
                {
                    c.Location = new Point(15, yPos);
                    yPos += c.Height + 20;
                }
            }

            picConductor.Location = new Point(card.Width - 200, 20);
            lblConductor.Location = new Point(
                picConductor.Left + (picConductor.Width - lblConductor.Width) / 2,
                picConductor.Bottom + 5);
            lblConductorNom.Location = new Point(
                picConductor.Left + (picConductor.Width - lblConductorNom.Width) / 2,
                lblConductor.Bottom + 2);

            return card;
        }


        private void eliminaUsuaris(object sender, EventArgs e)
        {
            if (view.clientsDataGridView.SelectedRows.Count > 0)
            {
                // Demana confirmació abans d'eliminar
                DialogResult result = MessageBox.Show(
                    "Estàs segur de voler eliminar els usuaris seleccionats?",
                    "Confirmació",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in view.clientsDataGridView.SelectedRows)
                    {
                        string idUsuari = row.Cells["DNI"].Value.ToString();

                        rep.DelClient(idUsuari);
                    }

                    view.clientsDataGridView.DataSource = rep.GetAllClients();
                }
                else
                {
                    MessageBox.Show("Eliminació cancel·lada.");
                }
            }
        }

        private void loadData()
        {
            view.clientsDataGridView.DataSource = rep.GetAllClients();

            view.clientsDataGridView.Columns["FotoPerfil"].Visible = false;
            view.clientsDataGridView.Columns["FotoCarnet"].Visible = false;
            view.clientsDataGridView.Columns["Rol"].Visible = false;
            view.clientsDataGridView.Columns["Horari"].Visible = false;
            view.clientsDataGridView.Columns["Disponibilitat"].Visible = false;
            view.clientsDataGridView.Columns["IdZona"].Visible = false;
            view.clientsDataGridView.Columns["PasswordHash"].Visible = false;

            view.clientsDataGridView.Columns["DataNaixement"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }



        public UserControl GetView()
        {
            return view;
        }
    }
}