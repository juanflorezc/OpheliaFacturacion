import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Cliente } from 'src/app/_models/models';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { SalesServicesService } from 'src/app/_services/sales-services.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.scss']
})
export class ClienteComponent implements OnInit {

  constructor(private inventoryServices: SalesServicesService) {
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
    this.myForm = new FormGroup({
        nombre: new FormControl('', Validators.compose([Validators.required])),
        fechaNacimiento: new FormControl('', Validators.compose([Validators.required]))
    });
 
    this.inventoryServices.getCliente().subscribe(response=>    {
      this.dataSource=response
    }
    );
  }

  

  onsubmit()
  {
    let cliente=new Cliente();
    cliente.Nombres=this.myForm.get("nombre").value;
    cliente.FechaNacimiento=parseFloat(this.myForm.get("fechaNacimiento").value);    
    this.inventoryServices.createCliente(cliente).subscribe(response=>{
      console.log(response);
      if(response.length>0)
      {
        alert("Registro almacenado correctamente");
        this.dataSource=this.dataSource=response; 
      }
      else{
        alert("Error");
      }
    });
  }

}
