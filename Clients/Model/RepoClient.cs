using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clients.Model
{
    public class RepoClient
    {
        public RepoClient()
        {
        }

        public List<Usuari> GetAllClients()
        {
            List<Usuari> u = null;
            try
            {
                u = (List<Usuari>)Repositori.MakeRequest("usuaris-client/", "GET", null, typeof(List<Usuari>)).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (u == null)
            {
                u = new List<Usuari>();
            }

            return u;
        }


    }
}
