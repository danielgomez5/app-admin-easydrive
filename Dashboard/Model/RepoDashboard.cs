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


        public List<Reserva> GetReservesPendents()
        {
            List<Reserva> res = null;

            try
            {
                res = (List<Reserva>)Repositori.MakeRequest("reserves-pendents/", "GET", null, typeof(List<Reserva>)).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return res ?? new List<Reserva>();
        }

        public List<ZonaDTO> GetTopZones()
        {
            List<ZonaDTO> zones = null;

            try
            {
                zones = (List<ZonaDTO>)Repositori.MakeRequest("top-zones/", "GET", null, typeof(List<ZonaDTO>)).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return zones ?? new List<ZonaDTO>();
        }
    }
}
