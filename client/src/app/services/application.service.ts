import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ApplicationResponseModel } from '../models/ResponseModels/ApplicationResponseModel';

@Injectable({
  providedIn: 'root'
})
export class ApplicationService {

  url="https://localhost:44346/api/Application/GetAll";
  constructor(private httpClient: HttpClient) { }

  getApplications():Observable<ApplicationResponseModel>{
    return this.httpClient.get<ApplicationResponseModel>(this.url)
  }
}
