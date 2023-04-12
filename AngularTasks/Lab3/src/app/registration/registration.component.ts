import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
  name = "";
  age = "";
  @Output() myEvent = new EventEmitter();
  data:{name:string , age:string}={name:"" , age:""}
  Fire(){
    this.data.name = this.name;
    this.data.age=this.age
    this.myEvent.emit(this.data);
    // console.log(this.data);
    // console.log(this.age);
    // console.log(this.name);
    this.name = "";
    this.age= "";
  }

}
