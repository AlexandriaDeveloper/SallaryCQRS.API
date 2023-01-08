
export interface IEmployee{
id:number,
name:string,
tabCode:string,
tegaraCode:string,
nationalId: string,
employeeHasBank:boolean,
section :string,
collage:string
next?:number
previous?:number

}
export interface IEmployeeBasicSallary{

  id:number,
  basicSallary:number,
  wazifi:number,
  mokamel:number,
  ta3widi:number
}
export interface IEmployeeTotalOrdersAndDeductions{

  "employeeId": number,
  "employeeOrdersDtos":IEmployeeTotalOrdersAndDeductionsDetails []


}
export interface IEmployeeTotalOrdersAndDeductionsDetails{
  "orderId": number,
  "orderName": string,
  "orderDeductionName": string,
  "orderTotal": number,
  "deductionTotal": number,
  "net": number
}
export class OrderFile{

  id?:number=0;
  details:string='';
  createdDate:Date =null;
}


export class EmployeeOrder{
      employeeId:number=0;
      orderFileId:number=0;
      financialYearId:number=0;
      orderId:number=0;
      details:string='';
      orderNumber:string='';
      quantity:number=0;
      creditOrDebit:string='d';
      startFrom?:Date= null;
      endAt?:Date=null;

}
export class FinancialYear{
  id? :number;
  name :string

}
