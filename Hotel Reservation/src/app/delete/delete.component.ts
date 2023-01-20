import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ServiceService } from '../service.service';
import{ Inject } from  '@angular/core';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {
gets:any[]=[]
@ViewChild('ref')eleRef!:ElementRef
  constructor(private dialog:MatDialog,private ds:ServiceService,@Inject(MAT_DIALOG_DATA) public data:any) { }

  ngOnInit(): void {
    console.log(this.data);
  }

  onNo(){

  }
  onOk(){
    this.ds.del(this.data.Id);
    this.eleRef.nativeElement.style.backgroundColor='red';
    window.location.reload();
  }

}
function Hostlistener(arg0: string, arg1: string[]) {
  throw new Error('Function not implemented.');
}

