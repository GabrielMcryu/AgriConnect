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

const routes: Routes = [
  {
    path: '',
    component: HomeViewComponent,
  },
  {
    path: 'supplier-products',
    component: SupplierProductListComponent,
  },
  {
    path: 'supplier-products/sell/:id',
    component: SellSupplierProductComponent,
  },
  {
    path: 'vendor-products',
    component: VendorProductListComponent,
  },
  {
    path: 'vendor-products/buy/:id',
    component: BuyVendorProductComponent,
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
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
