import { Component, OnInit } from '@angular/core';
import { SupplierProduct } from 'src/app/models/supplier-product.model';
import { AuthService } from 'src/app/services/authentication/auth.service';
import { SuppliersService } from 'src/app/services/suppliers/suppliers.service';
import { UserStoreService } from 'src/app/services/authentication/user-store.service';

@Component({
  selector: 'app-supplier-product-list',
  templateUrl: './supplier-product-list.component.html',
  styleUrls: ['./supplier-product-list.component.css'],
})
export class SupplierProductListComponent implements OnInit {
  supplierProducts: SupplierProduct[] = [];
  public role!: string;
  public fullName: string = '';

  constructor(
    private suppliersService: SuppliersService,
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

    this.suppliersService.getAllSupplierProducts().subscribe({
      next: (supplierProducts) => {
        this.supplierProducts = supplierProducts;
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
