using Cotxes.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotxes.Controller
{
    public class CotxeController
    {
        private CotxeView view;

        public CotxeController()
        {
            view = new CotxeView();
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
