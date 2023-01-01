import { HttpCustomClientService } from './http-custom-client.service';
import { EmployeeParam } from './../models/param';
import { Injectable } from '@angular/core';

import { IEmployee } from '../models/employee/employee';
import{Observable}from'rxjs'
import { HttpParams, HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class EmployeeService extends HttpCustomClientService {
/**
 *
 */
constructor() {
  super('employee')

}
  getEmployees(employeeParam :EmployeeParam):Observable<IEmployee[]>{

    var param = new HttpParams();
    if(employeeParam.name)
    param =param.append('name',employeeParam.name)
    if(employeeParam.nationalId)
    param =param.append('nationalId',employeeParam.nationalId)
    if(employeeParam.tabCode)
    param =param.append('tabCode',employeeParam.tabCode)
    if(employeeParam.tegaraCode)
    param =param.append('tegaraCode',employeeParam.tegaraCode)
    if(employeeParam.employeeHasBank !==null)
    param=param.append("employeeHasBank",employeeParam.employeeHasBank.toString())
    return this.getAll<IEmployee[]>(param,employeeParam);

  }

}
