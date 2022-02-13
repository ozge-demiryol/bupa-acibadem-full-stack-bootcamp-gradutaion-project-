import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/EntityModels/Customer';
import { CustomerService } from 'src/app/services/customer.service';
import {faSearch} from '@fortawesome/free-solid-svg-icons'

@Component({
  selector: 'app-customerslist',
  templateUrl: './customerslist.component.html',
  styleUrls: ['./customerslist.component.scss']
})
export class CustomerslistComponent implements OnInit {

  searchIcon=faSearch;
  customers: Customer[] = [];
  constructor(private _customerService: CustomerService,) { }

  ngOnInit(): void {
    this.getAllCustomers();
  }
  getAllCustomers(): void {
    this._customerService.getAllCustomers().subscribe((res) => {
      this.customers = res.data;
    });
  }
}
