import { Policy } from "../EntityModels/Policy";
import { BaseResponseModel } from "./BaseResponseModel";

export interface PolicyResponseModel extends BaseResponseModel{
  data: Policy[]
}
