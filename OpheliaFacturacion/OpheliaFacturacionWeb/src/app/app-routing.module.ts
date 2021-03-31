import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginFormComponent, ResetPasswordFormComponent, CreateAccountFormComponent, ChangePasswordFormComponent } from './shared/components';
import { AuthGuardService } from './shared/services';
import { HomeComponent } from './pages/home/home.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { TasksComponent } from './pages/tasks/tasks.component';
import { DxDataGridModule, DxFormModule,DxButtonModule, DxTextBoxModule, DxSelectBoxModule  } from 'devextreme-angular';
import { ClienteComponent } from './pages/cliente/cliente.component';
import { FacturaComponent } from './pages/factura/factura.component';
import { InventarioComponent } from './pages/inventario/inventario.component';
import { ProductoComponent } from './pages/producto/producto.component';
import dxTextBox from 'devextreme/ui/text_box';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import dxSelectBox from 'devextreme/ui/select_box';
import { DetalleFacturaComponent } from './pages/detalle-factura/detalle-factura.component';

const routes: Routes = [
  {
    path: 'detalle-factura',
    component: DetalleFacturaComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'cliente',
    component: ClienteComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'factura',
    component: FacturaComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'inventario',
    component: InventarioComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'producto',
    component: ProductoComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'tasks',
    component: TasksComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'home',
    component: HomeComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'login-form',
    component: LoginFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'reset-password',
    component: ResetPasswordFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'create-account',
    component: CreateAccountFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: 'change-password/:recoveryCode',
    component: ChangePasswordFormComponent,
    canActivate: [ AuthGuardService ]
  },
  {
    path: '**',
    redirectTo: 'home'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes), DxDataGridModule, DxFormModule,DxButtonModule,DxTextBoxModule,FormsModule ,
    ReactiveFormsModule,DxSelectBoxModule ],
  providers: [AuthGuardService],
  exports: [RouterModule],
  declarations: [HomeComponent, ProfileComponent, TasksComponent, ClienteComponent,ProductoComponent,
    FacturaComponent,InventarioComponent, DetalleFacturaComponent]
})
export class AppRoutingModule { }
