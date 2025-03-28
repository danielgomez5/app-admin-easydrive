using Dashboard.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Controller
{
    public class DashboardController
    {
        private DashboardView view;

        public DashboardController()
        {
            view = new DashboardView();
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
