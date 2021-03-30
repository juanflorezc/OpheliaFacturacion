import { Component, OnInit } from '@angular/core';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { environment } from 'src/environments/environment';

@Component({
  selector: 'app-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.scss']
})
export class ProductoComponent implements OnInit {

  dataSource: any;
  priority: any[];
  constructor(private inventoryServices: InventoryServicesService) { 
    this.dataSource={
      store: {
        type: 'odata',
        key: 'Task_ID',
        url: "https://js.devexpress.com/Demos/DevAV/odata/Tasks"
      },
      expand: 'ResponsibleEmployee',
      select: [
        'Task_ID',
        'Task_Subject',
        'Task_Start_Date',
        'Task_Due_Date',
        'Task_Status',
        'Task_Priority',
        'Task_Completion',
        'ResponsibleEmployee/Employee_Full_Name'
      ]
    };
    this.priority = [
      { name: 'High', value: 4 },
      { name: 'Urgent', value: 3 },
      { name: 'Normal', value: 2 },
      { name: 'Low', value: 1 }
    ];
  }

  ngOnInit() {
    this.inventoryServices.getProducto().subscribe(response=>    {
      this.dataSource={
        store: {
          type: 'odata',
          key: 'Task_ID',
          url: "https://js.devexpress.com/Demos/DevAV/odata/Tasks"
        },
        //expand: 'ResponsibleEmployee',
        select: [
          'Task_ID',
          'Task_Subject',
          'Task_Start_Date',
          'Task_Due_Date',
          'Task_Status',
          'Task_Priority',
          'Task_Completion',
          'ResponsibleEmployee/Employee_Full_Name'
        ]
      };;      
    }
    );
  }

}
