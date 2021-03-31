using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace OpheliaFacturacion.Model.Models
{
    public partial class FacturaDetalle
    {
        public int FacturaDetalleId { get; set; }
        public int? FacturaId { get; set; }
        public int? ProductoId { get; set; }
        public int? Cantidad { get; set; }

        [JsonIgnore]
        public virtual Factura Factura { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
