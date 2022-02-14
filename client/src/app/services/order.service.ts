import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../models/EntityModels/Order';
import { OrderResponseModel } from '../models/ResponseModels/OrderResponseModel';

@Injectable({
  providedIn: 'root',
})
export class OrderService {
  orders: Order[] = [];
  url = 'https://localhost:44346/api/Order/GetAll';
  postUrl='https://localhost:44346/api/Order/Add';
  constructor(private httpClient: HttpClient) {}

  getAllOrders(): Observable<OrderResponseModel> {
    return this.httpClient.get<OrderResponseModel>(this.url);
  }
  addOrder(order:Order):Observable<OrderResponseModel>{
    return this.httpClient.post<OrderResponseModel>(this.postUrl ,order)
}
}
