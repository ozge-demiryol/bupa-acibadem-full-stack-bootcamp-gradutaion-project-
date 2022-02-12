import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { OrderStatus } from '../models/EntityModels/OrderStatus';
import { OrderStatusResponseModel } from '../models/ResponseModels/OrderStatusResponseModel';

@Injectable({
  providedIn: 'root'
})
export class OrderStatusService {

  status:OrderStatus[]=[];
  url="https://localhost:44346/api/OrderStatus/GetAll"
  constructor(private httpClient: HttpClient) { }

  getAllStatus():Observable<OrderStatusResponseModel>{
    return this.httpClient.get<OrderStatusResponseModel>(this.url)
  }
}
