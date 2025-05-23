﻿using ClassLibrary;
using Cotxes.Model;
using Cotxes.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotxes.Controller
{
    public class CotxeController
    {
        private CotxeView view = new CotxeView();
        private RepoCotxe rep = new RepoCotxe();

        public CotxeController()
        {
            setListeners();
            loadData();
        }

        private void setListeners()
        {
            view.filtreTextBox.TextChanged += filtreCotxes;
            view.rbMatricula.CheckedChanged += filtreCotxes;
            view.rbMarca.CheckedChanged += filtreCotxes;
            view.taxistButton.Click += obreFitxaConductors;
            view.downloadButton.Click += descarregaFitxa;
            view.cotxesDataGridView.SelectionChanged += labelMatricula;
        }

        private void descarregaFitxa(object sender, EventArgs e)
        {
            if (view.cotxesDataGridView.SelectedRows.Count > 0)
            {
                Cotxe cotxe = view.cotxesDataGridView.SelectedRows[0].DataBoundItem as Cotxe;

                if (!string.IsNullOrEmpty(cotxe?.FotoFitxaTecnica))
                {
                    string fileName = cotxe.FotoFitxaTecnica;
                    string fileUrl = $"http://localhost:7126/Files/{fileName}";

                    string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                    Directory.CreateDirectory(folderPath);

                    string destinationPath = Path.Combine(folderPath, fileName);

                    try
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(fileUrl, destinationPath);
                        }

                        MessageBox.Show("Fitxa descarregada correctament! (Desada a Documents)", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al descarregar la fitxa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Aquest cotxe no té fitxa tècnica.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void labelMatricula(object sender, EventArgs e)
        {
            if (view.cotxesDataGridView.SelectedRows.Count > 0)
            {
                Cotxe cotxe = view.cotxesDataGridView.SelectedRows[0].DataBoundItem as Cotxe;
                view.labelMat.Text = cotxe.Matricula;
            } 
        }

        private void filtreCotxes(object sender, EventArgs e)
        {
            string filtre = view.filtreTextBox.Text;
            if (string.IsNullOrEmpty(filtre))
            {
                view.cotxesDataGridView.DataSource = rep.GetAllCotxes();
                return;
            }

            int filtrePer = view.rbMatricula.Checked ? 1 :
                            view.rbMarca.Checked ? 2 : 0;

            view.cotxesDataGridView.DataSource = rep.GetCotxesByFiltre(filtre, filtrePer);
        }

        private void obreFitxaConductors(object sender, EventArgs e)
        {
            if (view.cotxesDataGridView.SelectedRows.Count > 0)
            {
                Cotxe cotxe = view.cotxesDataGridView.SelectedRows[0].DataBoundItem as Cotxe;
                if (cotxe != null && cotxe.IdUsuaris != null && cotxe.IdUsuaris.Any())
                {
                    FormConductor f = new FormConductor();
                    f.labelUsuari.Text = $"{cotxe.Matricula} - {cotxe.Marca} {cotxe.Model}";
                    agregarTarjesConductors(f, cotxe.IdUsuaris.ToList());
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Aquest cotxe no té conductors assignats.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void agregarTarjesConductors(FormConductor f, List<Usuari> conductors)
        {
            FlowLayoutPanel panel = f.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (panel == null) return;

            panel.Controls.Clear();

            foreach (Usuari conductor in conductors)
            {
                Panel card = crearTarjaConductor(conductor);
                panel.Controls.Add(card);
            }
        }

        private Panel crearTarjaConductor(Usuari conductor)
        {
            Panel card = new Panel
            {
                Width = 900,
                Height = 265,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(231, 222, 248),
                Padding = new Padding(35),
                Margin = new Padding(10)
            };

            Label lblTitol = new Label
            {
                Text = $"{conductor.Dni} - {conductor.Nom} {conductor.Cognom}",
                Font = new Font("DejaVu Sans Condensed", 16F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            Label lblNaixement = new Label
            {
                Text = $"Data de naixement: {conductor.DataNaixement.ToString("dd/MM/yyyy")}",
                Font = new Font("DejaVu Sans Condensed", 14F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            Label lblEmail = new Label
            {
                Text = $"Email: {conductor.Email}",
                Font = new Font("DejaVu Sans Condensed", 14F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            Label lblTelefon = new Label
            {
                Text = $"Telèfon: {conductor.Telefon}",
                Font = new Font("DejaVu Sans Condensed", 14F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            string[] parts = conductor.Horari.Split(';');
            string dies = parts.Length > 0 ? parts[0].Replace("-", " a ").ToLower() : "";
            string hores = parts.Length > 1 ? parts[1].Replace("-", " a ") : "";

            Label lblDies = new Label
            {
                Text = $"🗓 de {dies}",
                Font = new Font("DejaVu Sans Condensed", 14F, FontStyle.Italic),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            Label lblHores = new Label
            {
                Text = $"⏰ de {hores}",
                Font = new Font("DejaVu Sans Condensed", 14F, FontStyle.Italic),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            PictureBox picConductor = new PictureBox
            {
                Width = 180,
                Height = 200,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle
            };

            if (conductor.FotoPerfil != null)
            {
                picConductor.Load("http://localhost:7126/Photos/" + conductor.FotoPerfil);
            }

            // Añadir controles
            card.Controls.Add(lblTitol);
            card.Controls.Add(lblNaixement);
            card.Controls.Add(lblEmail);
            card.Controls.Add(lblTelefon);
            card.Controls.Add(lblDies);
            card.Controls.Add(lblHores);
            card.Controls.Add(picConductor);

            // Posicionamiento
            int yPos = 10;
            foreach (Control c in card.Controls)
            {
                if (c != picConductor)
                {
                    c.Location = new Point(15, yPos);
                    yPos += 35;
                }
                else
                {
                    c.Location = new Point(card.Width - 200, 10);
                }
            }

            return card;
        }


        private void loadData() 
        {
            view.cotxesDataGridView.DataSource = rep.GetAllCotxes();
            view.cotxesDataGridView.Columns["FotoFitxaTecnica"].Visible = false;
            view.cotxesDataGridView.Columns["HoresTreballades"].HeaderText = "Hores de conducció";
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
