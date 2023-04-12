import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/Services/user.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {
  id:any;
  user:any;
  constructor(activate:ActivatedRoute ,private service:UserService){
    this.id = activate.snapshot.params["id"];
  }
  ngOnInit(): void {
    this.service.getUserById(this.id).subscribe(
      {
        next:(data)=>{
          this.user = data;
        },
        error:(err)=>{console.log(err)}
      }
    )
  }

}
