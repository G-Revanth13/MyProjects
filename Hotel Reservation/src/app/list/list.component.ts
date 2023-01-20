import { Component, Inject, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ServiceService } from '../service.service';
import { DialogComponent } from '../dialog/dialog.component';
import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';
import { DeleteComponent } from '../delete/delete.component';


@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  search:any;
  dataSource !:MatTableDataSource<any>
  displayedColumns=['Id','Hotel','Arrival','Departure','Type','Guests','Price','Manage'];
  

  constructor(private rout:Router,private ds:ServiceService,private dialog:MatDialog) {
    
    this.ds.get().subscribe((x)=>{this.search=x;
      this.dataSource=new MatTableDataSource(this.search);
      console.log(this.search);
    });
   }

   ngAfterViewInit(): void {
    this.dataSource.paginator = this.paginator;
    console.log(this.dataSource.sort)
    console.log(this.sort)
    this.dataSource.sort = this.sort;
  }

  out(){
    this.rout.navigate(['']);
  }

  openDialog() {
    this.dialog.open(DialogComponent,{
      // data:{
      //   height: '400px',
      //   width: '600px',
      // },
    });
  }
  
  remove(value:any){
    this.dialog.open(DeleteComponent,{
      // width:'250px',
      data:value
    })
    // window.location.reload();
   }
   onEdit(value:any){
    this.dialog.open(DialogComponent,{
      width:'50%',
      height:'100%',
      data:value,
    });
   }

   applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

  ngOnInit(): void {
  }
  

}
