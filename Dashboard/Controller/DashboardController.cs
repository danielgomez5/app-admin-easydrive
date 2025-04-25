using Dashboard.Model;
using Dashboard.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Dashboard.Controller
{
    public class DashboardController
    {
        private DashboardView view = new DashboardView();
        private RepoDashboard rep = new RepoDashboard();
        public DashboardController()
        {
            setListeners();
            loadData();
        }

        private void setListeners()
        {
            
        }
        private void loadData()
        {
            view.top5DataGridView.DataSource = rep.GetTop5Taxistes();
            view.reservesDataGridView.DataSource = rep.GetReservesPendents();
            view.reservesDataGridView.Columns["IdEstat"].Visible = false;
            view.reservesDataGridView.Columns["IdUsuari"].Visible = false;
            view.reservesDataGridView.Columns["Id"].Visible = false;
            view.reservesDataGridView.Columns["Estat"].Visible = false;

            view.reservesDataGridView.Columns["DataReserva"].DefaultCellStyle.Format = "dd/MM/yyyy";
            view.reservesDataGridView.Columns["DataViatge"].DefaultCellStyle.Format = "dd/MM/yyyy";
            carregaGrafic();
        }

        private void carregaGrafic()
        {
            List<ZonaDTO> zones = rep.GetTopZones();

            view.zonesChart.Series.Clear();

            var series = new Series("Viatges per Zona");
            series.ChartType = SeriesChartType.Doughnut;

            // Calcular total de viajes para porcentajes
            double totalViatges = zones.Sum(z => z.NumViatges);

            foreach (var z in zones)
            {
                int idx = series.Points.AddXY(z.NomZona, z.NumViatges);

                double percent = (z.NumViatges / totalViatges) * 100.0;
                string percentText = percent.ToString("0.##") + "%";

                // Mostrar zona + porcentaje en la leyenda
                series.Points[idx].LegendText = $"{z.NomZona} - {percentText}";
            }

            // No mostrar etiquetas dentro del doughnut
            series.IsValueShownAsLabel = false;
            series["PieLabelStyle"] = "Disabled";

            // Añadir la serie
            view.zonesChart.Series.Add(series);

            // Mostrar leyenda a la derecha
            if (view.zonesChart.Legends.Count == 0)
                view.zonesChart.Legends.Add(new Legend());

            view.zonesChart.Legends[0].Enabled = true;
            view.zonesChart.Legends[0].Docking = Docking.Bottom;
            view.zonesChart.Legends[0].Alignment = StringAlignment.Center;
            view.zonesChart.Legends[0].LegendStyle = LegendStyle.Table;
            view.zonesChart.Legends[0].TableStyle = LegendTableStyle.Auto;
            view.zonesChart.Legends[0].Font = new Font("DejaVu Sans Condensed", 9F);



            view.zonesChart.ChartAreas[0].Position = new ElementPosition(10, 5, 80, 70);
            // Visual settings opcionales
            view.zonesChart.ChartAreas[0].Area3DStyle.Enable3D = false;
            view.zonesChart.ChartAreas[0].BackColor = Color.Transparent;
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
