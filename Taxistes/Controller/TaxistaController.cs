using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxistes.View;

namespace Taxistes.Controller
{
    public class TaxistaController
    {
        private TaxisView view;

        public TaxistaController()
        {
            view = new TaxisView();
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
