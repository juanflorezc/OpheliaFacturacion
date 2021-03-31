import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Cliente } from 'src/app/_models/models';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { SalesServicesService } from 'src/app/_services/sales-services.service';
import { environment } from 'src/environments/environment';
import * as AspNetData from "devextreme-aspnet-data-nojquery";

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.scss']
})
export class ClienteComponent implements OnInit {

  constructor(private inventoryServices: SalesServicesService) {
    this.dataSource = AspNetData.createStore({
      key: "ClienteId",
      loadUrl: environment.apiUrl + "sales/Cliente",
      insertUrl: environment.apiUrl + "sales/Cliente",
      updateUrl: environment.apiUrl + "sales/Cliente",
      deleteUrl: environment.apiUrl + "sales/Cliente",     
  });
    this.priority = [
      { name: 'High', value: 4 },
      { name: 'Urgent', value: 3 },
      { name: 'Normal', value: 2 },
      { name: 'Low', value: 1 }
    ];
   }
  dataSource: any;
  priority: any[];
  myForm: FormGroup;
  
  ngOnInit() {
    
  }

  

  
}
