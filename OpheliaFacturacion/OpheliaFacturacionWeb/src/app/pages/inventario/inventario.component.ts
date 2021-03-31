import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Inventario, Producto } from 'src/app/_models/models';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { SalesServicesService } from 'src/app/_services/sales-services.service';
import * as AspNetData from "devextreme-aspnet-data-nojquery";
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-inventario',
  templateUrl: './inventario.component.html',
  styleUrls: ['./inventario.component.scss']
})
export class InventarioComponent implements OnInit {

  simpleProducts: string[]=[];
  dataSource: any;
  priority: any[];
  myForm: FormGroup;
  productos: any;
  shippersData: any;

  constructor(private inventoryServices: InventoryServicesService,private salesServices: SalesServicesService) {
    this.dataSource = AspNetData.createStore({
      key: "IntentarioId",
      loadUrl: environment.apiUrl + "inventory/Inventario",
      insertUrl: environment.apiUrl + "inventory/Inventario",
      updateUrl: environment.apiUrl + "inventory/Inventario",
      deleteUrl: environment.apiUrl + "inventory/Inventario",     
  });
    
    this.shippersData = AspNetData.createStore({
        key: "Value",      
        loadUrl: environment.apiUrl + "inventory/ProductoList",      
    });
   }

   ngOnInit() {
         
  }



}
