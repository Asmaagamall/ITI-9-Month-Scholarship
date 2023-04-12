import { Component } from '@angular/core';

@Component({
  selector: 'app-binding',
  templateUrl: './binding.component.html',
  styleUrls: ['./binding.component.css']
})
export class BindingComponent {
  data = "";
  getData(e:any){
    this.data = e.target.value;
  }

  reset(){
    var e : any = document.getElementsByTagName("input")[0];
    // console.log(e);
    e.value = "";
    this.data = ""
  }
}
