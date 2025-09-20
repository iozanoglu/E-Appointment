export class ResultModel<T>{
    data: any;
    ErrorMessages?:string[]
    isSuccesful:boolean = true;
    statusCode: number = 200;

}