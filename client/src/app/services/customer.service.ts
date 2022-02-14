import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from '../models/EntityModels/Customer';
import { CustomerResponseModel } from '../models/ResponseModels/CustomerResponseModel';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  getUrl="https://localhost:44346/api/Customer/GetAll"
  postUrl="https://localhost:44346/api/Customer/Add"
  constructor(private httpClient:HttpClient) { }

  getAllCustomers():Observable<CustomerResponseModel>{
    return this.httpClient.get<CustomerResponseModel>(this.getUrl)
  }

  addCustomer(customer:Customer):Observable<CustomerResponseModel>{
      return this.httpClient.post<CustomerResponseModel>(this.postUrl ,customer)
  }
}
