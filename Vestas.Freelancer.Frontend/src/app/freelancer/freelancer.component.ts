import { AppointentModel } from './../models/Appointment-model';
import { Component, OnInit } from '@angular/core';
import { AppointmentService } from '../services/appointment.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-freelancer',
  templateUrl: './freelancer.component.html',
  styleUrls: ['./freelancer.component.sass']
})
export class FreelancerComponent implements OnInit {

  constructor(private appointmentService: AppointmentService)
  {
  }
  model: AppointentModel;
  appointments: Array<AppointentModel> ;

  saveAppointment(){
    console.log(this.model);
    this.appointmentService.saveAppointments(this.model)
      .subscribe(
        () => {
          alert('Appoinmtment saved with success');
        });
    this.cleanModel();
    this.getAppointments();
  }

  getAppointments()
  {
    // this.appointments = new Array<AppointentModel>();
    // this.appointments.push(
    //     {
    //       ProjectName: '12312',
    //       AppointmentEndTime: new Date(),
    //       AppointmentStartTime: new Date()
    //     }
    // );
    this.appointmentService.getAppointments()
       .subscribe(result => {
         this.appointments = result;
         console.log(result);
        });
  }

  cleanModel(){
    this.model = {
      ProjectName: '',
      AppointmentStartTime: new Date(),
      AppointmentEndTime: new Date()
    };
  }

  ngOnInit(): void {
    this.getAppointments();
    this.cleanModel();
  }

}
