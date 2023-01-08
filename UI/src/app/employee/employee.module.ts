import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EmployeeRoutingModule } from './employee-routing.module';
import { EmployeeComponent } from './employee.component';
import { EmployeeListComponent } from './employee-list/employee-list.component';

import { TestTableComponent } from './test-table/test-table.component';
import { EmployeeDetailsComponent } from './employee-details/employee-details.component';
import { BalanceComponent } from './employee-details/balance/balance.component';
import { BalanceHistoryDialogComponent } from './employee-details/balance/balance-history-dialog/balance-history-dialog.component';


@NgModule({
  declarations: [
    EmployeeComponent,
    EmployeeListComponent,
    TestTableComponent,
    EmployeeDetailsComponent,
    BalanceComponent,
    BalanceHistoryDialogComponent
  ],
  imports: [
    CommonModule,
    EmployeeRoutingModule,
    SharedModule,

  ]
})
export class EmployeeModule { }
