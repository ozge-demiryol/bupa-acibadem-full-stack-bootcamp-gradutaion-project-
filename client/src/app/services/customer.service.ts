import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerResponseModel } from '../models/ResponseModels/CustomerResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  getUrl="https://localhost:44346/api/Customer/GetAll"
  constructor(private httpClient:HttpClient) { }

  getAllCustomers():Observable<CustomerResponseModel>{
    return this.httpClient.get<CustomerResponseModel>(this.getUrl)
  }
}
