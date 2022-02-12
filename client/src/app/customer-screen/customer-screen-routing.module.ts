import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuyPolicyComponent } from '../components/buy-policy/buy-policy.component';
import { CustomerHomeComponent } from '../components/customer-home/customer-home.component';

const routes: Routes = [
  { path: '', component: CustomerHomeComponent },
  { path: 'satinal', component: BuyPolicyComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class CustomerScreenRoutingModule {}
