import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  students:{}[]=[];
  getData(data:any){
    if(data.name.length >3 && (data.age < 40 || data.age > 20))
    this.students.push(data);
    // console.log(this.students);
  } 
}
