export class Param {
  pageSize: number=15 ;
  pageIndex: number=0;
  length:number;
  isPagination: boolean = true;
  sort:string=null;
  sortBy:string=null;
  totalCount:number=0;

}

export class EmployeeParam extends Param{
  name?:string=null;
  nationalId?:string=null;
  tabCode?:string=null;
  tegaraCode?:string=null;
  section?:string=null;
  collage? :string=null;

  employeeHasBank:boolean=null;
}
export class OrderFileParam extends Param{

}
export class OrderFileDetailsParam extends Param{
  orderFileId?:number=null;
  tabCode?:string=null;
  tegaraCode?:string=null;
  employeeName?:string=null;
  orderName?:string=null;
  details?:string=null;
  startFrom?:Date=null;
  endAt?:Date=null
  amount? :number;

}
