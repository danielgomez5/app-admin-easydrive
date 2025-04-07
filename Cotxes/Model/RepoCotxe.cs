using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cotxes.Model
{
    public class RepoCotxe
    {


        public RepoCotxe()
        {
        }

        public List<Cotxe> GetAllCotxes()
        {
            List<Cotxe> co = null;
            try
            {
                co = (List<Cotxe>)Repositori.MakeRequest("cotxes/", "GET", null, typeof(List<Cotxe>)).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (co == null)
            {
                co = new List<Cotxe>();
            }

            return co;
        }

        public List<Cotxe> GetCotxesByFiltre(string filtre, int filtrePer)
        {
            {
                List<Cotxe> co = null;
                try
                {
                    co = (List<Cotxe>)Repositori.MakeRequest($"cotxes/{filtre}/{filtrePer}", "GET", null, typeof(List<Cotxe>)).Result;
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
