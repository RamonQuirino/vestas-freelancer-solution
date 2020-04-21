import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { AppointentModel } from '../models/Appointment-model';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  constructor(private http: HttpClient) { }

  readonly serviceBaseAddress = 'http://localhost:5000';
  readonly serviceEndPoint = '/Freelancer';

  getAppointments(): Observable<Array<AppointentModel>> {
    return this.http.get<Array<AppointentModel>>(this.serviceBaseAddress + this.serviceEndPoint);
  }
  saveAppointments(appointentModel: AppointentModel): Observable<AppointentModel>{
    return this.http.post<AppointentModel>(this.serviceBaseAddress + this.serviceEndPoint, appointentModel);
  }
}
