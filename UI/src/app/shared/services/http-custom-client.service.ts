import { EmployeeParam, Param } from './../models/param';

import { Observable } from 'rxjs';
import { environment } from './../../../environments/environment';
import { HttpClient, HttpHandler, HttpParams } from '@angular/common/http';
import { Inject, inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpCustomClientService {
  protected baseApiUrl =environment.apiUrl;
  protected http :HttpClient;


  constructor(@Inject(String) controller ) {
    this.http=inject(HttpClient);
    this.baseApiUrl+=controller;
  }
  protected getAll<T>(params :HttpParams=null,param :Param,actionName :string=''):Observable<T>{
    if(params !==null)
    {

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


    }
   if(actionName!=='')
   {

    return this.http.get<T>(this.baseApiUrl+`/${actionName}`+'/',{params});
    }
    return this.http.get<T>(this.baseApiUrl,{params});
  }
   protected getById<T>(id:number,actionName :string='') :Observable<T>{
    if(actionName!=='')
    {

        return this.http.get<T>(this.baseApiUrl+`/${actionName}`+'/'+id);
    }
    return this.http.get<T>(this.baseApiUrl+'/'+id);
  }
  protected post<T> (model :{},actionName :string=''){
    console.log(model);
    if(actionName!=='')
    {

        return this.http.post<T>(this.baseApiUrl+`/${actionName}`,model);
    }
    return this.http.post<T>(this.baseApiUrl, model);
  }
}
