import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { OrderDetail } from '../models/EntityModels/OrderDetail';
import { OrderDetailResponseModel } from '../models/ResponseModels/OrderDetailResponseModel';

@Injectable({
  providedIn: 'root',
})
export class OrderDetailService {
  orderDetails: OrderDetail[] = [];
  getUrl="https://localhost:44346/api/OrderDetail/GetAll";
  constructor(private httpClient:HttpClient) {}

  getAllOrderDetails():Observable<OrderDetailResponseModel>{
    return this.httpClient.get<OrderDetailResponseModel>(this.getUrl)
  }
}
