export class Param {
  pageSize: number=2 ;
  pageIndex: number=0;
  length:number;
  isPagination: boolean = true;
  sort:string;
  sortBy:string;
  totalCount:number

}

export class EmployeeParam extends Param{
  name:string;
  nationalId:string;
  tabCode:string;
  tegaraCode:string;
  section:string;
  collage :string;

  employeeHasBank:boolean=null;
}
