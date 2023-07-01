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

  constructor(
    private suppliersService: SuppliersService,
    private auth: AuthService
  ) {}

  ngOnInit(): void {
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
