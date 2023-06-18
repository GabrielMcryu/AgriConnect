import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { VendorProduct } from 'src/app/models/vendor-product.model';
import { VendorTransaction } from 'src/app/models/vendor-transaction.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class VendorsService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllVendorProducts(): Observable<VendorProduct[]> {
    return this.http.get<VendorProduct[]>(
      this.baseApiUrl + '/api/VendorProduct'
    );
  }

  getVendorProduct(id: string): Observable<VendorProduct> {
    return this.http.get<VendorProduct>(
      this.baseApiUrl + '/api/VendorProduct/' + id
    );
  }

  addVendorTransaction(
    addVendorTransactionRequest: VendorTransaction
  ): Observable<VendorTransaction> {
    return this.http.post<VendorTransaction>(
      this.baseApiUrl + '/api/VendorTransaction',
      addVendorTransactionRequest
    );
  }
}
