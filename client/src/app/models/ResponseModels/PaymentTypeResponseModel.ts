import { PaymentType } from "../EntityModels/PaymentType";
import { BaseResponseModel } from "./BaseResponseModel";

export interface PaymentTypeResponseModel extends BaseResponseModel{
  data: PaymentType[]
}
