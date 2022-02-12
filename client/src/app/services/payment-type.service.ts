import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { PaymentType } from '../models/EntityModels/PaymentType';
import { PaymentTypeResponseModel } from '../models/ResponseModels/PaymentTypeResponseModel';

@Injectable({
  providedIn: 'root',
})
export class PaymentTypeService {
  url = 'https://localhost:44346/api/PaymentType/GetAll';
  constructor(private httpClient: HttpClient) {}

  getAllTypes(): Observable<PaymentTypeResponseModel>{
    return this.httpClient.get<PaymentTypeResponseModel>(this.url);
  }
}
