import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username:any="";
  password:any="";

  constructor(private route:Router) { }
  
  show(){
    if(this.username=='revanth'&& this.password=='12345')
    {
     this.route.navigate(['list']);
    }
    else{
      alert('enter correct details')
    }
  }

  ngOnInit(): void {
  }

}
