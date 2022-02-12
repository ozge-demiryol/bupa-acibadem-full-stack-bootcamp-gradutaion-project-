import { BaseResponseModel } from "./BaseResponseModel";
import { Customer } from "../EntityModels/Customer";

export interface CustomerResponseModel extends BaseResponseModel{
  data:Customer[]
}
