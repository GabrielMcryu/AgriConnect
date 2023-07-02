import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VendorTransactionListComponent } from './vendor-transaction-list.component';

describe('VendorTransactionListComponent', () => {
  let component: VendorTransactionListComponent;
  let fixture: ComponentFixture<VendorTransactionListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [VendorTransactionListComponent]
    });
    fixture = TestBed.createComponent(VendorTransactionListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
