import { Component, OnInit } from '@angular/core';
import { OrdersCustomer } from 'src/app/models/EntityModels/OrdersCustomer';
import { OrdersCustomerService } from 'src/app/services/orders-customer.service';

@Component({
  selector: 'app-policy-list',
  templateUrl: './policy-list.component.html',
  styleUrls: ['./policy-list.component.scss'],
})
export class PolicyListComponent implements OnInit {
  customersStatus: OrdersCustomer[] = [];
  constructor(private _ordersCustomerService: OrdersCustomerService) {}

  ngOnInit(): void {
    this.getCustomersStatus();
  }

  getCustomersStatus(): void {
    this._ordersCustomerService.getData().subscribe((res) => {
      this.customersStatus = res.data;
    });
  }
}
