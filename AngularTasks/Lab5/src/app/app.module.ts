import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './Components/header/header.component';
import { UsersComponent } from './Components/users/users.component';
import { UserDetailsComponent } from './Components/user-details/user-details.component';
import { UserUpdateComponent } from './Components/user-update/user-update.component';
import { UserAddComponent } from './Components/user-add/user-add.component';
import { FormsModule  , ReactiveFormsModule} from '@angular/forms';
import {HttpClientModule} from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    UsersComponent,
    UserDetailsComponent,
    UserUpdateComponent,
    UserAddComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
