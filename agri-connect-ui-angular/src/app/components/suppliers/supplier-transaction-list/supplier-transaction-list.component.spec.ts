import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SupplierTransactionListComponent } from './supplier-transaction-list.component';

describe('SupplierTransactionListComponent', () => {
  let component: SupplierTransactionListComponent;
  let fixture: ComponentFixture<SupplierTransactionListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SupplierTransactionListComponent]
    });
    fixture = TestBed.createComponent(SupplierTransactionListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
