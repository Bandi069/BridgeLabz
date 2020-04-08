import { BrowserModule } from '@angular/platform-browser';
//import { NgModule } from '@angular/core';
import { RouterModule, Router } from '@angular/router';
import {MatFormFieldModule} from '@angular/material/form-field'
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {  MatButtonModule, MatInputModule, MatRippleModule} from '@angular/material';
import { MatCardModule } from '@angular/material/card';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './Component/register/register.component';
import { LoginComponent } from './Component/login/login.component';
import { ForgotPasswordComponent } from './Component/forgot-password/forgot-password.component';
import { ResetPasswordComponent } from './Component/reset-password/reset-password.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    LoginComponent,
    ForgotPasswordComponent,
    ResetPasswordComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatFormFieldModule,
    BrowserAnimationsModule,
    FormsModule,
    //FormControl,
   //FormGroup,
   ReactiveFormsModule,
    MatInputModule,
    MatButtonModule,
    MatCardModule,
    RouterModule.forRoot([])


  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA,
  ]
})
export class AppModule { }
