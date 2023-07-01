import { Component, OnInit } from '@angular/core';
import { VendorProduct } from 'src/app/models/vendor-product.model';
import { VendorsService } from 'src/app/services/vendors/vendors.service';
import { AuthService } from 'src/app/services/authentication/auth.service';
import { UserStoreService } from 'src/app/services/authentication/user-store.service';

@Component({
  selector: 'app-vendor-product-list',
  templateUrl: './vendor-product-list.component.html',
  styleUrls: ['./vendor-product-list.component.css'],
})
export class VendorProductListComponent implements OnInit {
  vendorProducts: VendorProduct[] = [];

  constructor(
    private vendorsService: VendorsService,
    private auth: AuthService
  ) {}

  ngOnInit(): void {
    this.vendorsService.getAllVendorProducts().subscribe({
      next: (vendorProducts) => {
        this.vendorProducts = vendorProducts;
      },
      error: (response) => {
        console.log(response);
      },
    });
  }

  logout() {
    this.auth.signOut();
  }
}
