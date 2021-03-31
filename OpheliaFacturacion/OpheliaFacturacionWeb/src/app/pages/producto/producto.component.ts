import { Component, OnInit } from '@angular/core';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { environment } from 'src/environments/environment';
import 'devextreme/data/odata/store';
import { AbstractControl, FormControl, FormGroup, Validators } from '@angular/forms';
import { Producto } from 'src/app/_models/models';

@Component({
  selector: 'app-producto',
  templateUrl: './producto.component.html',
  styleUrls: ['./producto.component.scss']
})
export class ProductoComponent implements OnInit {

  dataSource: any;
  priority: any[];
  emailControl: AbstractControl;
  myForm: FormGroup;
  
  constructor(private inventoryServices: InventoryServicesService) { 
    
    this.priority = [
      { name: 'High', value: 4 },
      { name: 'Urgent', value: 3 },
      { name: 'Normal', value: 2 },
      { name: 'Low', value: 1 }
    ];
  }

  ngOnInit() {
    this.myForm = new FormGroup({
        nombre: new FormControl('', Validators.compose([Validators.required])),
        valorUnitario: new FormControl('', Validators.compose([Validators.required]))
    });
  this.emailControl = this.myForm.controls['email'];
    this.inventoryServices.getProducto().subscribe(response=>    {
      this.dataSource=response
    }
    );
  }

  

  onsubmit()
  {
    let producto=new Producto();
    producto.Nombre=this.myForm.get("nombre").value;
    producto.ValorUnitario=parseFloat(this.myForm.get("valorUnitario").value);    
    this.inventoryServices.createProducto(producto).subscribe(response=>{
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
