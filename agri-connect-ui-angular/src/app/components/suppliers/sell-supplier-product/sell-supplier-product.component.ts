import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SupplierProduct } from 'src/app/models/supplier-product.model';
import { SupplierTransaction } from 'src/app/models/supplier-transaction.model';
import { SuppliersService } from 'src/app/services/suppliers/suppliers.service';
import { HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-sell-supplier-product',
  templateUrl: './sell-supplier-product.component.html',
  styleUrls: ['./sell-supplier-product.component.css'],
})
export class SellSupplierProductComponent implements OnInit {
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
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
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

    const currentDate: Date = new Date();
    const formattedDate: string = currentDate.toISOString();
    this.sellSupplierProductRequest.transactionDate = formattedDate;

    console.log(this.sellSupplierProductRequest);

    const headers = new HttpHeaders({ 'Content-Type': 'application/json' });

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
}
