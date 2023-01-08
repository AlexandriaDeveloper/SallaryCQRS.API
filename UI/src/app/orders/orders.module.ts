import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OrdersRoutingModule } from './orders-routing.module';
import { OrderFileComponent } from './order-file/order-file.component';
import { AddOrderFileDialogComponent } from './order-file/add-order-file-dialog/add-order-file-dialog.component';
import { OrdersDetailsComponent } from './orders-details/orders-details.component';
import { NewEmployeeOrderDialogComponent } from './orders-details/new-employee-order-dialog/new-employee-order-dialog.component';


@NgModule({
  declarations: [
    OrderFileComponent,
    AddOrderFileDialogComponent,
    OrdersDetailsComponent,
    NewEmployeeOrderDialogComponent
  ],
  imports: [
    CommonModule,
    OrdersRoutingModule,
    SharedModule
  ]
})
export class OrdersModule { }
