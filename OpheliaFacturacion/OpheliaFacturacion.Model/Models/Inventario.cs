using System;
using System.Collections.Generic;

#nullable disable

namespace OpheliaFacturacion.Model.Models
{
    public partial class Inventario
    {
        public int IntentarioId { get; set; }
        public int? ProductoId { get; set; }
        public int? CantidadActual { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
