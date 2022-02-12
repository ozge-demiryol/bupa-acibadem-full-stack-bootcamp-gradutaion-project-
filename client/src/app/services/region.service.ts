import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Region } from '../models/EntityModels/Region';
import { RegionResponseModel } from '../models/ResponseModels/RegionResponseModel';

@Injectable({
  providedIn: 'root',
})
export class RegionService {
  regions: Region[] = [];
  regionUrl = 'https://localhost:44346/api/Region/GetAll';
  constructor(private httpClient: HttpClient) {}

  getAllRegions():Observable<RegionResponseModel>{
    return this.httpClient
    .get<RegionResponseModel>(this.regionUrl)
  }
}
