import { Component, OnInit } from '@angular/core';
import { Policy } from 'src/app/models/EntityModels/Policy';
import { CustomerService } from 'src/app/services/customer.service';
import { OrderService } from 'src/app/services/order.service';
import { PolicyService } from 'src/app/services/policy.service';
import {
  faArrowRight,
  faArrowLeft,
  faCheckCircle,
} from '@fortawesome/free-solid-svg-icons';
import { PaymentTypeService } from 'src/app/services/payment-type.service';
import { PaymentType } from 'src/app/models/EntityModels/PaymentType';
import {
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { CityService } from 'src/app/services/city.service';
import { RegionService } from 'src/app/services/region.service';
import { City } from 'src/app/models/EntityModels/City';
import { Region } from 'src/app/models/EntityModels/Region';
import { CreditCardService } from 'src/app/services/credit-card.service';

@Component({
  selector: 'app-buy-policy',
  templateUrl: './buy-policy.component.html',
  styleUrls: ['./buy-policy.component.scss'],
})
export class BuyPolicyComponent implements OnInit {
  policies: Policy[] = [];
  cities: City[] = [];
  regions: Region[] = [];
  paymentTypes: PaymentType[] = [];
  step: number = 1;
  nextArrow = faArrowRight;
  prevArrow = faArrowLeft;
  checkIcon = faCheckCircle;
  isLoading: boolean = false;
  customerRegisterForm!: FormGroup;
  addOrderForm!: FormGroup;
  addCreditCardForm!: FormGroup;

  constructor(
    private _policyService: PolicyService,
    private _customerService: CustomerService,
    private _orderService: OrderService,
    private _cityService: CityService,
    private _regionService: RegionService,
    private _paymentTypeService: PaymentTypeService,
    private _creditCardService: CreditCardService,
    private formBuilder: FormBuilder
  ) {}

  ngOnInit(): void {
    this.listPolicies();
    this.listPaymentTypes();
    this.listCities();
    this.listRegions();
    this.completeAllSteps();
    //customer register form control
    this.customerRegisterForm = this.formBuilder.group({
      name: ['', [Validators.required]],
      identityNo: ['', [Validators.required]],
      surname: ['', Validators.required],
      birthDate: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      phone: ['', [Validators.required]],
      gender: ['', [Validators.required]],
      address: [
        '',
        [
          Validators.required,
          Validators.minLength(20),
          Validators.maxLength(250),
        ],
      ],
      cityId: ['', [Validators.required]],
      regionId: ['', [Validators.required]],
      height: ['', [Validators.required]],
      weight: ['', [Validators.required]],
    });
    //policy form control
    this.addOrderForm = this.formBuilder.group({
      policyId: ['', [Validators.required]],
      paymentId: ['', Validators.required],
      createdAt: [Date.now()],
    });
    //credit card form control
    this.addCreditCardForm = this.formBuilder.group({
      name: ['', [Validators.required]],
      surname: ['', [Validators.required]],
      cardNumber: ['', [Validators.required, Validators.maxLength(16)]],
      expDate: ['', [Validators.required]],
      cvv: ['', [Validators.required, Validators.maxLength(4)]],
    });
  }

  listCities(): void {
    this._cityService.getAllCities().subscribe((res) => {
      this.cities = res.data;
    });
  }

  listRegions(): void {
    this._regionService.getAllRegions().subscribe((res) => {
      this.regions = res.data;
    });
  }
  listPolicies(): void {
    this._policyService.getAllPolicies().subscribe((res) => {
      this.policies = res.data;
    });
  }

  listPaymentTypes(): void {
    this._paymentTypeService.getAllTypes().subscribe((res) => {
      this.paymentTypes = res.data;
    });
  }

  increaseStep(): void {
    if (
      this.customerRegisterForm.valid ||
      this.addOrderForm.valid ||
      this.addCreditCardForm.valid
    ) {
      this.step++;
    }
  }

  decreaseStep(): void {
    this.step--;
  }

  registerCustomer():void {
    if (this.customerRegisterForm.valid) {
      let customerModel = Object.assign({}, this.customerRegisterForm.value);
      this._customerService.addCustomer(customerModel).subscribe((data) => {
        console.log(data);
      });
    }
  }

  addOrder(): void {
    if (this.addOrderForm.valid) {
      let orderModel = Object.assign({}, this.addOrderForm.value);
      this._orderService.addOrder(orderModel).subscribe((data) => {
        console.log(data);
      });
    }
  }

  addCreditCard(): void {
    if (this.addCreditCardForm.valid) {
      let creditCardModel = Object.assign({}, this.addCreditCardForm.value);
      this._creditCardService.addCreditCard(creditCardModel).subscribe((data) => {
        console.log(data);
      });
    }
  }

  completeAllSteps(): void {
    this.registerCustomer();
    this.addOrder();
    this.addCreditCard();
    this.step++;
  }
}
