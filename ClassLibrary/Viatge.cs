using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public partial class Viatge
    {
        public int Id { get; set; }

        public int? Durada { get; set; }

        public decimal? Distancia { get; set; }

        public decimal? Valoracio { get; set; }

        public string Comentari { get; set; }

        public int? IdZona { get; set; }

        public string IdTaxista { get; set; }

        public int? IdReserva { get; set; }

        public string IdCotxe { get; set; }
    }
}
