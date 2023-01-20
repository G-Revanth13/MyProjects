import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ServiceService {

  httpOptions={
    headers:new HttpHeaders({
      'Content-Type':'application/json'
    })
  };

  constructor(private http:HttpClient) { }

  get(){
    return this.http.get('https://localhost:44318/api/Task/GetAllPassengers');  
  }

  insert(data:any){
    return this.http.post('https://localhost:44318/api/Task/insertpassengers',data,this.httpOptions).subscribe();
  }

  del(Id:any){
    return this.http.delete('https://localhost:44318/api/Task/deletepassengers/'+Id).subscribe();
  } 

  update(data:any,Id:any){
    return this.http.post('https://localhost:44318/api/Task/updatepassengers'+Id,data).subscribe();
  }
}
