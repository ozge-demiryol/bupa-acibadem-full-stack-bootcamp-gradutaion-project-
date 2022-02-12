import { Component, OnInit } from '@angular/core';
import { Policy } from 'src/app/models/EntityModels/Policy';
import { CustomerService } from 'src/app/services/customer.service';
import { OrderService } from 'src/app/services/order.service';
import { PolicyService } from 'src/app/services/policy.service';
import {faArrowRight, faArrowLeft, faCheckCircle} from '@fortawesome/free-solid-svg-icons'
import { PaymentTypeService } from 'src/app/services/payment-type.service';
import { PaymentType } from 'src/app/models/EntityModels/PaymentType';

@Component({
  selector: 'app-buy-policy',
  templateUrl: './buy-policy.component.html',
  styleUrls: ['./buy-policy.component.scss']
})
export class BuyPolicyComponent implements OnInit {
policies:Policy[]=[];
paymentTypes: PaymentType[] = [];
step:number=1;
nextArrow=faArrowRight;
prevArrow=faArrowLeft;
checkIcon=faCheckCircle;
isLoading:boolean=false;

  constructor(
    private _policyService: PolicyService,
    private _customerService: CustomerService,
    private _orderService: OrderService,
    private _paymentTypeService: PaymentTypeService
    ) { }

  ngOnInit(): void {
    this.listPolicies();
    this.listPaymentTypes();
  }

  listPolicies():void{
    this._policyService.getAllPolicies().subscribe((res) => {
      this.policies = res.data;
    })
  }

  listPaymentTypes():void{
    this._paymentTypeService.getAllTypes().subscribe((res) => {
      this.paymentTypes = res.data;
    })
  }
  addCustomer():void{
    this.isLoading=true;

    this.isLoading=false;
    this.step++
  }

  addOrder():void{
    this.isLoading=true;

    this.isLoading=false;
    this.step++
  }

  goToPreviousStep():void{
    this.step--
  }

  addCreditCard():void{
    this.isLoading=true;

    this.isLoading=false;
    this.step++
  }

}
