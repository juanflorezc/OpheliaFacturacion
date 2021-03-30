using System;
using System.Collections.Generic;

#nullable disable

namespace OpheliaFacturacion.Model.Models
{
    public partial class Producto
    {
        public Producto()
        {
            FacturaDetalles = new HashSet<FacturaDetalle>();
            Inventarios = new HashSet<Inventario>();
        }

        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public double ValorUnitario { get; set; }

        public virtual ICollection<FacturaDetalle> FacturaDetalles { get; set; }
        public virtual ICollection<Inventario> Inventarios { get; set; }
    }
}
