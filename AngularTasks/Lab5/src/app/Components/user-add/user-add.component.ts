import { Component } from '@angular/core';
import { Route, Router } from '@angular/router';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-user-add',
  templateUrl: './user-add.component.html',
  styleUrls: ['./user-add.component.css']
})
export class UserAddComponent {
  constructor(private service:UserService , private router:Router){}

  Add(name:any , age:any , email:any , phone:any){
    let newUser ={name,age,email,phone};
    this.service.addUser(newUser).subscribe();
     this.router.navigate(["/"])
  }
}
