import { OrderStatus } from "../EntityModels/OrderStatus";
import { BaseResponseModel } from "./BaseResponseModel";

export interface OrderStatusResponseModel extends BaseResponseModel{
  data: OrderStatus[]
}
