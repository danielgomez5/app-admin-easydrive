using System;
using System.Collections.Generic;
using System.Linq;
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

        void setListeners()
        {

        }

        void loadData()
        {
            view.taxistesDataGridView.DataSource = rep.GetAllClients();

            view.taxistesDataGridView.Columns["Rol"].Visible = false;
            view.taxistesDataGridView.Columns["IdZona"].Visible = false;
            view.taxistesDataGridView.Columns["PasswordHash"].Visible = false;

        }


        public UserControl GetView()
        {
            return view;
        }
    }
}
