import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { ReactiveFormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AdminComponent } from './components/admin/admin.component';
import { SidebarComponent } from './components/admin/sidebar/sidebar.component';
import { ApplicationsComponent } from './components/admin/applications/applications.component';
import { CustomerHomeComponent } from './components/customer-screen-components/customer-home/customer-home.component';
import { BuyPolicyComponent } from './components/customer-screen-components/buy-policy/buy-policy.component';
import { AdministrationScreenModule } from './administration-screen/administration-screen.module';
import { CustomerScreenRoutingModule } from './customer-screen/customer-screen-routing.module';
import { PolicyListComponent } from './components/admin/policy-list/policy-list.component';
import { AdminHomeComponent } from './components/admin/admin-home/admin-home.component';
import { CustomerslistComponent } from './components/admin/customerslist/customerslist.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    AdminComponent,
    SidebarComponent,
    ApplicationsComponent,
    CustomerHomeComponent,
    BuyPolicyComponent,
    PolicyListComponent,
    AdminHomeComponent,
    CustomerslistComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    AdministrationScreenModule,
    CustomerScreenRoutingModule,
    ReactiveFormsModule,
    FontAwesomeModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
