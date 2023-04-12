import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  formValidation = new FormGroup({
    name: new FormControl("",[Validators.required , Validators.minLength(3)]),
    age: new FormControl(0,[Validators.required , Validators.min(20), Validators.max(40)]),
    email: new FormControl("",[Validators.required , Validators.email ]),
  })

  get NameValid(){
    return this.formValidation.controls["name"].valid
  }


  get AgeValid(){
    return this.formValidation.controls["age"].valid
  }

  get EmailValid(){
    return this.formValidation.controls["email"].valid
  }

  getValue(){
    // console.log("ttttttt");
    if(this.formValidation.status=="VALID"){
      alert("Register Done!");
    }
    else{
      alert("Try it again");
    }
    
  }
}
