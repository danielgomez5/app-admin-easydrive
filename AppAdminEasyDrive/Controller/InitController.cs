using APIProjecte.Models;
using AppAdminEasyDrive.Model;
using AppAdminEasyDrive.View;
using ClassLibrary;
using Clients.Controller;
using Cotxes.Controller;
using Dashboard.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Taxistes.Controller;
using Zones.Controller;

namespace AppAdminEasyDrive.Controller
{
    public class InitController
    {
        private Form1 f = new Form1();
        private FormAccount fAcc;
        public InitController()
        {
            Repositori.CreateHttpClient();
            setListeners();
            MostrarLogin();
            Application.Run(f);
        }

        private void setListeners()
        {
            f.btnConductors.Click += MostrarTaxistes;
            f.btnUsuaris.Click += MostrarClients;
            f.btnCoches.Click += MostrarCotxes;
            f.btnZones.Click += MostrarZones;
            f.btnDashboard.Click += MostrarDashboard;
            f.accButton.Click += MyAccount;
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

        private void MostrarLogin()
        {
            LoginView vista = new LoginView();
            f.panelContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            f.panelContenido.Controls.Add(vista);

            vista.buttonEntrar.Click += Login;
        }

        private void Login(object sender, EventArgs e)
        {
            LoginView vista = f.panelContenido.Controls.OfType<LoginView>().FirstOrDefault();
            if (vista == null) return;

            string email = vista.mailTextBox.Text.Trim();
            string password = vista.passTextBox.Text;

            RepoLogin rep = new RepoLogin();
            Repositori.CreateHttpClient();
            Usuari usuari = rep.LoginUsuari(email, password);

            if (usuari == null)
            {
                MessageBox.Show("Correu o contrasenya incorrectes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string mailPermès = "admin@easydrive.com";
            if (!string.Equals(usuari.Email, mailPermès, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Aquest usuari no té permís per accedir.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            f.btnCoches.Enabled = true;
            f.btnConductors.Enabled = true;
            f.btnDashboard.Enabled = true;
            f.btnUsuaris.Enabled = true;
            f.btnZones.Enabled = true;
            f.accButton.Enabled = true;
            MostrarDashboard(null, null);
        }

        private void MyAccount(object sender, EventArgs e)
        {
            if (fAcc == null || fAcc.IsDisposed)
            {
                fAcc = new FormAccount();

                fAcc.changePassButton.Click -= ChangePassword;
                fAcc.changePassButton.Click += ChangePassword;

                fAcc.logoutButton.Click -= Logout;
                fAcc.logoutButton.Click += Logout;
            }

            fAcc.Show();
            fAcc.BringToFront();
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            string pass = fAcc.passTextBox.Text;
            string pass2 = fAcc.pass2TextBox.Text;

            if (pass.Length < 6 || pass2.Length < 6)
            {
                MessageBox.Show("La contrasenya ha de tenir almenys 6 caràcters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!pass.Equals(pass2))
            {
                MessageBox.Show("Les contrasenyes no coincideixen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChangePasswordRequest passRequest = new ChangePasswordRequest{ 
                NovaContrasenya = pass
            };

            try
            {
                RepoLogin rep = new RepoLogin();
                rep.ChangePassword(passRequest);
                MessageBox.Show("Contrasenya canviada correctament.", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error en canviar la contrasenya", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            Repositori.ClearHttpClient();
            fAcc.Close();
            f.btnCoches.Enabled = false;
            f.btnConductors.Enabled = false;
            f.btnDashboard.Enabled = false;
            f.btnUsuaris.Enabled = false;
            f.btnZones.Enabled = false;
            f.accButton.Enabled = false;
            
            MostrarLogin();
        }

        private void CargarVista(UserControl vista)
        {
            f.panelContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            f.panelContenido.Controls.Add(vista);
        }

    }
}