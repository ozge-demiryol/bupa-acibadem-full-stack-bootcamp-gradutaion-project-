import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminComponent } from './components/admin/admin.component';
import { CustomerHomeComponent } from './components/customer-home/customer-home.component';

const routes: Routes = [
 {
    path:'',
    component:CustomerHomeComponent
  },
  {
    path: '',
    component: AdminComponent,
    children: [
      {
        path: '',
        redirectTo: '/mudurluk',
        pathMatch: 'full',
      },
      {
        path: 'mudurluk',
        loadChildren: () =>
          import('./administration-screen/administration-screen.module').then(m => m.AdministrationScreenModule),
      },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
