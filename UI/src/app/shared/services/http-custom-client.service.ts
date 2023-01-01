import { EmployeeParam, Param } from './../models/param';

import { Observable } from 'rxjs';
import { environment } from './../../../environments/environment';
import { HttpClient, HttpHandler, HttpParams } from '@angular/common/http';
import { Inject, inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpCustomClientService {
  baseApiUrl =environment.apiUrl;
  http :HttpClient;


  constructor(@Inject(String) controller ) {
    this.http=inject(HttpClient);
    this.baseApiUrl+=controller;
  }
  getAll<T>(params :HttpParams,param :Param):Observable<T>{

    if(param.isPagination){
   params= params.append('pageIndex' ,param.pageIndex);
   params= params.append('pageSize' ,param.pageSize);
   //params= params.append('length' ,param.length);
    }

   if(param.isPagination)
   params= params.append('isPagination' ,param.isPagination);
   if(param.pageSize)

   if(param.sort)
   params= params.append('sort' ,param.sort);
   if(param.sortBy)
   params= params.append('sortBy' ,param.sortBy);


    return this.http.get<T>(this.baseApiUrl,{params});
  }
}
