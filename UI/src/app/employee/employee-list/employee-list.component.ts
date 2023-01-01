import { EmployeeParam } from './../../shared/models/param';

import { IEmployee } from './../../shared/models/employee/employee';
import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { EmployeeListDataSource } from './employee-list-datasource';
import { EmployeeService } from 'src/app/shared/services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<IEmployee>;
  dataSource: EmployeeListDataSource;
  employeeParam = new EmployeeParam();

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['id', 'name','tabCode','tegaraCode','nationalId','employeeHasBank'];

  constructor(private employeeService : EmployeeService) {

  }

  ngAfterViewInit(): void {

    this.employeeParam.isPagination=true;
this.employeeParam.pageIndex=0;

   // this.dataSource.sort = this.sort;
  // this.dataSource.paginator = this.paginator;
   this.dataSource = new EmployeeListDataSource(this.employeeService,this.employeeParam, this.paginator);
    console.log(this.dataSource);
    this.table.dataSource = this.dataSource;
    this.paginator=this.dataSource.paginator;

  }

  handlePageEvent(event: PageEvent) {
console.log(event);
    this.dataSource.employeeParam.pageIndex=event.pageIndex;

    this.table.dataSource = this.dataSource.connect();

  }
}

