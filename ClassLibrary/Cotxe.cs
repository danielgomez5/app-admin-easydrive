using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public partial class Cotxe
    {
        public string Matricula { get; set; } = null;

        public string Marca { get; set; } = null;

        public string Model { get; set; } = null;

        public int Any { get; set; }

        public string Tipus { get; set; } = null;

        public int Capacitat { get; set; }

        public string Color { get; set; } = null;

        public double? HoresTreballades { get; set; }

        public byte[] FotoFitxaTecnica { get; set; } = null;
    }
}
