using Clients.Model;
using Clients.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients.Controller
{
    public class ClientController
    {
        private ClientView view = new ClientView();
        private RepoClient rep = new RepoClient();
        public ClientController()
        {
            setListeners();
            loadData();
            
        }

        void setListeners()
        {
            
        }

        void loadData()
        {
            view.clientsDataGridView.DataSource = rep.GetAllClients();

            view.clientsDataGridView.Columns["FotoPerfil"].Visible = false;
            view.clientsDataGridView.Columns["FotoCarnet"].Visible = false;
            view.clientsDataGridView.Columns["Rol"].Visible = false;
            view.clientsDataGridView.Columns["Horari"].Visible = false;
            view.clientsDataGridView.Columns["Disponibilitat"].Visible = false;
            view.clientsDataGridView.Columns["IdZona"].Visible = false;
            view.clientsDataGridView.Columns["PasswordHash"].Visible = false;

        }



        public UserControl GetView()
        {
            return view;
        }
    }
}
