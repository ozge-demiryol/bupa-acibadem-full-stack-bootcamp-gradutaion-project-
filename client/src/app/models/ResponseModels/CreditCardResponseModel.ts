import { CreditCard } from "../EntityModels/CreditCard";
import { BaseResponseModel } from "./BaseResponseModel";

export interface CreditCardResponseModel extends BaseResponseModel{
  data:CreditCard[];
}
