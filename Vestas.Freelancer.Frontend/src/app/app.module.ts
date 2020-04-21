import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FreelancerComponent } from './freelancer/freelancer.component';

import {AppointmentService} from 'src/app/services/appointment.service';
import { HttpClientModule } from '@angular/common/http';
import { FreelancerAppointmentsTableComponent } from './freelancer-appointments-table/freelancer-appointments-table.component';

@NgModule({
  declarations: [
    AppComponent,
    FreelancerComponent,
    FreelancerAppointmentsTableComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [AppointmentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
