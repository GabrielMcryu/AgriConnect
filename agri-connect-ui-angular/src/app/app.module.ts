import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeViewComponent } from './components/home/home-view/home-view.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { SupplierProductListComponent } from './components/suppliers/supplier-product-list/supplier-product-list.component';
import { VendorProductListComponent } from './components/vendors/vendor-product-list/vendor-product-list.component';
import { SellSupplierProductComponent } from './components/suppliers/sell-supplier-product/sell-supplier-product.component';
import { BuyVendorProductComponent } from './components/vendors/buy-vendor-product/buy-vendor-product.component';
import { TokenInterceptor } from './interceptors/token.interceptor';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { SupplierTransactionListComponent } from './components/suppliers/supplier-transaction-list/supplier-transaction-list.component';
import { VendorTransactionListComponent } from './components/vendors/vendor-transaction-list/vendor-transaction-list.component';
import { DatePipe } from '@angular/common';

@NgModule({
  declarations: [
    AppComponent,
    HomeViewComponent,
    SupplierProductListComponent,
    VendorProductListComponent,
    SellSupplierProductComponent,
    BuyVendorProductComponent,
    DashboardComponent,
    LoginComponent,
    SignupComponent,
    SupplierTransactionListComponent,
    VendorTransactionListComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenInterceptor,
      multi: true,
    },
    DatePipe,
  ],
  bootstrap: [AppComponent],
})
export class AppModule {}
