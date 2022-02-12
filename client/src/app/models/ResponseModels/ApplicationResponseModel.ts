import { Application } from "../EntityModels/Application";
import { BaseResponseModel } from "./BaseResponseModel";

export interface ApplicationResponseModel extends BaseResponseModel{
  data: Application[]
}
