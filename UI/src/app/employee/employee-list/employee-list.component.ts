import { Param } from 'src/app/shared/models/param';
import { EmployeeParam } from './../../shared/models/param';

import { IEmployee } from './../../shared/models/employee/employee';
import { AfterViewInit, Component, ViewChild ,ElementRef} from '@angular/core';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { EmployeeListDataSource } from './employee-list-datasource';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { debounceTime, distinctUntilChanged, map, BehaviorSubject, fromEvent, tap } from 'rxjs';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.scss']
})
export class EmployeeListComponent implements AfterViewInit {
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  @ViewChild(MatTable) table!: MatTable<IEmployee>;
  @ViewChild("nameInput") nameInput?: ElementRef;
  @ViewChild("tabCodeInput") tabCodeInput?: ElementRef;
  @ViewChild("tegaraCode") tegaraCodeInput?: ElementRef;
  @ViewChild("nationalId") nationalIdInput?: ElementRef;
  @ViewChild("employeeHasBank") employeeHasBankInput?: ElementRef;
  dataSource: EmployeeListDataSource;
  employeeParam = new EmployeeParam();

  nameBehavior = new BehaviorSubject(null);

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

    this.dataSource.employeeParam.pageIndex=event.pageIndex;

    this.table.dataSource = this.dataSource.connect();

  }



  search(ev){

  }
  clear(ev :any){
  if(ev==='name')
    {
      this.nameInput.nativeElement.value='';
      this.employeeParam.name=null;
    }
    if(ev==='tabCode')
    {
      this.tabCodeInput.nativeElement.value='';
      this.employeeParam.tabCode=null;
    }
    if(ev==='nationalId')
    {
      this.tabCodeInput.nativeElement.value='';
      this.employeeParam.tabCode=null;
    }
    this.table.dataSource=this.dataSource.connect()
  }

  searchBox(ev) {
      console.log(ev);
    ev.elementValue.subscribe(x => {
      console.log(x);
      this.employeeParam = Object.assign(this.employeeParam,x.Param);
      console.log(this.employeeParam);
      this.table.dataSource=this.dataSource.connect()
    }
    )

  }

  sortData(ev){
console.log(ev);
    this.employeeParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }
  clearSerach(ev){
    this.employeeParam=ev;
    this.table.dataSource=this.dataSource.connect()
  }

}

