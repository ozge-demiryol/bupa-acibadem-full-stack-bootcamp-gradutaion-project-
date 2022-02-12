import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CityResponseModel } from '../models/ResponseModels/CityResponseModel';
import { City } from '../models/EntityModels/City';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CityService {

  cityUrl = 'https://localhost:44346/api/City/GetAll';

  constructor(private httpClient: HttpClient) {}

  getAllCities():Observable<CityResponseModel>{
    return this.httpClient
    .get<CityResponseModel>(this.cityUrl)
  }

}
