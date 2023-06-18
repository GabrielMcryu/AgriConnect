import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuyVendorProductComponent } from './buy-vendor-product.component';

describe('BuyVendorProductComponent', () => {
  let component: BuyVendorProductComponent;
  let fixture: ComponentFixture<BuyVendorProductComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [BuyVendorProductComponent]
    });
    fixture = TestBed.createComponent(BuyVendorProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
