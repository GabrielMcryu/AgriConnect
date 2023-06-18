import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SupplierProduct } from 'src/app/models/supplier-product.model';
import { SupplierTransaction } from 'src/app/models/supplier-transaction.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class SuppliersService {
  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) {}

  getAllSupplierProducts(): Observable<SupplierProduct[]> {
    return this.http.get<SupplierProduct[]>(
      this.baseApiUrl + '/api/SupplierProduct'
    );
  }

  getSupplierProduct(id: string): Observable<SupplierProduct> {
    return this.http.get<SupplierProduct>(
      this.baseApiUrl + '/api/SupplierProduct/' + id
    );
  }

  addSupplierTransaction(
    addSupplierTransactionRequest: SupplierTransaction
  ): Observable<SupplierTransaction> {
    return this.http.post<SupplierTransaction>(
      this.baseApiUrl + '/api/SupplierTransaction',
      addSupplierTransactionRequest
    );
  }

  // addSupplierTransaction(
  //   addSupplierTransactionRequest: SupplierTransaction
  // ): Observable<SupplierTransaction> {
  //   const headers = new HttpHeaders().set(
  //     'Content-Type',
  //     'application/json; charset=utf-8'
  //   );

  //   return this.http.post<SupplierTransaction>(
  //     `${this.baseApiUrl}/api/SupplierTransaction`,
  //     JSON.stringify(addSupplierTransactionRequest),
  //     { headers: headers }
  //   );
  // }
}
