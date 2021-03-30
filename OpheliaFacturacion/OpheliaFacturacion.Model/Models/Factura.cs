using System;
using System.Collections.Generic;

#nullable disable

namespace OpheliaFacturacion.Model.Models
{
    public partial class Factura
    {
        public Factura()
        {
            FacturaDetalles = new HashSet<FacturaDetalle>();
        }

        public int FacturaId { get; set; }
        public int? ClienteId { get; set; }
        public DateTime? FechaCompra { get; set; }
        public double? TotalFactura { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; }
    }
}
