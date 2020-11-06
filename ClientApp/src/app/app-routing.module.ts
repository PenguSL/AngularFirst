import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppoinmentsComponent } from './appoinments/appoinments.component';

const routes: Routes = [
  {path:'', redirectTo:'appointments', pathMatch:'full'},
  {path:'appointments', component:AppoinmentsComponent}, // apppointments
  {path: 'appointment', children:[
    { path:'', component:AppoinmentsComponent},  // appointments/appointment
    { path:'edit/:id', component:AppoinmentsComponent} // appointments/appointment/5
  ]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }