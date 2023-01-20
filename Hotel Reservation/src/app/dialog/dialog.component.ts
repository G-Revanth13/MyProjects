import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ServiceService } from '../service.service';
import{Inject} from '@angular/core'


@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent implements OnInit {
  traveller: any;

  constructor(private ds:ServiceService,@Inject(MAT_DIALOG_DATA) public data:any) { }

  ngOnInit(): void {
    this.traveller=new FormGroup({
      Id:new FormControl(''),
      Hotel:new FormControl(''),
      Arrival:new FormControl(''),
      Departure:new FormControl(''),
      Type:new FormControl(''),
      Guests:new FormControl(''),
      Price:new FormControl(''),
    })
     this.traveller.patchvalue({
      Id:this.data.Id,
      Hotel:this.data.Hotel,
      Arrival:this.data.Arrival,
      Departure:this.data.Departure,
      Type:this.data.Type,
      Guests:this.data.Guests,
      Price:this.data.Price,
    })
  }

  save()  {
    let serializedForm=JSON.stringify(this.traveller.value);
    console.log(serializedForm);
    this.ds.insert(serializedForm);
    window.location.reload();
  } 

}
