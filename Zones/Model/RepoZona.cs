using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zones.Model
{
    public class RepoZona
    {
        public RepoZona()
        {
        }

        public List<Zona> GetAllZonas()
        {
            List<Zona> za = null;
            try
            {
                za = (List<Zona>)Repositori.MakeRequest("zones/", "GET", null, typeof(List<Zona>)).Result;
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
            if (za == null)
            {
                za = new List<Zona>();
            }

            return za;
        }

        public List<Zona> GetZonesByFiltre(string filtre, int filtrePer)
        {
            List<Zona> za = null;
            try
            {
                za = (List<Zona>)Repositori.MakeRequest($"zones/{filtre}/{filtrePer}", "GET", null, typeof(List<Zona>)).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (za == null)
            {
                za = new List<Zona>();
            }

            return za;
        }

        public int GetCountUsuarisZona(int id_zona)
        {
            List<Usuari> us = null;
            try
            {
                us = (List<Usuari>)Repositori.MakeRequest($"zona-clients/{id_zona}", "GET", null, typeof(List<Usuari>)).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (us == null)
            {
                us = new List<Usuari>();
            }

            return us.Count();
        }

        public int GetCountTaxistesZona(int id_zona)
        {
            List<Usuari> us = null;
            try
            {
                us = (List<Usuari>)Repositori.MakeRequest($"zona-taxistes/{id_zona}", "GET", null, typeof(List<Usuari>)).Result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (us == null)
            {
                us = new List<Usuari>();
            }

            return us.Count();
        }

        //public void UpdateZona(Zona zona)
        //{
        //    try
        //    {
        //        Repositori.MakeRequest($"zona/{zona.Id}", "PUT", zona, typeof(Zona)).Wait();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error al actualizar la zona {zona.Id}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
