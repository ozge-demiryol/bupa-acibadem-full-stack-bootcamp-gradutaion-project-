import { Region } from "../EntityModels/Region";
import { BaseResponseModel } from "./BaseResponseModel";

export interface RegionResponseModel extends BaseResponseModel{
  data: Region[]
}
