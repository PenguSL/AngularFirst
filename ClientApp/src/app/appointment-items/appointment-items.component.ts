import { Component, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from "@angular/material";
import { Service } from "../models/service.model";

@Component({
  selector: 'app-appointment-items',
  templateUrl: './appointment-items.component.html', 
  styleUrls: ['./appointment-items.component.css']
})
export class AppointmentItemsComponent implements OnInit {
  formData : Service;

  constructor(
    @Inject(MAT_DIALOG_DATA) public data,
    public dialogRef: MatDialogRef<AppointmentItemsComponent> ) { }

  ngOnInit() {
    this.formData ={
    ServiceId : this.data.ServiceId,
    ServiceName : '',
   // AppointmentId : null,
    Price : 0,
    Quanity : 0,
    Total : 0,
    }
  }

}


