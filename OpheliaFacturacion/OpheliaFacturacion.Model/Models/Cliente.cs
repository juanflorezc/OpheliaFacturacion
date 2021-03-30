using System;
using System.Collections.Generic;

#nullable disable

namespace OpheliaFacturacion.Model.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
