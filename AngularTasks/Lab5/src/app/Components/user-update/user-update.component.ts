import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-user-update',
  templateUrl: './user-update.component.html',
  styleUrls: ['./user-update.component.css']
})
export class UserUpdateComponent implements OnInit{
  
id:any;
user:any;

  constructor(private service:UserService ,private route:Router , activate:ActivatedRoute){
    this.id = activate.snapshot.params["id"];
  }
  ngOnInit(): void {
    this.service.getUserById(this.id).subscribe(
      {
        next:(data)=>{
          this.user=data;
        },
        error:(err)=>{console.log(err)}
      }
    )
  }
  Update(name:any , age:any , email:any , phone:any){
    this.service.updateUser(this.id , {name , age  , email , phone}).subscribe();
    this.route.navigate(["/"]);
  }
}
