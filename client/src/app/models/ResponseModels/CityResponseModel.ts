import { City } from "../EntityModels/City";
import { BaseResponseModel } from "./BaseResponseModel";

export interface CityResponseModel extends BaseResponseModel{
  data: City[]
}
