import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-std-details',
  templateUrl: './std-details.component.html',
  styleUrls: ['./std-details.component.css']
})
export class StdDetailsComponent {
Id = 0;
name: "Asmaa";
age:22;
email : "esm@email.com";


constructor(myActivate : ActivatedRoute){
  this.Id = myActivate.snapshot.params["id"];
  this.name = "Asmaa";
  this.age = 22;
  this.email = "esm@email.com";
}
}
