import { OrdersModule } from './orders/orders.module';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: 'employee', loadChildren: () => import('./employee/employee.module').then(m => m.EmployeeModule) },
{ path: 'order', loadChildren: () => import('./orders/orders.module').then(m => m.OrdersModule) }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
