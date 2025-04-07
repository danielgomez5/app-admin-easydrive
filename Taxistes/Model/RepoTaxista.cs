using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxistes.Model
{
    public class RepoTaxista
    {
        public RepoTaxista()
        {
        }

        public List<Usuari> GetAllTaxistes()
        {
            List<Usuari> u = null;
            try
            {
                u = (List<Usuari>)Repositori.MakeRequest("usuaris-taxista/", "GET", null, typeof(List<Usuari>)).Result;
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

        public List<Usuari> GetTaxistesByFiltre(string filtre, int filtrePer)
        {
            {
                List<Usuari> us = null;
                try
                {
                    us = (List<Usuari>)Repositori.MakeRequest($"usuaris-taxista/{filtre}/{filtrePer}", "GET", null, typeof(List<Usuari>)).Result;
                }
                catch
                {
                }
                if (us == null)
                {
                    us = new List<Usuari>();
                }

                return us;
            }
        }

        public List<Cotxe> GetCotxesByTaxista(string id_taxista)
        {
            {
                List<Cotxe> co = null;
                try
                {
                    co = (List<Cotxe>)Repositori.MakeRequest($"cotxes-taxista/{id_taxista}", "GET", null, typeof(List<Cotxe>)).Result;
                }
                catch
                {
                }
                if (co == null)
                {
                    co = new List<Cotxe>();
                }

                return co;
            }
        }
    }
}
