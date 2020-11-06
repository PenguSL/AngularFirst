import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AppoinmentsComponent } from './appoinments/appoinments.component';
import { AppRoutingModule } from './app-routing.module';
import { Appointment } from './models/appointment.model';
import { AppointmentService } from './models/appointment.service';
import { AppointmentItemsComponent } from './appointment-items/appointment-items.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatDialogModule} from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    AppoinmentsComponent,
    AppointmentItemsComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      
    ]),
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule
  ],
  entryComponents:[AppointmentItemsComponent],
  providers: [AppointmentService], // inject Appoinment service class here
  bootstrap: [AppComponent]
})
export class AppModule { }
