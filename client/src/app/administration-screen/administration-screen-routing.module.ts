import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminHomeComponent } from '../components/admin-home/admin-home.component';
import { AdminComponent } from '../components/admin/admin.component';
import { ApplicationsComponent } from '../components/applications/applications.component';
import { CustomerslistComponent } from '../components/customerslist/customerslist.component';
import { PolicyListComponent } from '../components/policy-list/policy-list.component';

const routes: Routes = [
  {
    path: '',
    component: AdminComponent,
    children: [
      {
        path:'',
        component:AdminHomeComponent
      },
      {
        path: 'basvurular',
        component: ApplicationsComponent,
      },
      {
        path: 'policeler',
        component: PolicyListComponent,
      },{
        path: 'musteriler',
        component: CustomerslistComponent,
      }
    ],
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AdministrationScreenRoutingModule { }
