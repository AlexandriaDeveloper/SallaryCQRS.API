import { ActivatedRoute } from '@angular/router';
import { NewEmployeeOrderDialogComponent } from './new-employee-order-dialog/new-employee-order-dialog.component';
import { MatDialog } from '@angular/material/dialog';
import { Component, AfterViewInit, OnInit, ViewChild } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { OrderFileDataSource } from './order-file-details-dataSource';
import { OrderFileService } from 'src/app/shared/services/order-file.service';
import { OrderFileDetailsParam } from 'src/app/shared/models/param';
import { EmployeeOrderFileDetailsService } from 'src/app/shared/services/employee-order-file-details.service';

@Component({
  selector: 'app-orders-details',
  templateUrl: './orders-details.component.html',
  styleUrls: ['./orders-details.component.scss']
})
export class OrdersDetailsComponent  implements AfterViewInit, OnInit{

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<any>;

  dataSource: OrderFileDataSource;
  ordersParam:OrderFileDetailsParam= new OrderFileDetailsParam();
  displayedColumns = ['action','tabCode','tegaraCode', 'employeeName','orderName','amount'];
  constructor(public dialog :MatDialog, private router : ActivatedRoute, private orderFileService:EmployeeOrderFileDetailsService){}
  ngOnInit(): void {
    this.ordersParam.orderFileId= this.router.snapshot.params['id'];



  }
  ngAfterViewInit(): void {
   this.ordersParam.isPagination=true;
    this.ordersParam.pageIndex=0;

    // this.dataSource.sort = this.sort;
   // this.dataSource.paginator = this.paginator;
    this.dataSource = new OrderFileDataSource(this.orderFileService,this.ordersParam, this.paginator);
     console.log(this.dataSource);
     this.table.dataSource = this.dataSource;
     this.paginator=this.dataSource.paginator;
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(NewEmployeeOrderDialogComponent, {
      data: {orderFileId: this.ordersParam.orderFileId},

      minWidth:'600px',
      minHeight:'759px',
      disableClose:true,
      panelClass:['dialog']
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      //this.animal = result;
    });
  }

  handlePageEvent(event: PageEvent) {
    this.dataSource.orderParam.pageIndex=event.pageIndex;
    this.table.dataSource = this.dataSource.connect();
  }

  searchBox(ev) {
    ev.elementValue.subscribe(x => {
      this.ordersParam = Object.assign(this.ordersParam,x.Param);
      this.table.dataSource=this.dataSource.connect()})

  }

  sortData(ev){
    this.ordersParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  clearSerach(ev){
    console.log(ev);
    this.ordersParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
}
