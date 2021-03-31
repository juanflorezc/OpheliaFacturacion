import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Producto,Cliente, Inventario } from '../_models/models';

@Injectable({
  providedIn: 'root'
})
export class InventoryServicesService {

  constructor(private http: HttpClient) { }
  getProducto()
  {    
    return this.http.get<any>(`${environment.apiUrl}inventory/Producto`)
  }

  createProducto(producto:Producto) {
    return this.http.post<any>(`${environment.apiUrl}inventory/Producto`,producto)
  }

  updateProducto(producto:Producto) {
    return this.http.put<any>(`${environment.apiUrl}inventory/Producto`,producto)
  }

  deleteProducto(producto:Producto) {
    return this.http.delete<any>(`${environment.apiUrl}inventory/Producto`)
  }
  getInventario()
  {    
    return this.http.get<any>(`${environment.apiUrl}inventory/Inventario`)
  }

  createInventario(Inventario:Inventario) {
    return this.http.post<any>(`${environment.apiUrl}inventory/Inventario`,Inventario)
  }

  updateInventario(Inventario:Inventario) {
    return this.http.put<any>(`${environment.apiUrl}inventory/Inventario`,Inventario)
  }

  deleteInventario(Inventario:Inventario) {
    return this.http.delete<any>(`${environment.apiUrl}inventory/Inventario`)
  }
  
}
