using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace AppAdminEasyDrive.Model
{
    public partial class Reserva
    {
        public int Id { get; set; }

        public string Origen { get; set; }

        public string Desti { get; set; }

        public DateTime DataReserva { get; set; }

        public DateTime? DataViatge { get; set; }

        public decimal? Preu { get; set; }

        public string Estat { get; set; }

        public string IdUsuari { get; set; }
        public int? IdEstat { get; set; }

    }
}
