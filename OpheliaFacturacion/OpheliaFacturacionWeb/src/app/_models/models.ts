export class Cliente {
    ClienteId:number;
    Nombres:string;
    FechaNacimiento:any;
}

export class Producto {
    ProductoId:number;
    Nombre:string;
    ValorUnitario:number;
}

export class Inventario {
    InventarioId:number;
    CantidadActual:number;
    ProductoId:any;
    Producto:Producto[];
}

export class Factura {
    FacturaId:number;
    ClienteId:any;
    FechaCompra:any;
    TotalFactura:any;
    FacturaDetalle:FacturaDetalle[];
}

export class FacturaDetalle {
    FacturaDetalleId:number;
    FacturaId:any;
    ProductoId:any;
    Cantidad:any;
}