using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxistes.Model;
using Taxistes.View;

namespace Taxistes.Controller
{
    public class TaxistaController
    {
        private TaxisView view = new TaxisView();
        private RepoTaxista rep = new RepoTaxista();
        public TaxistaController()
        {
            setListeners();
            loadData();
        }

        private void setListeners()
        {
            view.filtreTextBox.TextChanged += filtreTaxistes;
            view.rbDNI.CheckedChanged += filtreTaxistes;
            view.rbNom.CheckedChanged += filtreTaxistes;
            view.taxistesDataGridView.SelectionChanged += loadNomTaxistaLabel;
            view.buttonFperfil.Click += obreFotoPerfil;
            view.buttonFcarnet.Click += obreFotoCarnet;
            view.buttonCar.Click += obreCotxesRegistrats;
            view.taxistesDataGridView.CellFormatting += FormatDisponibilitat;

        }

        private void loadNomTaxistaLabel(object sender, EventArgs e)
        {
            if (view.taxistesDataGridView.SelectedRows.Count > 0)
            {
                Usuari u = view.taxistesDataGridView.SelectedRows[0].DataBoundItem as Usuari;
                view.labelNomU.Text = u.Nom;
                view.labelCogU.Text = u.Cognom;
            }
        }

        private void filtreTaxistes(object sender, EventArgs e)
        {
            string filtre = view.filtreTextBox.Text;
          if (string.IsNullOrEmpty(filtre))
            {
                view.taxistesDataGridView.DataSource = rep.GetAllTaxistes();
                return;
            }

            int filtrePer = view.rbDNI.Checked ? 1 :
                            view.rbNom.Checked ? 2 : 0;

            view.taxistesDataGridView.DataSource = rep.GetTaxistesByFiltre(filtre, filtrePer);
        }

        private void obreFotoPerfil(object sender, EventArgs e)
        {
            if (view.taxistesDataGridView.SelectedRows.Count > 0)
            {
                Usuari u = view.taxistesDataGridView.SelectedRows[0].DataBoundItem as Usuari;

                if (!string.IsNullOrEmpty(u.FotoPerfil))
                {
                    FotoPerfForm f = new FotoPerfForm();
                    f.pictureBox1.Load("http://localhost:7126/Photos/" + u.FotoPerfil);
                    f.Text = "Foto perfil";
                    f.Show();
                }
                else
                {
                    MessageBox.Show($"El taxista amb DNI {u.Dni} no té foto de perfil", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void obreFotoCarnet(object sender, EventArgs e)
        {
            if (view.taxistesDataGridView.SelectedRows.Count > 0)
            {
                Usuari u = view.taxistesDataGridView.SelectedRows[0].DataBoundItem as Usuari;

                if (!string.IsNullOrEmpty(u.FotoCarnet))
                {
                    FotoPerfForm f = new FotoPerfForm();
                    f.pictureBox1.Load("http://localhost:7126/Photos/" + u.FotoCarnet);
                    f.Text = "Foto carnet";
                    f.Show();
                }
                else
                {
                    MessageBox.Show($"El taxista amb DNI {u.Dni} no té foto de carnet", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void obreCotxesRegistrats(object sender, EventArgs e)
        {

            if (view.taxistesDataGridView.SelectedRows.Count > 0)
            {
                Usuari u = view.taxistesDataGridView.SelectedRows[0].DataBoundItem as Usuari;
                List<Cotxe> cotxes = rep.GetCotxesByTaxista(u.Dni);

                if (cotxes != null && cotxes.Any())
                {
                    CotxesTaxista f = new CotxesTaxista();
                    agregarTarjesCotxes(f, cotxes);

                    f.labelUsuari.Text = $"{u.Nom} {u.Cognom}";

                    f.Show();
                }
                else
                {
                    MessageBox.Show($"El taxista amb DNI {u.Dni} no té cotxes registrats", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void agregarTarjesCotxes(CotxesTaxista f, List<Cotxe> cotxes)
        {
            FlowLayoutPanel panel = f.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (panel == null) return;

            panel.Controls.Clear();

            foreach (Cotxe cotxe in cotxes)
            {
                Panel card = crearTarjaCotxe(cotxe);
                panel.Controls.Add(card);
            }
        }

        private Panel crearTarjaCotxe(Cotxe cotxe)
        {
            Panel card = new Panel
            {
                Width = 900,
                Height = 250,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(30),
                Margin = new Padding(10),
                BackColor = Color.FromArgb(231, 222, 248)
            };

            Label lblMatricula = new Label
            {
                Text = $"{cotxe.Matricula} - {cotxe.Marca} {cotxe.Model}",
                Font = new Font("DejaVu Sans Condensed", 14F, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblAny = new Label
            {
                Text = $"Any: {cotxe.Any}",
                Font = new Font("DejaVu Sans Condensed", 12F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblColor = new Label
            {
                Text = $"Color: {cotxe.Color}",
                Font = new Font("DejaVu Sans Condensed", 12F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblTipus = new Label
            {
                Text = $"Tipus: {cotxe.Tipus}",
                Font = new Font("DejaVu Sans Condensed", 12F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };
            Label lblCapacitat = new Label
            {
                Text = $"Capacitat: {cotxe.Capacitat}",
                Font = new Font("DejaVu Sans Condensed", 12F),
                AutoSize = true,
                ForeColor = Color.FromArgb(97, 91, 113)
            };

            Button btnDescargar = new Button
            {
                Text = "Descarrega la fitxa tècnica",
                Font = new Font("DejaVu Sans Condensed", 12F),
                AutoSize = true,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(99, 86, 143),
                ForeColor = Color.FromArgb(231, 222, 248)
            };

            btnDescargar.Click += (sender, e) => DescarregarFitxaTecnica(cotxe);

            card.Controls.Add(lblMatricula);
            card.Controls.Add(lblAny);
            card.Controls.Add(lblColor);
            card.Controls.Add(lblTipus);
            card.Controls.Add(lblCapacitat);
            card.Controls.Add(btnDescargar);

            int yPos = 10;
            foreach (Control c in card.Controls)
            {
                c.Location = new Point(15, yPos);
                yPos += c.Height + 10;
            }

            btnDescargar.Location = new Point(15, yPos + 10);

            return card;
        }

        private void DescarregarFitxaTecnica(Cotxe cotxe)
        {
            if (cotxe.FotoFitxaTecnica == null || cotxe.FotoFitxaTecnica.Length == 0)
            {
                MessageBox.Show("Aquest cotxe no té documentació tècnica disponible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void FormatDisponibilitat(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (view.taxistesDataGridView.Columns[e.ColumnIndex].Name == "Disponibilitat")
            {
                if (e.Value != null && e.Value is bool)
                {
                    bool disponible = (bool)e.Value;
                    e.Value = disponible ? "Actiu" : "No actiu";
                    e.FormattingApplied = true;
                }
            }
        }

        private void loadData()
        {
            view.taxistesDataGridView.DataSource = rep.GetAllTaxistes();

            view.taxistesDataGridView.Columns["Rol"].Visible = false;
            view.taxistesDataGridView.Columns["IdZona"].Visible = false;
            view.taxistesDataGridView.Columns["PasswordHash"].Visible = false;
            view.taxistesDataGridView.Columns["FotoPerfil"].Visible = false;
            view.taxistesDataGridView.Columns["FotoCarnet"].Visible = false;

            view.taxistesDataGridView.Columns["DataNaixement"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }


        public UserControl GetView()
        {
            return view;
        }
    }
}