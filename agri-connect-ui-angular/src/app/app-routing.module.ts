import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeViewComponent } from './components/home/home-view/home-view.component';
import { SupplierProductListComponent } from './components/suppliers/supplier-product-list/supplier-product-list.component';
import { VendorProductListComponent } from './components/vendors/vendor-product-list/vendor-product-list.component';
import { SellSupplierProductComponent } from './components/suppliers/sell-supplier-product/sell-supplier-product.component';
import { BuyVendorProductComponent } from './components/vendors/buy-vendor-product/buy-vendor-product.component';
import { LoginComponent } from './components/login/login.component';
import { SignupComponent } from './components/signup/signup.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AuthGuard } from './guards/auth.guard';
import { SupplierTransactionListComponent } from './components/suppliers/supplier-transaction-list/supplier-transaction-list.component';
import { VendorTransactionListComponent } from './components/vendors/vendor-transaction-list/vendor-transaction-list.component';

const routes: Routes = [
  {
    path: '',
    component: HomeViewComponent,
  },
  {
    path: 'supplier-products',
    component: SupplierProductListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'supplier-products/sell/:id',
    component: SellSupplierProductComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'vendor-products',
    component: VendorProductListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'vendor-products/buy/:id',
    component: BuyVendorProductComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'login',
    component: LoginComponent,
  },
  {
    path: 'signup',
    component: SignupComponent,
  },
  {
    path: 'dashboard',
    component: DashboardComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'supplier-transactions/:supplier',
    component: SupplierTransactionListComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'vendor-transactions/:vendor',
    component: VendorTransactionListComponent,
    canActivate: [AuthGuard],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
