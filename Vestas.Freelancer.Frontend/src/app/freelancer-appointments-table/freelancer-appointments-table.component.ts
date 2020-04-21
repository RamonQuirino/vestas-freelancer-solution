import { Component, OnInit, Input } from '@angular/core';
import { AppointentModel } from '../models/Appointment-model';

@Component({
  selector: 'app-freelancer-appointments-table',
  templateUrl: './freelancer-appointments-table.component.html',
  styleUrls: ['./freelancer-appointments-table.component.sass']
})
export class FreelancerAppointmentsTableComponent implements OnInit {

  @Input() appointments: Array<AppointentModel>;
  constructor() { }

  ngOnInit(): void {
  }

}
