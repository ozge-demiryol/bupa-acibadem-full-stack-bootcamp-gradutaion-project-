import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../models/EntityModels/Order';
import { OrderResponseModel } from '../models/ResponseModels/OrderResponseModel';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  orders:Order[]=[];
  getUrl="https://localhost:44346/api/Order/GetAll";
  constructor(private httpClient:HttpClient) { }

  getAllOrders():Observable<OrderResponseModel>{
    return this.httpClient.get<OrderResponseModel>(this.getUrl)
  }
}
