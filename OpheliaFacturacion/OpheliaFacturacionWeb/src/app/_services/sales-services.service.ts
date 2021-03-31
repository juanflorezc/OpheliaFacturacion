import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Producto,Cliente,Factura } from '../_models/models';

@Injectable({
  providedIn: 'root'
})
export class SalesServicesService {

  constructor(private http: HttpClient) { }

  getCliente()
  {    
    return this.http.get<any>(`${environment.apiUrl}sales/Cliente`)
  }

  createCliente(Cliente:Cliente) {
    return this.http.post<any>(`${environment.apiUrl}sales/Cliente`,Cliente)
  }

  updateCliente(Cliente:Cliente) {
    return this.http.put<any>(`${environment.apiUrl}sales/Cliente`,Cliente)
  }

  deleteCliente(Cliente:Cliente) {
    return this.http.delete<any>(`${environment.apiUrl}sales/Cliente`)
  }

  getFactura()
  {    
    return this.http.get<any>(`${environment.apiUrl}inventory/Factura`)
  }

  createFactura(Factura:Factura) {
    return this.http.post<any>(`${environment.apiUrl}inventory/Factura`,Factura)
  }

  updateFactura(Factura:Factura) {
    return this.http.put<any>(`${environment.apiUrl}inventory/Factura`,Factura)
  }

  deleteFactura(Factura:Factura) {
    return this.http.delete<any>(`${environment.apiUrl}inventory/Factura`)
  }
}
