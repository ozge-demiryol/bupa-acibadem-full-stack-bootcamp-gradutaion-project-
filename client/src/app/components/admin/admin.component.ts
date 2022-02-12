import { Component, OnInit } from '@angular/core';
import { Application } from 'src/app/models/EntityModels/Application';
import { Customer } from 'src/app/models/EntityModels/Customer';
import { OrdersCustomer } from 'src/app/models/EntityModels/OrdersCustomer';
import { OrderStatus } from 'src/app/models/EntityModels/OrderStatus';
import { ApplicationService } from 'src/app/services/application.service';
import { CustomerService } from 'src/app/services/customer.service';
import { OrderStatusService } from 'src/app/services/order-status.service';
import { OrdersCustomerService } from 'src/app/services/orders-customer.service';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss'],
})
export class AdminComponent implements OnInit {
  customers: Customer[] = [];
  applications: Application[] = [];
  customersStatus: OrdersCustomer[] = [];
  orderStatus: OrderStatus[] = [];
  isLoaded: boolean = false;
  constructor(
    private _customerService: CustomerService,
    private _ordersCustomerService: OrdersCustomerService,
    private _orderStatusService: OrderStatusService
  ) {}

  ngOnInit(): void {
    this.getAllCustomers();
    this.getCustomersStatus();
    this.getAllOrderStatus();
    this.isLoaded = true;
  }

  getAllCustomers(): void {
    this._customerService.getAllCustomers().subscribe((res) => {
      this.customers = res.data;
    });
  }

  getCustomersStatus(): void {
    this._ordersCustomerService.getData().subscribe((res) => {
      this.customersStatus = res.data;
    });
  }

  getAllOrderStatus(): void {
    this._orderStatusService.getAllStatus().subscribe((res) => {
      this.orderStatus = res.data;
    });
  }
}
