import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private readonly myClient:HttpClient) { }
  private readonly URL = "http://localhost:3000/users";

  getAllUsers(){
    return this.myClient.get(this.URL);
  }
  getUserById(id:any){
    return this.myClient.get(this.URL+"/"+id);
  }

  addUser(user:any){
    return this.myClient.post(this.URL, user);
  }

  updateUser(id:any , user:any){
    return this.myClient.put(this.URL+"/"+id , user);
  }

  deleteUser(id:any){
    return this.myClient.delete(this.URL+"/"+id);
  }
}
