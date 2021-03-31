import { Component, OnInit } from '@angular/core';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { SalesServicesService } from 'src/app/_services/sales-services.service';
import { Inventario, Producto } from 'src/app/_models/models';
import * as AspNetData from "devextreme-aspnet-data-nojquery";
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-detalle-factura',
  templateUrl: './detalle-factura.component.html',
  styleUrls: ['./detalle-factura.component.scss']
})
export class DetalleFacturaComponent implements OnInit {

  dataSource: any;
  FacturaData: any;
  ProductoData:any;
  constructor(private inventoryServices: InventoryServicesService,private salesServices: SalesServicesService) {
    this.dataSource = AspNetData.createStore({
      key: "FacturaDetalleId",
      loadUrl: environment.apiUrl + "sales/FacturaDetalle",
      insertUrl: environment.apiUrl + "sales/FacturaDetalle",
      updateUrl: environment.apiUrl + "sales/FacturaDetalle",
      deleteUrl: environment.apiUrl + "sales/FacturaDetalle",     
  });
    
    this.FacturaData = AspNetData.createStore({
        key: "FacturaId",      
        loadUrl: environment.apiUrl + "sales/Factura",      
    });
    this.ProductoData = AspNetData.createStore({
      key: "ProductoId",      
      loadUrl: environment.apiUrl + "inventory/Producto",      
  });
   }

  ngOnInit() {
  }

}
