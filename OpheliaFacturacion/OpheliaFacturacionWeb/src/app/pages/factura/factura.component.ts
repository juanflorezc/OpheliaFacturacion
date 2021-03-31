import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { SalesServicesService } from 'src/app/_services/sales-services.service';
import { Inventario, Producto } from 'src/app/_models/models';
import * as AspNetData from "devextreme-aspnet-data-nojquery";
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-factura',
  templateUrl: './factura.component.html',
  styleUrls: ['./factura.component.scss']
})
export class FacturaComponent implements OnInit {

  dataSource: any;
  ClientesData: any;

  constructor(private inventoryServices: InventoryServicesService,private salesServices: SalesServicesService) {
    this.dataSource = AspNetData.createStore({
      key: "FacturaId",
      loadUrl: environment.apiUrl + "sales/Factura",
      insertUrl: environment.apiUrl + "sales/Factura",
      updateUrl: environment.apiUrl + "sales/Factura",
      deleteUrl: environment.apiUrl + "sales/Factura",     
  });
    
    this.ClientesData = AspNetData.createStore({
        key: "ClienteId",      
        loadUrl: environment.apiUrl + "sales/Cliente",      
    });
   }

  ngOnInit() {
    
  }

  

  

}
