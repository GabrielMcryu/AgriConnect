import { Component, OnInit } from '@angular/core';
import { VendorTransaction } from 'src/app/models/vendor-transaction.model';
import { AuthService } from 'src/app/services/authentication/auth.service';
import { VendorsService } from 'src/app/services/vendors/vendors.service';
import { UserStoreService } from 'src/app/services/authentication/user-store.service';

@Component({
  selector: 'app-vendor-transaction-list',
  templateUrl: './vendor-transaction-list.component.html',
  styleUrls: ['./vendor-transaction-list.component.css'],
})
export class VendorTransactionListComponent implements OnInit {
  vendorTransactions: VendorTransaction[] = [];
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

    this.vendorsService
      .getVendorTransactionsByVendorName(this.fullName)
      .subscribe({
        next: (vendorTransactions) => {
          this.vendorTransactions = vendorTransactions;
          console.log(this.vendorTransactions);
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
