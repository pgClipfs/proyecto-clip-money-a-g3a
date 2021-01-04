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
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { ErrorInterceptor } from './helpers/error.interceptor';
import {FormControl} from "@angular/forms";
// materials //
import {MaterialModule} from '../app/material.modules';





// Routes //

import {APP_ROUTING} from './app-routes';
import { SidenavComponent } from './components/shared/sidenav/sidenav.component';
import { ConsultarComponent } from './components/shared/consultar/consultar.component';
import { IngresarComponent } from './components/shared/ingresar/ingresar.component';
import { RetirarComponent } from './components/shared/retirar/retirar.component';
import { ModificarDatosComponent } from './components/shared/modificar-datos/modificar-datos.component';
import { TestScreenComponent } from './components/test-screen/test-screen.component';


// services //







@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    FooterComponent,
    LoginComponent,
    RegisterComponent,
    HomeComponent,
    Register2Component,
    SidenavComponent,
    ConsultarComponent,
    IngresarComponent,
    RetirarComponent,
    ModificarDatosComponent,
    TestScreenComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    APP_ROUTING
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
