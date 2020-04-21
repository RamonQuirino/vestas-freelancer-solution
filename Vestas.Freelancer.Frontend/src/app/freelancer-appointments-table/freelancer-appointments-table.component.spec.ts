import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FreelancerAppointmentsTableComponent } from './freelancer-appointments-table.component';

describe('FreelancerAppointmentsTableComponent', () => {
  let component: FreelancerAppointmentsTableComponent;
  let fixture: ComponentFixture<FreelancerAppointmentsTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FreelancerAppointmentsTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FreelancerAppointmentsTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
