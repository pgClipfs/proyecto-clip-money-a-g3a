import { Component, OnInit } from '@angular/core';
import { Cliente } from 'src/app/models/cliente';
import { ValuesService } from 'src/app/services/values.service';


import {AuthServiceService } from '../../../services/auth-service.service'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
    values: Cliente[];

    constructor(private valuesService: ValuesService, private authService : AuthServiceService) {
      this.auth = this.authService.getAuth()
     }

    ngOnInit(): void {
      this.valuesService.getAll().subscribe(v => {
        this.values = v;
      });
    }
  auth : boolean = false;
  
  login(){
    this.authService.login("Rodolfo", 255)
    this.auth = this.authService.getAuth()
  }
  logout(){
    this.authService.logout()
    this.auth = this.authService.getAuth()
  }
  

  }
