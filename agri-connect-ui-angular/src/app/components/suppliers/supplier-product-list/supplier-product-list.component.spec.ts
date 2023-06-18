import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SupplierProductListComponent } from './supplier-product-list.component';

describe('SupplierProductListComponent', () => {
  let component: SupplierProductListComponent;
  let fixture: ComponentFixture<SupplierProductListComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SupplierProductListComponent]
    });
    fixture = TestBed.createComponent(SupplierProductListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
