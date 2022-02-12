import { OrderDetail } from "../EntityModels/OrderDetail";
import { BaseResponseModel } from "./BaseResponseModel";

export interface OrderDetailResponseModel extends BaseResponseModel{
  data: OrderDetail[]
}
