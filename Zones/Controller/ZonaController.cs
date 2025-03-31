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

        void setListeners()
        {
            view.searchTextBox.TextChanged += filtreZones;
            view.editButton.Click += activarModeEdició;
            view.zonesDataGridView.SelectionChanged += loadClientsAndTaxistes;
        }

        void loadData()
        {
            view.zonesDataGridView.DataSource = rep.GetAllZonas();

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

        void filtreZones(object sender, EventArgs e)
        {
            string filtre = view.searchTextBox.Text;
            if (string.IsNullOrEmpty(filtre))
            {
                view.zonesDataGridView.DataSource = rep.GetAllZonas();
                return;
            }

            int filtrePer = 0;

            if (view.rbCA.Checked)
            {
                filtrePer = 1;
            }
            else if (view.rbCiutat.Checked)
            {
                filtrePer = 2;
            }
            else if (view.rbProvincia.Checked)
            {
                filtrePer = 3;
            }

            view.zonesDataGridView.DataSource = rep.GetZonesByFiltre(filtre, filtrePer);
        }

        void activarModeEdició(object sender, EventArgs e)
        {

            bool isEditing = view.zonesDataGridView.ReadOnly;
            view.zonesDataGridView.ReadOnly = !isEditing;

            // Cambiar el color del botón según el estado de edición
            view.editButton.ForeColor = isEditing ? Color.FromArgb(172, 151, 240) : Color.Black;

            // Si se deshabilita la edición, preguntar para guardar los cambios
            if (!isEditing)
            {
                updateZona();
            }
        }

        void loadClientsAndTaxistes(object sender, EventArgs e)
        {
            if (view.zonesDataGridView.SelectedRows.Count > 0)
            {
                Zona z = view.zonesDataGridView.SelectedRows[0].DataBoundItem as Zona;


                view.registerConductors.Text = $"Taxistes registrats: {rep.GetCountTaxistesZona(z.Id)}";
                view.registerUsers.Text = $"Usuaris registrats: {rep.GetCountUsuarisZona(z.Id)}";

            }
        }

        void updateZona()
        {
            List<Zona> zonesActualitzades = new List<Zona>();

            foreach (DataGridViewRow row in view.zonesDataGridView.Rows)
            {
                if (row.DataBoundItem is Zona zona)
                {
                    zonesActualitzades.Add(zona);
                }
            }

            if (zonesActualitzades.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Vols desar els canvis?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (var zona in zonesActualitzades)
                    {
                        rep.UpdateZona(zona);
                    }

                    MessageBox.Show("Canvis desats correctament", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
