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
        private ClientView view;

        public ClientController()
        {
            view = new ClientView();
        }

        public UserControl GetView()
        {
            return view;
        }
    }
}
