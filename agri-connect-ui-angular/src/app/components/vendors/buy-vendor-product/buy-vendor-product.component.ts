import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { VendorProduct } from 'src/app/models/vendor-product.model';
import { VendorTransaction } from 'src/app/models/vendor-transaction.model';
import { VendorsService } from 'src/app/services/vendors/vendors.service';

@Component({
  selector: 'app-buy-vendor-product',
  templateUrl: './buy-vendor-product.component.html',
  styleUrls: ['./buy-vendor-product.component.css'],
})
export class BuyVendorProductComponent implements OnInit {
  buyVendorProductRequest: VendorTransaction = {
    id: 0,
    vendorName: '',
    productName: '',
    productQuantity: 0,
    cost: 0,
    transactionDate: '',
  };

  getVendorProduct: VendorProduct = {
    id: 0,
    name: '',
    price: 0,
  };

  constructor(
    private vendorsService: VendorsService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.vendorsService.getVendorProduct(id).subscribe({
            next: (response) => {
              this.getVendorProduct = response;
            },
          });
        }
      },
    });
  }

  buyVendorProduct() {
    this.buyVendorProductRequest.productName = this.getVendorProduct.name;
    this.buyVendorProductRequest.cost =
      this.getVendorProduct.price *
      this.buyVendorProductRequest.productQuantity;

    const currentDate: Date = new Date();
    const formattedDate: string = currentDate.toISOString();
    this.buyVendorProductRequest.transactionDate = formattedDate;

    console.log(this.buyVendorProductRequest);

    this.vendorsService
      .addVendorTransaction(this.buyVendorProductRequest)
      .subscribe({
        next: (vendorProduct) => {
          console.log('done');
        },
      });

    this.router.navigate(['vendor-products']);
  }
}
