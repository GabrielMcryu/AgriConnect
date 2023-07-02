import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SupplierProduct } from 'src/app/models/supplier-product.model';
import { SupplierTransaction } from 'src/app/models/supplier-transaction.model';
import { SuppliersService } from 'src/app/services/suppliers/suppliers.service';
import { HttpHeaders } from '@angular/common/http';
import { AuthService } from 'src/app/services/authentication/auth.service';
import { UserStoreService } from 'src/app/services/authentication/user-store.service';

@Component({
  selector: 'app-sell-supplier-product',
  templateUrl: './sell-supplier-product.component.html',
  styleUrls: ['./sell-supplier-product.component.css'],
})
export class SellSupplierProductComponent implements OnInit {
  public role!: string;
  public fullName: string = '';

  sellSupplierProductRequest: SupplierTransaction = {
    id: 0,
    supplierName: '',
    productName: '',
    productQuantity: 0,
    cost: 0,
    transactionDate: '',
  };

  getSupplierProduct: SupplierProduct = {
    id: 0,
    name: '',
    price: 0,
  };

  constructor(
    private suppliersService: SuppliersService,
    private router: Router,
    private route: ActivatedRoute,
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

    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.suppliersService.getSupplierProduct(id).subscribe({
            next: (response) => {
              this.getSupplierProduct = response;
            },
          });
        }
      },
    });
  }

  sellSupplierProduct() {
    this.sellSupplierProductRequest.productName = this.getSupplierProduct.name;
    this.sellSupplierProductRequest.cost =
      this.getSupplierProduct.price *
      this.sellSupplierProductRequest.productQuantity;
    this.sellSupplierProductRequest.supplierName = this.fullName;

    const currentDate: Date = new Date();
    const formattedDate: string = currentDate.toISOString();
    this.sellSupplierProductRequest.transactionDate = formattedDate;

    console.log(this.sellSupplierProductRequest);

    this.suppliersService
      .addSupplierTransaction(this.sellSupplierProductRequest)
      .subscribe({
        next: (supplierProduct) => {
          // this.router.navigate(['supplier-products']);
          console.log('done');
        },
      });

    this.router.navigate(['supplier-products']);
  }

  logout() {
    this.auth.signOut();
  }
}
