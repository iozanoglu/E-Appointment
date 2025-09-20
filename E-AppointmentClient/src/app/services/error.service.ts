import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { SwalService } from './swal.service';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {

  constructor(
    private swal: SwalService
  ) { }

  errorHandler(err: HttpErrorResponse){
    console.log(err);
    let message = "Hata!";
    if(err.status === 0){
      message = "API erişimi sağlanamadı";
    }else if(err.status === 401){
      message = "Bu işlemi yapmaya yetkili değilsiniz"
    }else if(err.status===401){
      message = "Bu işlemi yapmaya yetkili değilsiniz"
    }else if(err.status === 404){
      message = "API bulunamadı";
    }else if(err.status === 500){
      message = "";
      for(const e of err.error.errorMessages){
        message += e + "\n";
      }
    }

    this.swal.callToast(message,"error");
  }
}