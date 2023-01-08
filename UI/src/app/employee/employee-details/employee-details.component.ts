import { combineLatest, concat, concatAll, forkJoin, merge, switchAll, switchMap, zip, map, flatMap } from 'rxjs';
import { IEmployee, IEmployeeBasicSallary } from './../../shared/models/employee/employee';
import { EmployeeService } from 'src/app/shared/services/employee.service';
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeBasicSallaryService } from 'src/app/shared/services/employee-basic-sallary.service';

@Component({
  selector: 'app-employee-details',
  templateUrl: './employee-details.component.html',
  styleUrls: ['./employee-details.component.scss']
})
export class EmployeeDetailsComponent implements OnInit,AfterViewInit{
employee :IEmployee;
employeeBasicSallary:IEmployeeBasicSallary;
id:number;
constructor(
  private activatedRoute :ActivatedRoute,
  private router:Router,
  private employeeService : EmployeeService
   ) {
  this.router.routeReuseStrategy.shouldReuseRoute = () => false;
}
  ngAfterViewInit(): void {
    this.id =this.activatedRoute.snapshot.params['id'];
    this.employeeService.getEmployee(this.id).subscribe((x:IEmployee) => this.employee=x);


  }
  ngOnInit(): void {

  }
  NextClick() {
    this.router.routeReuseStrategy.shouldReuseRoute = function () {
        return false;
    }
    this.router.onSameUrlNavigation = 'reload';
    this.router.navigate(['./employee/details/'+this.employee.next]);
}
PreviousClick() {
  this.router.routeReuseStrategy.shouldReuseRoute = function () {
      return false;
  }
  this.router.onSameUrlNavigation = 'reload';
  this.router.navigate(['./employee/details/'+this.employee.previous]);
}
}
