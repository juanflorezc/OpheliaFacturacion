import { Component, OnInit } from '@angular/core';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { environment } from 'src/environments/environment';
import 'devextreme/data/odata/store';
import { AbstractControl, FormControl, FormGroup, Validators } from '@angular/forms';
import { Producto } from 'src/app/_models/models';
import * as AspNetData from "devextreme-aspnet-data-nojquery";

@Component({
  selector: 'app-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.scss']
})
export class ProductoComponent implements OnInit {

  dataSource: any;
  priority: any[];
  myForm: FormGroup;
  
  constructor(private inventoryServices: InventoryServicesService) { 
    this.dataSource = AspNetData.createStore({
      key: "ProductoId",
      loadUrl: environment.apiUrl + "inventory/Producto",
      insertUrl: environment.apiUrl + "inventory/Producto",
      updateUrl: environment.apiUrl + "inventory/Producto",
      deleteUrl: environment.apiUrl + "inventory/Producto",     
  });
    this.priority = [
      { name: 'High', value: 4 },
      { name: 'Urgent', value: 3 },
      { name: 'Normal', value: 2 },
      { name: 'Low', value: 1 }
    ];
  }

  ngOnInit() {
  }

}
