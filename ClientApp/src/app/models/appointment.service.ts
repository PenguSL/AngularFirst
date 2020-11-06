import { Injectable } from '@angular/core';
import { Appointment } from './appointment.model';
import { Service } from './service.model';

@Injectable({
  providedIn: 'root'
})
export class AppointmentService {

  formData : Appointment;
  services : Service[];
  
  constructor() { }
}
