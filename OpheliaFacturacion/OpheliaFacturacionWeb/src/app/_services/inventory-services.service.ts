import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Producto,Cliente } from '../_models/models';

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

  getCliente()
  {    
    return this.http.get<any>(`${environment.apiUrl}inventory/Cliente`)
  }

  createCliente(Cliente:Cliente) {
    return this.http.post<any>(`${environment.apiUrl}inventory/Cliente`,Cliente)
  }

  updateCliente(Cliente:Cliente) {
    return this.http.put<any>(`${environment.apiUrl}inventory/Cliente`,Cliente)
  }

  deleteCliente(Cliente:Cliente) {
    return this.http.delete<any>(`${environment.apiUrl}inventory/Cliente`)
  }
}
