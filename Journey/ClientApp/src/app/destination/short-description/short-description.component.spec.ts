import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShortDescriptionComponent } from './short-description.component';

describe('ShortDescriptionComponent', () => {
  let component: ShortDescriptionComponent;
  let fixture: ComponentFixture<ShortDescriptionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShortDescriptionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShortDescriptionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
