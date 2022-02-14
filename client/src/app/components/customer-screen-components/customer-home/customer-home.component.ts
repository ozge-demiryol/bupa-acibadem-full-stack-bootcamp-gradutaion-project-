import { Component, OnInit } from '@angular/core';
import {faBedPulse, faHeartPulse, faHospitalUser} from '@fortawesome/free-solid-svg-icons'

@Component({
  selector: 'app-customer-home',
  templateUrl: './customer-home.component.html',
  styleUrls: ['./customer-home.component.scss']
})
export class CustomerHomeComponent implements OnInit {

  bedPulseIcon=faBedPulse;
  heartPulseIcon=faHeartPulse;
  medical=faHospitalUser;
  constructor() { }

  ngOnInit(): void {
  }

}
