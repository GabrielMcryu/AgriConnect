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
  public role!: string;
  public fullName: string = '';

  constructor(
    private vendorsService: VendorsService,
    private auth: AuthService,
    private userStore: UserStoreService
  ) {}

  ngOnInit(): void {
    this.userStore.getFullNameFromStore().subscribe((val) => {
      let fullNameFromToken = this.auth.getFullNameFromToken();
      this.fullName = val || fullNameFromToken;
    });

    this.userStore.getRoleFromStore().subscribe((val) => {
      const roleFromToken = this.auth.getRoleFromToken();
      this.role = val || roleFromToken;
    });

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
