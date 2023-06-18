import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SellSupplierProductComponent } from './sell-supplier-product.component';

describe('SellSupplierProductComponent', () => {
  let component: SellSupplierProductComponent;
  let fixture: ComponentFixture<SellSupplierProductComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SellSupplierProductComponent]
    });
    fixture = TestBed.createComponent(SellSupplierProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
