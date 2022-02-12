import { Order } from "../EntityModels/Order";
import { BaseResponseModel } from "./BaseResponseModel";

export interface OrderResponseModel extends BaseResponseModel{
  data: Order[]
}
