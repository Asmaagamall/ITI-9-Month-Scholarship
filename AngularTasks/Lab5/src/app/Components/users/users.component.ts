import { Component , OnInit } from '@angular/core';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {
  constructor(private service :UserService){}

  users:any;
  ngOnInit():void{
    this.service.getAllUsers().subscribe(
      {
        next:(data)=>{
          //console.log(data)
          this.users = data;
        },
        error:(err)=>{console.log(err)}
      });

  }

  delete(id:any){
      let deleted = confirm("Are you sure you want to delete this user?");

      if(deleted){
        this.service.deleteUser(id).subscribe(
          {
            next:()=>{},
            error:()=>{}
          }
        )
      }
  }
}
