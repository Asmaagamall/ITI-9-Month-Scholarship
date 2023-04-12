import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { StudentsComponent } from './students/students.component';
import { StdDetailsComponent } from './std-details/std-details.component';
import { ErrorComponent } from './error/error.component';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    StudentsComponent,
    StdDetailsComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    FormsModule,
    RouterModule.forRoot([
      {path:"" , component:HomeComponent},
      {path:"students" , component:StudentsComponent},
      {path:"student/:id" , component:StdDetailsComponent},
      {path:"**" , component:ErrorComponent}
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
