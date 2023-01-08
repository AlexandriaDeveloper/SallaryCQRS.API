import { EmployeeMonthlyTotalOrderAndDeductionsService } from './../../../shared/services/employee-monthly-total-order-and-deductions.service';
import { IEmployeeBasicSallary, IEmployeeTotalOrdersAndDeductions } from './../../../shared/models/employee/employee';
import { Component, Input, AfterViewInit } from '@angular/core';
import { EmployeeBasicSallaryService } from 'src/app/shared/services/employee-basic-sallary.service';
import { ActivatedRoute } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { BalanceHistoryDialogComponent } from './balance-history-dialog/balance-history-dialog.component';

@Component({
  selector: 'app-balance',
  templateUrl: './balance.component.html',
  styleUrls: ['./balance.component.scss']
})
export class BalanceComponent  implements AfterViewInit{

 employeeBasicSallary:IEmployeeBasicSallary;
 employeeOrderDeductions: IEmployeeTotalOrdersAndDeductions;
  /**
   *
   */
  constructor(private activatedRoute :ActivatedRoute,
  private employeeBasicSallarySevice : EmployeeBasicSallaryService,
  private employeeMonthlyTotalOrderAndDeductionsService :EmployeeMonthlyTotalOrderAndDeductionsService,
  public dialog: MatDialog
  ) {


  }
  ngAfterViewInit(): void {
    var id =this.activatedRoute.snapshot.params['id'];
    this.employeeBasicSallarySevice.getLastBasicSallary(id).subscribe((x:IEmployeeBasicSallary) => this.employeeBasicSallary=x);

    this.employeeMonthlyTotalOrderAndDeductionsService.getEmployeeMonthlyTotalOrderAndDeductionsService( id).subscribe((x:IEmployeeTotalOrdersAndDeductions) => {this.employeeOrderDeductions=x;console.log(x)})
  }
  openDialog(orderId): void {
    const dialogRef = this.dialog.open(BalanceHistoryDialogComponent, {
      data: {employeeId: this.employeeOrderDeductions.employeeId, orderId: orderId},
     minWidth:'1200px',
     minHeight:'500px',
     maxHeight:'900px',
     hasBackdrop:true
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    //  this.animal = result;
    });
  }
}


