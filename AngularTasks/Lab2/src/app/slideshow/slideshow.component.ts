import { Component } from '@angular/core';
var i : number=0;
var timer:any;
const img :string[] = ['/assets/images/1.jpg', './assets/images/2.jpg', '/assets/images/3.jpg', '/assets/images/4.jpg','/assets/images/5.jpg', '/assets/images/6.jpg'];

@Component({
  selector: 'app-slideshow',
  templateUrl: './slideshow.component.html',
  styleUrls: ['./slideshow.component.css']
})
export class SlideshowComponent {
  imgsrc = "/assets/images/1.jpg"
  Next(): void {
  if(i!=img.length)
  {
      document.images[0].src=img[i++];
  }
  else
  {
     i=0;
  }
 }


 Previous(){
    if(i > 0)
      {
          i--;
          document.images[0].src=img[i];
      }
      else{
          i = img.length -1;
          document.images[0].src=img[i];
          i--;
      }
  }

  SlideShow(){
    timer= setInterval((e:any)=>{
      this.Next();
    }
    ,500);
  }
  Stop(){
    clearInterval(timer)
  }

}
