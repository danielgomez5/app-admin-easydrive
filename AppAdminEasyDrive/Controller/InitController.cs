using ClassLibrary;
using Clients.Controller;
using Cotxes.Controller;
using Dashboard.Controller;
using System;
using System.Windows.Forms;
using Taxistes.Controller;
using Zones.Controller;

namespace AppAdminEasyDrive.Controller
{
    public class InitController
    {
        Form1 f = new Form1();

        public InitController()
        {
            setListeners();
            Repositori.CreateHttpClient();
            MostrarDashboard(null, null);
            Application.Run(f);
        }

        private void setListeners()
        {
            f.btnConductors.Click += MostrarTaxistes;
            f.btnUsuaris.Click += MostrarClients;
            f.btnCoches.Click += MostrarCotxes;
            f.btnZones.Click += MostrarZones;
            f.btnDashboard.Click += MostrarDashboard;
        }

        private void MostrarClients(object sender, EventArgs e)
        {
            ClientController controller = new ClientController();
            CargarVista(controller.GetView());
        }

        private void MostrarTaxistes(object sender, EventArgs e)
        {
            TaxistaController controller = new TaxistaController();
            CargarVista(controller.GetView());
        }

        private void MostrarCotxes(object sender, EventArgs e)
        {
            CotxeController controller = new CotxeController();
            CargarVista(controller.GetView());
        }

        private void MostrarZones(object sender, EventArgs e)
        {
            ZonaController controller = new ZonaController();
            CargarVista(controller.GetView());
        }

        private void MostrarDashboard(object sender, EventArgs e)
        {
            DashboardController controller = new DashboardController();
            CargarVista(controller.GetView());
        }

        private void CargarVista(UserControl vista)
        {
            f.panelContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            f.panelContenido.Controls.Add(vista);
        }
    }
}
