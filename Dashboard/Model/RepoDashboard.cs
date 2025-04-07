using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Model
{
    public class RepoDashboard
    {
        public RepoDashboard()
        {
        }

        public List<TaxistaDTO> GetTop5Taxistes()
        {
            List<TaxistaDTO> top5 = null;
            try
            {
                top5 = (List<TaxistaDTO>)Repositori.MakeRequest("taxistes-top5/", "GET", null, typeof(List<TaxistaDTO>)).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return top5 ?? new List<TaxistaDTO>();
        }

    }
}
