import { Component, OnInit } from '@angular/core';
import {AuthServiceService } from '../../../services/auth-service.service'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.sass']
})
export class HomeComponent implements OnInit {
  auth : boolean = false;
  constructor(private authService : AuthServiceService) { 
    this.auth = this.authService.getAuth()
  }
  login(){
    this.authService.login()
    this.auth = this.authService.getAuth()
  }
  logout(){
    this.authService.logout()
    this.auth = this.authService.getAuth()
  }
  ngOnInit(): void {
  }

}
