import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreditCard } from '../models/EntityModels/CreditCard';
import { CreditCardResponseModel } from '../models/ResponseModels/CreditCardResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CreditCardService {

  postUrl='https://localhost:44346/api/CreditCard/Add';
  constructor(private httpClient:HttpClient) { }

  addCreditCard(creditCard:CreditCard):Observable<CreditCardResponseModel>{
    return this.httpClient.post<CreditCardResponseModel>(this.postUrl ,creditCard)
}
}
