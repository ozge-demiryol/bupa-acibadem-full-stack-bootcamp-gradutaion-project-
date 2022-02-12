import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { OrdersCustomer } from '../models/EntityModels/OrdersCustomer';
import { OrdersCustomerResponseModel } from '../models/ResponseModels/OrdersCustomerResponseModel';

@Injectable({
  providedIn: 'root',
})
export class OrdersCustomerService {
  ordersCustomers: OrdersCustomer[] = [];
  url = 'https://localhost:44346/api/OrdersCustomer/GetAll';
  constructor(private httpClient: HttpClient) {}

  getData(): Observable<OrdersCustomerResponseModel> {
    return this.httpClient.get<OrdersCustomerResponseModel>(this.url);
  }
}
