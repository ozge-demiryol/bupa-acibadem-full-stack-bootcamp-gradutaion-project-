import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Policy } from '../models/EntityModels/Policy';
import { PolicyResponseModel } from '../models/ResponseModels/PolicyResponseModel';

@Injectable({
  providedIn: 'root',
})
export class PolicyService {
  policies: Policy[] = [];
  getPoliciesUrl = 'https://localhost:44346/api/Region/GetAll';
  addPolicyUrl = 'https://localhost:44346/api/Policy';
  constructor(private httpClient: HttpClient) {}

  getAllPolicies(): Observable<PolicyResponseModel> {
    return this.httpClient.get<PolicyResponseModel>(this.getPoliciesUrl);
  }

  addAPolicy(policy:Policy): Observable<Policy> {
    return this.httpClient.post<Policy>(this.addPolicyUrl,policy)
  }
}
