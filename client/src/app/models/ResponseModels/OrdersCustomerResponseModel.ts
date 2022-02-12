import { OrdersCustomer } from "../EntityModels/OrdersCustomer";
import { BaseResponseModel } from "./BaseResponseModel";

export interface OrdersCustomerResponseModel extends BaseResponseModel{
data: OrdersCustomer[]
}
