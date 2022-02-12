import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { FormsModule } from '@angular/forms';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome'
/*import { DropdownModule } from 'primeng/dropdown';
import {TableModule} from 'primeng/table';
import {ButtonModule} from 'primeng/button';*/
import { AdminComponent } from './components/admin/admin.component';
import { SidebarComponent } from './components/sidebar/sidebar.component';
import { ApplicationsComponent } from './components/applications/applications.component';
import { CustomersComponent } from './customers/customers.component';

@NgModule({
  declarations: [AppComponent, HeaderComponent, AdminComponent, SidebarComponent, ApplicationsComponent, CustomersComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule,
    //DropdownModule,
    FormsModule,
    FontAwesomeModule
    //TableModule,
    //ButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
