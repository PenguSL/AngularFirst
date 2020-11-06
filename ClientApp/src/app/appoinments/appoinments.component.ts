import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog, MatDialogConfig} from '@angular/material/dialog';
import { AppointmentItemsComponent } from '../appointment-items/appointment-items.component';
import { AppointmentService } from '../models/appointment.service';

@Component({
  selector: 'app-appoinments',
  templateUrl: './appoinments.component.html',
  styleUrls: ['./appoinments.component.css']
})
export class AppoinmentsComponent implements OnInit {

  constructor( private service : AppointmentService,
               private dialog: MatDialog) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?:NgForm) {
    if (form = null)
    form.resetForm();
    this.service.formData  = {
      AppointmentId : null,
      AppointmentNo  : Math.floor(10000+ Math.random() * 90000).toString(),
      //Month : '',
      Date : 0,
      Note : '',
      CustomerId : 0,
      ServiceId : 0,
    };
    
    this.service.services = [];
  }

  AddOrEditOrderItem(OrderItemIndex, OrderID) {
    const dialogConfig = new MatDialogConfig();
    dialogConfig.autoFocus=true;
    dialogConfig.disableClose=true;
    dialogConfig.width="50%";
    dialogConfig.data= {OrderItemIndex, OrderID};
    this.dialog.open(AppointmentItemsComponent, dialogConfig);
  }

}
