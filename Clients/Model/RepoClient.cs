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

        public List<Usuari> GetClientsByFiltre(string filtre, int filtrePer)
        {
            {
                List<Usuari> us = null;
                try
                {
                    us = (List<Usuari>)Repositori.MakeRequest($"usuaris-client/{filtre}/{filtrePer}", "GET", null, typeof(List<Usuari>)).Result;
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

        public DadesPagament GetDadesPagament(string id_usuari)
        {
            DadesPagament d = null;

            try
            {
                d = (DadesPagament)Repositori.MakeRequest($"usuari-pagaments/{id_usuari}", "GET", null, typeof(DadesPagament)).Result;
            }
            catch
            {
            }

            return d;
        }

        public List<Viatge> GetViatges(string id_usuari)
        {
            List<Viatge> viatges = null;
            try
            {
                viatges = (List<Viatge>)Repositori.MakeRequest($"viatges-usuari/{id_usuari}", "GET", null, typeof(List<Viatge>)).Result;
            }
            catch
            {
            }
            return viatges ?? new List<Viatge>();
        }

        public void DelClient(string id_usuari)
        {
            try
            {
                var result = (Usuari)Repositori.MakeRequest("usuari/" + id_usuari, "DELETE", null, typeof(Usuari)).Result;
            }
            catch (Exception e)
            {
                MessageBox.Show("Hi ha camps relacionals que no es poden eliminar, l'usuari haurà d'esborrar el seu compte desde l'app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}