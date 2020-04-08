import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegisterComponent } from './Component/register/register.component';
import { CommonModule } from '@angular/common';
import {LoginComponent} from './Component/login/login.component';
import { ForgotPasswordComponent }  from './Component/forgot-password/forgot-password.component';
import {ResetPasswordComponent} from './Component/reset-password/reset-password.component';

const routes: Routes = [
  { path :'register',component:RegisterComponent},
  {path : 'login', component: LoginComponent},
  {path : 'forgot', component: ForgotPasswordComponent},
   {path : 'resetpassword', component: ResetPasswordComponent},
];
@NgModule({
  imports: [
    CommonModule,
    RouterModule,
        RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
