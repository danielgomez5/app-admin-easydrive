using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zones.Model;
using Zones.View;

namespace Zones.Controller
{
    public class ZonaController
    {
        private ZonaView view = new ZonaView();
        private RepoZona rep = new RepoZona();
        private bool isEditing = false;

        private void setListeners()
        {
            view.searchTextBox.TextChanged += filtreZones;
            view.editButton.Click += activarModeEdicio;
            view.zonesDataGridView.SelectionChanged += loadClientsAndTaxistes;
            view.rbCA.CheckedChanged += filtreZones;
            view.rbCiutat.CheckedChanged += filtreZones;
            view.rbProvincia.CheckedChanged += filtreZones;
        }

        private void loadData()
        {
            view.zonesDataGridView.DataSource = rep.GetAllZonas();
            agregarColumnaEstat();
        }

        private void agregarColumnaEstat()
        {
            if (view.zonesDataGridView.Columns["Estat"] != null)
            {
                view.zonesDataGridView.Columns.Remove("Estat");
            }

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.Name = "Estat";
            checkBoxColumn.HeaderText = "Coberta";
            checkBoxColumn.DataPropertyName = "Estat";
            checkBoxColumn.TrueValue = true;
            checkBoxColumn.FalseValue = false;
            checkBoxColumn.ThreeState = false;

            view.zonesDataGridView.Columns.Add(checkBoxColumn);
        }

        private void filtreZones(object sender, EventArgs e)
        {
            string filtre = view.searchTextBox.Text;
            if (string.IsNullOrEmpty(filtre))
            {
                view.zonesDataGridView.DataSource = rep.GetAllZonas();
                return;
            }

            int filtrePer = view.rbCA.Checked ? 1 :
                            view.rbCiutat.Checked ? 2 :
                            view.rbProvincia.Checked ? 3 : 0;

            view.zonesDataGridView.DataSource = rep.GetZonesByFiltre(filtre, filtrePer);
        }

        private void activarModeEdicio(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            view.zonesDataGridView.ReadOnly = !isEditing;
            view.zonesDataGridView.Columns["Id"].ReadOnly = true;

            if (isEditing)
            {
                afegirColumnaGuardar();
                view.editButton.BackColor = Color.FromArgb(97, 91, 113);
                view.editButton.ForeColor = Color.White;
            }
            else
            {
                view.editButton.BackColor = Color.Transparent;
                view.editButton.ForeColor = Color.FromArgb(97, 91, 113);
                if (view.zonesDataGridView.Columns["Guardar"] != null)
                {
                    view.zonesDataGridView.CellClick -= guardarFila;
                    view.zonesDataGridView.Columns.Remove("Guardar");
                }
            }
        }

        private void afegirColumnaGuardar()
        {
            if (view.zonesDataGridView.Columns["Guardar"] == null)
            {
                DataGridViewButtonColumn btnGuardar = new DataGridViewButtonColumn();
                btnGuardar.Name = "Guardar";
                btnGuardar.HeaderText = "Acción";
                btnGuardar.Text = "Guardar";
                btnGuardar.UseColumnTextForButtonValue = true;

                view.zonesDataGridView.Columns.Add(btnGuardar);

                view.zonesDataGridView.CellClick -= guardarFila;
                view.zonesDataGridView.CellClick += guardarFila;
            }
        }

        private void guardarFila(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == view.zonesDataGridView.Columns["Guardar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = view.zonesDataGridView.Rows[e.RowIndex];

                if (row.DataBoundItem is Zona zona)
                {
                    try
                    {
                        Zona updatedZona = new Zona
                        {
                            Id = zona.Id,
                            ComunitatA = row.Cells["ComunitatA"].Value?.ToString() ?? zona.ComunitatA,
                            Ciutat = row.Cells["Ciutat"].Value?.ToString() ?? zona.Ciutat,
                            Provincia = row.Cells["Provincia"].Value?.ToString() ?? zona.Provincia,
                            Estat = row.Cells["Estat"].Value != null ? (bool)row.Cells["Estat"].Value : zona.Estat,
                            Pais = row.Cells["Pais"].Value?.ToString() ?? zona.Pais
                        };

                        rep.UpdateZona(updatedZona);

                        MessageBox.Show($"Zona {updatedZona.Id} guardada correctament.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualitzar la zona {zona.Id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void loadClientsAndTaxistes(object sender, EventArgs e)
        {
            if (view.zonesDataGridView.SelectedRows.Count > 0)
            {
                Zona z = view.zonesDataGridView.SelectedRows[0].DataBoundItem as Zona;
                view.registerConductors.Text = $"Taxistes registrats: {rep.GetCountTaxistesZona(z.Id)}";
                view.registerUsers.Text = $"Usuaris registrats: {rep.GetCountUsuarisZona(z.Id)}";
            }
        }

        public ZonaController()
        {
            setListeners();
            loadData();
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}