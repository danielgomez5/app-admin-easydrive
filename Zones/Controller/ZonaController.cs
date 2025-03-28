using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zones.View;

namespace Zones.Controller
{
    public class ZonaController
    {
        private ZonaView view;

        public ZonaController()
        {
            view = new ZonaView();
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
