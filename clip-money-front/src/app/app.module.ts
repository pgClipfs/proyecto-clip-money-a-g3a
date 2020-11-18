import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { LoginComponent } from './components/shared/login/login.component';
import { HomeComponent } from './components/shared/home/home.component';
import { RegisterComponent } from './components/shared/register/register.component';
import { Register2Component } from './components/shared/register2/register2.component';




// materials //
import {MaterialModule} from '../app/material.modules';





// Routes //

import {APP_ROUTING} from './app-routes';


// services //







@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    Register2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    APP_ROUTING
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
