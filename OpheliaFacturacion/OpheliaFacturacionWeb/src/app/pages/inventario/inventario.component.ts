import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Inventario, Producto } from 'src/app/_models/models';
import { InventoryServicesService } from 'src/app/_services/inventory-services.service';
import { SalesServicesService } from 'src/app/_services/sales-services.service';

@Component({
  selector: 'app-inventario',
  templateUrl: './inventario.component.html',
  styleUrls: ['./inventario.component.scss']
})
export class InventarioComponent implements OnInit {

  simpleProducts: string[];
  dataSource: any;
  priority: any[];
  myForm: FormGroup;

  constructor(private inventoryServices: InventoryServicesService,private salesServices: SalesServicesService) {
    this.priority = [
      { name: 'High', value: 4 },
      { name: 'Urgent', value: 3 },
      { name: 'Normal', value: 2 },
      { name: 'Low', value: 1 }
    ];
   }

   ngOnInit() {
    this.myForm = new FormGroup({
      producto: new FormControl('', Validators.compose([Validators.required])),
      cantidad: new FormControl('', Validators.compose([Validators.required]))
    });
    
    this.inventoryServices.getInventario().subscribe(response=>    {
      this.dataSource=response
    }
    );
    this.inventoryServices.getProducto().subscribe(response=>    {
      response.forEach(element => {
        this.simpleProducts.push(element.Nombre);
      });
    }
    );
  }

  

  onsubmit()
  {
    let producto=new Inventario();
    producto.ProductoId=this.myForm.get("producto").value;
    producto.CantidadActual=parseFloat(this.myForm.get("cantidad").value);    
    this.inventoryServices.createInventario(producto).subscribe(response=>{
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
