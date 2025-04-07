using Dashboard.Model;
using Dashboard.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        void setListeners()
        {
            
        }


        void loadData()
        {
            view.top5DataGridView.DataSource = rep.GetTop5Taxistes();
        }

       

        public UserControl GetView()
        {
            return view;
        }
    }
}
