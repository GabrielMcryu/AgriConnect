import { Component, OnInit } from '@angular/core';
import { SupplierTransaction } from 'src/app/models/supplier-transaction.model';
import { AuthService } from 'src/app/services/authentication/auth.service';
import { SuppliersService } from 'src/app/services/suppliers/suppliers.service';
import { UserStoreService } from 'src/app/services/authentication/user-store.service';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-supplier-transaction-list',
  templateUrl: './supplier-transaction-list.component.html',
  styleUrls: ['./supplier-transaction-list.component.css'],
})
export class SupplierTransactionListComponent implements OnInit {
  supplierTransactions: SupplierTransaction[] = [];
  public role!: string;
  public fullName: string = '';

  constructor(
    private suppliersService: SuppliersService,
    private auth: AuthService,
    private userStore: UserStoreService,
    private datePipe: DatePipe
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

    this.suppliersService
      .getSupplierTransactionsBySupplierName(this.fullName)
      .subscribe({
        next: (supplierTransactions) => {
          this.supplierTransactions = supplierTransactions;
          console.log(this.supplierTransactions);
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
