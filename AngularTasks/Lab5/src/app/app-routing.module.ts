import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UsersComponent } from './Components/users/users.component';
import { UserDetailsComponent } from './Components/user-details/user-details.component';
import { UserAddComponent } from './Components/user-add/user-add.component';
import { UserUpdateComponent } from './Components/user-update/user-update.component';

const routes: Routes = [
  {path:"" , component:UsersComponent},
  {path:"users" , component:UsersComponent},
  {path:"users/:id" , component:UserDetailsComponent},
  {path:"adduser" , component:UserAddComponent},
  {path:"usrDetails/:id" , component:UserDetailsComponent},
  {path:"updateUser/:id" , component:UserUpdateComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
