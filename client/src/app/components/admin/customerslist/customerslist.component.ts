import { Component, OnInit } from '@angular/core';
import { Customer } from 'src/app/models/EntityModels/Customer';
import { CustomerService } from 'src/app/services/customer.service';

@Component({
  selector: 'app-customerslist',
  templateUrl: './customerslist.component.html',
  styleUrls: ['./customerslist.component.scss']
})
export class CustomerslistComponent implements OnInit {
  page=1;
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

  onDataTableChange(event:any):void{
    this.page=event;
    this.getAllCustomers();
  }

}
