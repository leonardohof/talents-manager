import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TalentsCreateEditComponent } from './talents-create-edit.component';

describe('TalentsCreateEditComponent', () => {
  let component: TalentsCreateEditComponent;
  let fixture: ComponentFixture<TalentsCreateEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TalentsCreateEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TalentsCreateEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
